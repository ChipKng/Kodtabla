using System;
using System.Text;
using System.Windows.Forms;

namespace KodTabla
{
    public partial class frmDocument : Form
    {
        public string fileName { get; set; }
        public string[] fileContent { get; set; }
        public string[] importedFileContent { get; set; }
        public int fileErrorsNum { get; set; }
        public string[] FlatCodes { get; set; }
        public string[] ProxyCodes { get; set; }
        private class position{
            public int line { get; set; }
            public int column { get; set; }
        }
        private class proxyData
        {
            public int proxy_num { get; set; }
            public string flat { get; set; }
            public string code { get; set; }
        }

        public frmDocument()
        {
            InitializeComponent();
        }

        public byte hex2byte(string hex)
        {
            return byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        public int hex2int(string hex)
        {
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
        public string int2hex(int num)
        {
            return num.ToString("X2");
        }

        private void AddMessage(string message)
        {
            txtMessages.AppendText( message + Environment.NewLine);
        }

        private void AddError(int lineNum, string message)
        {
            fileErrorsNum++;
            AddMessage("Line:" +(lineNum + 1).ToString() + " - " + message);
        }
        private string calcIntelChecksum(string data)
        {
            int i = 0;
            string sum = "";
            int datasum = 0;
            
            for ( i = 0; i < data.Length/2; i++ )
            {
                datasum += hex2byte(data.Substring(i*2,2));
            }

            datasum = (byte)datasum & (byte)255;
            datasum = (byte)datasum ^ (byte)255;
            datasum++;
            datasum = (byte)datasum % 256;

            sum = ( datasum ).ToString("X2") ;
            return sum;
        }
        public void validateFileContent(string[] fc, bool fixing = false)
        {
            fileErrorsNum = 0;
            int lineNum = 0;
            AddMessage(Environment.NewLine + "-----------------------------------");
            AddMessage( DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " Validation started.");
            if (fc.Length < 1)
            {
                AddError(0,"File Content is empty.");
            }

            bool eol = false;

            for (lineNum = 0; lineNum < fc.Length; lineNum++)
            {
                string line = fc[lineNum];
                if (line.Length > 0)
                {
                    // evaluate the record structure
                    if (line[0] != ':')
                    {
                        // missing start code
                        AddError(lineNum, "Missing start code \":\"");
                        if (fixing == true)
                        {
                            fc[lineNum] = ":" + fc[lineNum];
                            line = fc[lineNum]; // Update the fixed line
                            AddError(lineNum, "FIX: \":\" added to the beginning");
                        }
                    }

                    if (eol == true)
                    {
                        // this line is behind EOL line!
                        AddError(lineNum, "row behind the end of line marking");
                    }
                    int bytecount = hex2int(line.Substring(1, 2));
                    if (line.Length != bytecount * 2 + 11)
                    {
                        // the given amount of data is incorrect
                        AddError(lineNum, "byte length does not match (given:" + (bytecount * 2).ToString() + ", found:" + (line.Length - 9).ToString() + ")");
                    }
                    string address = line.Substring(3, 4);
                    int recordType = hex2int(line.Substring(7, 2));
                    string checkSum = line.Substring(9 + (bytecount * 2), 2);
                    string data = line.Substring(1, bytecount * 2 + 8);
                    if (recordType == 1)
                    {
                        // End of file
                        eol = true;
                        if (line != ":00000001FF")
                        {
                            AddError(lineNum, "Incorrect end of file line");
                            if (fixing == true)
                            {
                                fc[lineNum] = ":00000001FF";
                                AddMessage("FIX: Changed end of line to correct one :00000001FF");
                            }
                        }
                    }
                    if (recordType == 0 || recordType == 4)
                    {
                        // Data type, calculate checksum!
                        string calcedSum = calcIntelChecksum(data);
                        if (calcedSum != checkSum)
                        {
                            AddError(lineNum, "Checksum mismatch! calculated: " + calcedSum + " found:" + checkSum);
                            if (fixing == true)
                            {
                                fc[lineNum] = fc[lineNum].Substring(0, fc[lineNum].Length - 2) + calcedSum;
                                AddMessage("FIX: updated checksum to " + calcedSum);
                            }
                        }
                    }
                } // if row is not empty
            } // For loop
            if (eol == false)
            {
                AddMessage("There is no end of file line present!");
                if (fixing == true)
                {
                    if (fc[fc.Length -1] == "")
                    {
                        // If last line is empty line, just put it there
                        fc[fc.Length -1] = ":00000001FF";
                    }
                    else
                    {
                        // Adding the extra line to the end of the string array
                        // need to be tested!
                        string[] valami;  // Must use a temp value because it does not work with the global one. don't ask me why
                        valami = fc;
                        Array.Resize(ref valami, valami.Length + 1);
                        fc[valami.Length - 1] = ":00000001FF";
                        fc = valami;
                    }
                }
            }
            AddMessage( DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " Validation Finished.");
            if (fixing == true)
            {
                // Refresh the updated view
                rtbView.Text = dumpToText(fc);
            }
        }

        private string dumpToText(string[] input)
        {
            int i = 0;
            string result = "";
            foreach (string line in input)
            {
                i++;
                result += i.ToString("D4")+ "| " + line + Environment.NewLine;
            }
            return result;
        }
        private string getdecvalue(int fpos, int pos, int len = 2)
        {
            // TODO: Error handling
            return hex2int(fileContent[fpos].Substring(pos, len)).ToString();
        }

        private position getProxyCodePos(int proxyNum, bool flatCode = true)
        {
            // Calculate proxy code position
            // First line is row 66
            // First character is 9 (5 byte)
            // Last character in row is 38 (20 byte + checksum) 
            // 1 proxy flat data is 1 byte long
            // :
            // FCxxxxCCCCCC - structure: fc: flat code, C-code
            // Next record : 6 bytes
            position pos = new position();
            pos.line = 65; // Basis
            int i; // 
            int rounded;
            i = proxyNum * 12; // Full record position in flat line
            rounded = (i / 28);  // Find the row with dividing by available size (integer division rounded to zero)
            pos.line += rounded;
            pos.column = 9 + (i - (rounded * 28));
            if (flatCode == false)
            {
                // If we need the proxy code instead we need to proceed further
                if (pos.column + 6 >  40)
                {
                    pos.line++; // The data is in the next line
                    pos.column = 9 + (pos.column + 6 - 40);
                }
            }
            return pos;
        }

        private void updateProxyDataView()
        {

            position pos = new position();
            proxyData pd = new proxyData();
            pos = getProxyCodePos(0);
            pos = getProxyCodePos(1);
            pos = getProxyCodePos(2);
            pos = getProxyCodePos(3);
            pos = getProxyCodePos(4);
            pos = getProxyCodePos(10);
            pos = getProxyCodePos(25);
            pos.line = 65;
            pos.column = 9; // start from here
            int j;
            string line = fileContent[pos.line];

            for (int proxy = 0; proxy < 1024; proxy++)
            {
                // FC....CCCCCC - structure: fc: flat code, C-code

                string debugline;
                if (pos.column+12 < line.Length) debugline = fileContent[pos.line].Substring(pos.column,12);
                else debugline = fileContent[pos.line].Substring(pos.column);

                pd.code = "";
                pd.flat = line.Substring(pos.column, 2);

                pos.column += 6; // step to next data
                                 // Create a reader for the next data because it might be partly in the next line

                for (j = 0; j < 3; j++) // 3 bytes to read
                {
                    if (pos.column >= line.Length - 2)
                    {
                        int diff = line.Length - pos.column; // in case we skip 6 the rest
                        pos.line++; // next line please
                        line = fileContent[pos.line]; // read the new line
                        pos.column = 9 + (2 - diff); // go back to the first data of the line
                    }
                    pd.code += line.Substring(pos.column, 2);
                    pos.column += 2;
                } // for j

                if (pos.column >= line.Length - 2)
                {
                    pos.line++; // next line please
                    line = fileContent[pos.line]; // read the new line
                    pos.column = 9; // go back to the first data of the line
                }

                dgProxyList.Rows.Add((proxy + 1).ToString(), hex2int(pd.flat).ToString(), hex2int(pd.code).ToString());
            } // for i
        }
        private void updateParametersOnControls()
        {
            // Read parameters from file and fill the controls with it
            txtReset.Text = fileContent[34][20].ToString() + fileContent[34][18] + fileContent[34][16] + fileContent[34][14] + fileContent[34][12] + fileContent[34][10];
            txtClosureTime.Text = getdecvalue(35, 9);
            txtRingTime.Text = getdecvalue(36, 9);
            txtTalkTime.Text = getdecvalue(37, 9);
            txtValidation.Text = getdecvalue(38, 9);

            txtRingVol.Text = getdecvalue(39, 9);
            txtDoorVol.Text = getdecvalue(40, 9);
            txtButtonVol.Text = getdecvalue(41, 9);
            txtFirstFlat.Text = getdecvalue(37, 11);
            txtLastFlat.Text = getdecvalue(38, 11);

            txtTalkBUSV.Text = getdecvalue(35, 11);
            txtBaseBUSV.Text = getdecvalue(36, 11);

            // Read proxy codes
            if (ProxyCodes == null)
            {
                ProxyCodes = new string[1024];
            }

            updateProxyDataView();

            if (FlatCodes == null)
            {
                FlatCodes = new string[256];
            }
            UpdateFlatcodesFromFileArray(fileContent);
        }

        private void UpdateFlatcodesFromFileArray(string [] fc)
        {
            // Read flat codes
            int flat = 0;
            int file_row = 1;
            while (flat < 255)
            {
                FlatCodes[flat++] = fc[file_row].Substring(9, 4);
                FlatCodes[flat++] = fc[file_row].Substring(13, 4);
                FlatCodes[flat++] = fc[file_row].Substring(17, 4);
                FlatCodes[flat++] = fc[file_row].Substring(21, 4);
                FlatCodes[flat++] = fc[file_row].Substring(25, 4);
                FlatCodes[flat++] = fc[file_row].Substring(29, 4);
                FlatCodes[flat++] = fc[file_row].Substring(33, 4);
                FlatCodes[flat++] = fc[file_row].Substring(37, 4);
                file_row++;
            }
            dgFlatCodes.SelectAll();
            dgFlatCodes.ClearSelection();
            for (flat = 0; flat < 256; flat++)
            {
                dgFlatCodes.Rows.Add(flat.ToString(), FlatCodes[flat], "0");
            }
        }

        private void updateByteParametersInFileContent(int fpos, int pos, int value, bool updateSum = true)
        {
            int padding = 6; // +6 because of line number padding
            string newValue = int2hex(value);
            string newLine = fileContent[fpos].Substring(0, pos ) + newValue + fileContent[fpos].Substring(pos + 2);
            if (fileContent[fpos] != newLine)
            {
                fileContent[fpos] = newLine;
                rtbView.Select(rtbView.GetFirstCharIndexFromLine(fpos) + pos + padding, 2);
                rtbView.SelectionColor = System.Drawing.Color.Red;
                rtbView.SelectedText = newValue;

                // Update checksum as well
                if (updateSum == true)
                {
                    int bytecount = hex2int(newLine.Substring(1, 2));
                    string data = newLine.Substring(1, bytecount * 2 + 8);
                    string newCheckSum = calcIntelChecksum(data);
                    newLine = newLine.Substring(0, 1 + bytecount * 2 + 8) + newCheckSum;
                    rtbView.Select(rtbView.GetFirstCharIndexFromLine(fpos) + padding + 1 + bytecount*2 + 8, 2);
                    rtbView.SelectionColor = System.Drawing.Color.Red;
                    rtbView.SelectedText = newCheckSum;

                    fileContent[fpos] = newLine;
                }
            }
        }
        private void updateStringParametersInFileContent(int fpos, int pos, string value, bool updateSum = true)
        {
            int padding = 6; // +6 because of line number padding
            string newLine = fileContent[fpos].Substring(0, pos) + value + fileContent[fpos].Substring(pos + value.Length);
            if (fileContent[fpos] != newLine)
            {
                fileContent[fpos] = newLine;
                rtbView.Select(rtbView.GetFirstCharIndexFromLine(fpos) + pos + padding, value.Length);
                rtbView.SelectionColor = System.Drawing.Color.Red;
                rtbView.SelectedText = value;

                // Update checksum as well
                if (updateSum == true)
                {
                    newLine = UpdateChecksumOnLine(fpos, newLine, padding);
                }
            }
        }

        private string UpdateChecksumOnLine(int fpos, string newLine, int padding = 6)
        {
            int bytecount = hex2int(newLine.Substring(1, 2));
            string data = newLine.Substring(1, bytecount * 2 + 8);
            string newCheckSum = calcIntelChecksum(data);
            newLine = newLine.Substring(0, 1 + bytecount * 2 + 8) + newCheckSum;
            rtbView.Select(rtbView.GetFirstCharIndexFromLine(fpos) + padding + 1 + bytecount * 2 + 8, 2);
            rtbView.SelectionColor = System.Drawing.Color.Red;
            rtbView.SelectedText = newCheckSum;

            fileContent[fpos] = newLine;
            return newLine;
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                fileContent = System.IO.File.ReadAllLines(fileName);
                validateFileContent(fileContent);
                rtbView.Text = dumpToText(fileContent);
                this.Text = fileName;
            }
            updateParametersOnControls();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Validating button
            validateFileContent(fileContent);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            validateFileContent(fileContent, true);
        }

        private void SaveDocument()
        {
            // need for Save and Save AS
            try
            {
                System.IO.File.WriteAllLines(fileName, fileContent);
                AddMessage("File " + fileName + " successfully saved." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                AddMessage("Saving " + fileName + " error:" + ex.Message + Environment.NewLine);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = fileName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName; // Update the filename to the selected one
                SaveDocument(); // Do the job
            }
        }

        private void txtFieldUpdated(TextBox t, int fpos, int pos, TrackBar trb = null)
        {
            int n;
            if (int.TryParse(t.Text, out n) == true)
            {
                if (n > 255 || n < 0)
                {
                    MessageBox.Show("Incorrect value for " + t.AccessibleName + "!", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    updateByteParametersInFileContent(fpos, pos, n);
                    if (trb != null)
                    {
                        // we need to update the trackbar as well
                        trb.Value = n;
                    }
                }
            }
        }

        private void tbRingVol_Scroll(object sender, EventArgs e)
        {
            txtRingVol.Text = tbRingVol.Value.ToString();
        }

        private void txtRingVol_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtRingVol, 39, 9, tbRingVol);
        }

        private void tbDoorVol_Scroll(object sender, EventArgs e)
        {
            txtDoorVol.Text = tbDoorVol.Value.ToString();
        }

        private void tbButtonVol_Scroll(object sender, EventArgs e)
        {
            txtButtonVol.Text = tbButtonVol.Value.ToString();
        }


        private void txtDoorVol_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtDoorVol, 40, 9, tbDoorVol);
        }

        private void txtButtonVol_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtButtonVol, 41, 9, tbButtonVol);
        }

        private void txtClosureTime_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtClosureTime, 35, 9);
        }

        private void txtRingTime_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtRingTime, 36, 9);
        }

        private void txtTalkTime_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtTalkTime, 37, 9);
        }

        private void txtValidation_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtValidation, 38, 9);
        }

        private void txtReset_TextChanged(object sender, EventArgs e)
        {
            string new_value = txtReset.Text;
            int fpos = 34;
            if (new_value.Length != 6)
            {
                // MessageBox.Show("RESET-nek 6 karakteresnek kell lennie!");
            }
            else
            {
                int linepos;
                StringBuilder newLine = new StringBuilder(fileContent[fpos]);
                for (int i = 0; i < 6; i++)
                {
                    linepos = 20 - (i * 2); // characters going backwards 
                    newLine[linepos] = new_value[i];    // just one character is updated!
                }

                if (fileContent[fpos] != newLine.ToString())
                {
                    UpdateChecksumOnLine(fpos, newLine.ToString());
                    fileContent[fpos] = newLine.ToString();
                    // Update the color in line view only when there were any change to original
                    for (int i = 0; i < 6; i++)
                    {
                        linepos = 20 - (i * 2); // characters going backwards 
                        rtbView.Select(rtbView.GetFirstCharIndexFromLine(fpos) + linepos, 1);
                        rtbView.SelectionColor = System.Drawing.Color.Red;
                        rtbView.SelectedText = new_value[i].ToString();
                    }
                }
            }
        }

        private void txtFirstFlat_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtFirstFlat, 37, 11);
        }

        private void txtLastFlat_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtLastFlat, 38, 11);
        }

        private void txtTalkBUSV_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtTalkBUSV, 35, 11, trkTalkBUSVoltage);
        }

        private void txtBaseBUSV_TextChanged(object sender, EventArgs e)
        {
            txtFieldUpdated(txtBaseBUSV, 36, 11, trkBaseBUSVoltage);
        }

        private void trkTalkBUSVoltage_Scroll(object sender, EventArgs e)
        {
            txtTalkBUSV.Text = trkTalkBUSVoltage.Value.ToString();
        }

        private void trkBaseBUSVoltage_Scroll(object sender, EventArgs e)
        {
            txtBaseBUSV.Text = trkBaseBUSVoltage.Value.ToString();
        }
        private void dgFlatCodes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFlatCodes.Columns[e.ColumnIndex].Name == "Code")
            {
                
                string new_value = dgFlatCodes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int n;
                if (new_value == "FFFF" || int.TryParse(new_value, out n) == true )
                {
                    if (new_value.Length != 4)
                    {
                        MessageBox.Show("Incorrect code length!\n\r\"" + new_value + "\" must be 4 character long.", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        decimal fileRow; // base
                        decimal fileColumn;
                        fileRow = Math.Floor(Convert.ToDecimal(e.RowIndex) / 8);
                        fileColumn = e.RowIndex - (Math.Floor(Convert.ToDecimal(e.RowIndex) / 8) * 8);
                        updateStringParametersInFileContent(Convert.ToInt16(fileRow) + 1, 9 + Convert.ToInt16(fileColumn) * 4, new_value);
                    }
                }
                else
                {
                    MessageBox.Show("\"" + new_value + "\" must be numeric value!!!", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnClearAllFlatcodes_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i< dgFlatCodes.Rows.Count; i++)
            {
                //dgFlatCodes.Rows
            }
            
        }

        private void btnSelectAllFlatCodes_Click(object sender, EventArgs e)
        {
            dgFlatCodes.SelectAll();
        }

        private void btnCopyFlatCodes_Click(object sender, EventArgs e)
        {
            //dgFlatCodes.SelectedRows.CopyTo();
        }

        private void btnPasteFlatCodes_Click(object sender, EventArgs e)
        {

        }

        private void btnDeselectFlatCodes_Click(object sender, EventArgs e)
        {
            dgFlatCodes.ClearSelection();
        }

        private void btnImportFlatCodes_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Hex file to import";
            dlg.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                importedFileContent = System.IO.File.ReadAllLines(dlg.FileName);
                int CurrentFileErrosNum = fileErrorsNum; // Dirty hack. need better solution
                fileErrorsNum = 0;
                validateFileContent(importedFileContent);
                if (fileErrorsNum == 0)
                {
                    // No errors in file, we can use it
                    UpdateFlatcodesFromFileArray(importedFileContent);
                } else
                {
                    AddMessage("Imported file contains "+fileErrorsNum.ToString()+" error(s). Cannot be imported.");
                }
                fileErrorsNum = CurrentFileErrosNum;
            }
        }
    }
}
