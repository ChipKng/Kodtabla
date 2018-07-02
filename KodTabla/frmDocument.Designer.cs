namespace KodTabla
{
    partial class frmDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocument));
            this.rtbView = new System.Windows.Forms.RichTextBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnValidate = new System.Windows.Forms.ToolStripButton();
            this.btnFix = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBaseBUSV = new System.Windows.Forms.TextBox();
            this.trkBaseBUSVoltage = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTalkBUSV = new System.Windows.Forms.TextBox();
            this.trkTalkBUSVoltage = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastFlat = new System.Windows.Forms.TextBox();
            this.txtFirstFlat = new System.Windows.Forms.TextBox();
            this.txtButtonVol = new System.Windows.Forms.TextBox();
            this.txtDoorVol = new System.Windows.Forms.TextBox();
            this.txtRingVol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbButtonVol = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDoorVol = new System.Windows.Forms.TrackBar();
            this.tbRingVol = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValidation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTalkTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRingTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClosureTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dgFlatCodes = new System.Windows.Forms.DataGridView();
            this.Flat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProxyList = new System.Windows.Forms.DataGridView();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlatTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearAllFlatcodes = new System.Windows.Forms.Button();
            this.btnCopyFlatCodes = new System.Windows.Forms.Button();
            this.btnPasteFlatCodes = new System.Windows.Forms.Button();
            this.btnSelectAllFlatCodes = new System.Windows.Forms.Button();
            this.btnDeselectFlatCodes = new System.Windows.Forms.Button();
            this.btnImportFlatCodes = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBaseBUSVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTalkBUSVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbButtonVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDoorVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRingVol)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlatCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProxyList)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbView
            // 
            this.rtbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbView.Location = new System.Drawing.Point(3, 241);
            this.rtbView.Name = "rtbView";
            this.rtbView.Size = new System.Drawing.Size(341, 346);
            this.rtbView.TabIndex = 1;
            this.rtbView.Text = "";
            // 
            // txtMessages
            // 
            this.txtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessages.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(3, 593);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(1247, 128);
            this.txtMessages.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnValidate,
            this.btnFix,
            this.btnSave,
            this.btnSaveAs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnValidate
            // 
            this.btnValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnValidate.Image = ((System.Drawing.Image)(resources.GetObject("btnValidate.Image")));
            this.btnValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(23, 22);
            this.btnValidate.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnFix
            // 
            this.btnFix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFix.Image = ((System.Drawing.Image)(resources.GetObject("btnFix.Image")));
            this.btnFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(23, 22);
            this.btnFix.Text = "Fix problems";
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBaseBUSV);
            this.panel1.Controls.Add(this.trkBaseBUSVoltage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtTalkBUSV);
            this.panel1.Controls.Add(this.trkTalkBUSVoltage);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtLastFlat);
            this.panel1.Controls.Add(this.txtFirstFlat);
            this.panel1.Controls.Add(this.txtButtonVol);
            this.panel1.Controls.Add(this.txtDoorVol);
            this.panel1.Controls.Add(this.txtRingVol);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbButtonVol);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbDoorVol);
            this.panel1.Controls.Add(this.tbRingVol);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtValidation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTalkTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRingTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClosureTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtReset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 194);
            this.panel1.TabIndex = 4;
            // 
            // txtBaseBUSV
            // 
            this.txtBaseBUSV.AccessibleName = "Base BUS voltage";
            this.txtBaseBUSV.Location = new System.Drawing.Point(1014, 152);
            this.txtBaseBUSV.Name = "txtBaseBUSV";
            this.txtBaseBUSV.Size = new System.Drawing.Size(65, 20);
            this.txtBaseBUSV.TabIndex = 29;
            this.txtBaseBUSV.TextChanged += new System.EventHandler(this.txtBaseBUSV_TextChanged);
            // 
            // trkBaseBUSVoltage
            // 
            this.trkBaseBUSVoltage.Location = new System.Drawing.Point(596, 142);
            this.trkBaseBUSVoltage.Maximum = 255;
            this.trkBaseBUSVoltage.Name = "trkBaseBUSVoltage";
            this.trkBaseBUSVoltage.Size = new System.Drawing.Size(411, 45);
            this.trkBaseBUSVoltage.TabIndex = 28;
            this.trkBaseBUSVoltage.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkBaseBUSVoltage.Scroll += new System.EventHandler(this.trkBaseBUSVoltage_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(596, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Alap BUS feszultseg:";
            // 
            // txtTalkBUSV
            // 
            this.txtTalkBUSV.AccessibleName = "Talk BUS voltage";
            this.txtTalkBUSV.Location = new System.Drawing.Point(1014, 89);
            this.txtTalkBUSV.Name = "txtTalkBUSV";
            this.txtTalkBUSV.Size = new System.Drawing.Size(65, 20);
            this.txtTalkBUSV.TabIndex = 26;
            this.txtTalkBUSV.TextChanged += new System.EventHandler(this.txtTalkBUSV_TextChanged);
            // 
            // trkTalkBUSVoltage
            // 
            this.trkTalkBUSVoltage.AccessibleName = "Talk BUS voltage";
            this.trkTalkBUSVoltage.Location = new System.Drawing.Point(596, 81);
            this.trkTalkBUSVoltage.Maximum = 255;
            this.trkTalkBUSVoltage.Name = "trkTalkBUSVoltage";
            this.trkTalkBUSVoltage.Size = new System.Drawing.Size(411, 45);
            this.trkTalkBUSVoltage.TabIndex = 25;
            this.trkTalkBUSVoltage.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkTalkBUSVoltage.Scroll += new System.EventHandler(this.trkTalkBUSVoltage_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(596, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Beszed BUS feszultseg:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Utolso lakas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Elso lakas:";
            // 
            // txtLastFlat
            // 
            this.txtLastFlat.AccessibleName = "Last flat";
            this.txtLastFlat.Location = new System.Drawing.Point(660, 38);
            this.txtLastFlat.Name = "txtLastFlat";
            this.txtLastFlat.Size = new System.Drawing.Size(68, 20);
            this.txtLastFlat.TabIndex = 21;
            this.txtLastFlat.TextChanged += new System.EventHandler(this.txtLastFlat_TextChanged);
            // 
            // txtFirstFlat
            // 
            this.txtFirstFlat.AccessibleName = "First Flat";
            this.txtFirstFlat.Location = new System.Drawing.Point(596, 38);
            this.txtFirstFlat.Name = "txtFirstFlat";
            this.txtFirstFlat.Size = new System.Drawing.Size(58, 20);
            this.txtFirstFlat.TabIndex = 20;
            this.txtFirstFlat.TextChanged += new System.EventHandler(this.txtFirstFlat_TextChanged);
            // 
            // txtButtonVol
            // 
            this.txtButtonVol.AccessibleName = "Button volume";
            this.txtButtonVol.Location = new System.Drawing.Point(536, 153);
            this.txtButtonVol.Name = "txtButtonVol";
            this.txtButtonVol.Size = new System.Drawing.Size(47, 20);
            this.txtButtonVol.TabIndex = 19;
            this.txtButtonVol.TextChanged += new System.EventHandler(this.txtButtonVol_TextChanged);
            // 
            // txtDoorVol
            // 
            this.txtDoorVol.AccessibleName = "Door volume";
            this.txtDoorVol.Location = new System.Drawing.Point(536, 116);
            this.txtDoorVol.Name = "txtDoorVol";
            this.txtDoorVol.Size = new System.Drawing.Size(47, 20);
            this.txtDoorVol.TabIndex = 18;
            this.txtDoorVol.TextChanged += new System.EventHandler(this.txtDoorVol_TextChanged);
            // 
            // txtRingVol
            // 
            this.txtRingVol.AccessibleName = "Ring volume";
            this.txtRingVol.Location = new System.Drawing.Point(536, 75);
            this.txtRingVol.Name = "txtRingVol";
            this.txtRingVol.Size = new System.Drawing.Size(47, 20);
            this.txtRingVol.TabIndex = 17;
            this.txtRingVol.TextChanged += new System.EventHandler(this.txtRingVol_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Billentyu hang:";
            // 
            // tbButtonVol
            // 
            this.tbButtonVol.Location = new System.Drawing.Point(99, 142);
            this.tbButtonVol.Maximum = 255;
            this.tbButtonVol.Name = "tbButtonVol";
            this.tbButtonVol.Size = new System.Drawing.Size(436, 45);
            this.tbButtonVol.TabIndex = 15;
            this.tbButtonVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbButtonVol.Scroll += new System.EventHandler(this.tbButtonVol_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ajtonyitasi hang:";
            // 
            // tbDoorVol
            // 
            this.tbDoorVol.Location = new System.Drawing.Point(99, 102);
            this.tbDoorVol.Maximum = 255;
            this.tbDoorVol.Name = "tbDoorVol";
            this.tbDoorVol.Size = new System.Drawing.Size(436, 45);
            this.tbDoorVol.TabIndex = 13;
            this.tbDoorVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDoorVol.Scroll += new System.EventHandler(this.tbDoorVol_Scroll);
            // 
            // tbRingVol
            // 
            this.tbRingVol.Location = new System.Drawing.Point(99, 65);
            this.tbRingVol.Maximum = 255;
            this.tbRingVol.Name = "tbRingVol";
            this.tbRingVol.Size = new System.Drawing.Size(436, 45);
            this.tbRingVol.TabIndex = 12;
            this.tbRingVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRingVol.Scroll += new System.EventHandler(this.tbRingVol_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Csengetesi hang:";
            // 
            // txtValidation
            // 
            this.txtValidation.AccessibleName = "Validation";
            this.txtValidation.Location = new System.Drawing.Point(435, 38);
            this.txtValidation.Name = "txtValidation";
            this.txtValidation.Size = new System.Drawing.Size(100, 20);
            this.txtValidation.TabIndex = 10;
            this.txtValidation.TextChanged += new System.EventHandler(this.txtValidation_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ellenorzes:";
            // 
            // txtTalkTime
            // 
            this.txtTalkTime.AccessibleName = "Talk time";
            this.txtTalkTime.Location = new System.Drawing.Point(328, 38);
            this.txtTalkTime.Name = "txtTalkTime";
            this.txtTalkTime.Size = new System.Drawing.Size(100, 20);
            this.txtTalkTime.TabIndex = 8;
            this.txtTalkTime.TextChanged += new System.EventHandler(this.txtTalkTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Beszelgetesi ido (s):";
            // 
            // txtRingTime
            // 
            this.txtRingTime.AccessibleName = "Ring time";
            this.txtRingTime.Location = new System.Drawing.Point(221, 38);
            this.txtRingTime.Name = "txtRingTime";
            this.txtRingTime.Size = new System.Drawing.Size(100, 20);
            this.txtRingTime.TabIndex = 6;
            this.txtRingTime.TextChanged += new System.EventHandler(this.txtRingTime_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Csengetesi ido (sec):";
            // 
            // txtClosureTime
            // 
            this.txtClosureTime.AccessibleName = "Closure time";
            this.txtClosureTime.Location = new System.Drawing.Point(114, 38);
            this.txtClosureTime.Name = "txtClosureTime";
            this.txtClosureTime.Size = new System.Drawing.Size(100, 20);
            this.txtClosureTime.TabIndex = 4;
            this.txtClosureTime.TextChanged += new System.EventHandler(this.txtClosureTime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zarido (sec):";
            // 
            // txtReset
            // 
            this.txtReset.AccessibleName = "RESET";
            this.txtReset.Location = new System.Drawing.Point(7, 38);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(100, 20);
            this.txtReset.TabIndex = 2;
            this.txtReset.TextChanged += new System.EventHandler(this.txtReset_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "RESET:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "General parameters";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Validate";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Fix problems";
            this.toolStripButton2.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save";
            this.toolStripButton3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Save as";
            this.toolStripButton4.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // dgFlatCodes
            // 
            this.dgFlatCodes.AllowUserToAddRows = false;
            this.dgFlatCodes.AllowUserToDeleteRows = false;
            this.dgFlatCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgFlatCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlatCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flat,
            this.Code,
            this.ProxySum});
            this.dgFlatCodes.Location = new System.Drawing.Point(353, 270);
            this.dgFlatCodes.Name = "dgFlatCodes";
            this.dgFlatCodes.Size = new System.Drawing.Size(368, 317);
            this.dgFlatCodes.TabIndex = 7;
            this.dgFlatCodes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFlatCodes_CellEndEdit);
            // 
            // Flat
            // 
            this.Flat.Frozen = true;
            this.Flat.HeaderText = "Lakas";
            this.Flat.Name = "Flat";
            this.Flat.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Kod";
            this.Code.Name = "Code";
            // 
            // ProxySum
            // 
            this.ProxySum.HeaderText = "Proxy";
            this.ProxySum.Name = "ProxySum";
            this.ProxySum.ReadOnly = true;
            // 
            // dgProxyList
            // 
            this.dgProxyList.AllowUserToAddRows = false;
            this.dgProxyList.AllowUserToDeleteRows = false;
            this.dgProxyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgProxyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProxyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proxy,
            this.FlatTo,
            this.ProxyCode});
            this.dgProxyList.Location = new System.Drawing.Point(727, 270);
            this.dgProxyList.Name = "dgProxyList";
            this.dgProxyList.Size = new System.Drawing.Size(370, 317);
            this.dgProxyList.TabIndex = 8;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.Name = "Proxy";
            this.Proxy.ReadOnly = true;
            // 
            // FlatTo
            // 
            this.FlatTo.HeaderText = "Flat";
            this.FlatTo.Name = "FlatTo";
            // 
            // ProxyCode
            // 
            this.ProxyCode.HeaderText = "Code";
            this.ProxyCode.Name = "ProxyCode";
            // 
            // btnClearAllFlatcodes
            // 
            this.btnClearAllFlatcodes.Location = new System.Drawing.Point(351, 241);
            this.btnClearAllFlatcodes.Name = "btnClearAllFlatcodes";
            this.btnClearAllFlatcodes.Size = new System.Drawing.Size(54, 23);
            this.btnClearAllFlatcodes.TabIndex = 9;
            this.btnClearAllFlatcodes.Text = "Clear All";
            this.btnClearAllFlatcodes.UseVisualStyleBackColor = true;
            this.btnClearAllFlatcodes.Click += new System.EventHandler(this.btnClearAllFlatcodes_Click);
            // 
            // btnCopyFlatCodes
            // 
            this.btnCopyFlatCodes.Location = new System.Drawing.Point(545, 241);
            this.btnCopyFlatCodes.Name = "btnCopyFlatCodes";
            this.btnCopyFlatCodes.Size = new System.Drawing.Size(42, 23);
            this.btnCopyFlatCodes.TabIndex = 10;
            this.btnCopyFlatCodes.Text = "Copy";
            this.btnCopyFlatCodes.UseVisualStyleBackColor = true;
            this.btnCopyFlatCodes.Click += new System.EventHandler(this.btnCopyFlatCodes_Click);
            // 
            // btnPasteFlatCodes
            // 
            this.btnPasteFlatCodes.Location = new System.Drawing.Point(593, 241);
            this.btnPasteFlatCodes.Name = "btnPasteFlatCodes";
            this.btnPasteFlatCodes.Size = new System.Drawing.Size(51, 23);
            this.btnPasteFlatCodes.TabIndex = 11;
            this.btnPasteFlatCodes.Text = "Paste";
            this.btnPasteFlatCodes.UseVisualStyleBackColor = true;
            this.btnPasteFlatCodes.Click += new System.EventHandler(this.btnPasteFlatCodes_Click);
            // 
            // btnSelectAllFlatCodes
            // 
            this.btnSelectAllFlatCodes.Location = new System.Drawing.Point(411, 241);
            this.btnSelectAllFlatCodes.Name = "btnSelectAllFlatCodes";
            this.btnSelectAllFlatCodes.Size = new System.Drawing.Size(61, 23);
            this.btnSelectAllFlatCodes.TabIndex = 15;
            this.btnSelectAllFlatCodes.Text = "Select All";
            this.btnSelectAllFlatCodes.UseVisualStyleBackColor = true;
            this.btnSelectAllFlatCodes.Click += new System.EventHandler(this.btnSelectAllFlatCodes_Click);
            // 
            // btnDeselectFlatCodes
            // 
            this.btnDeselectFlatCodes.Location = new System.Drawing.Point(478, 241);
            this.btnDeselectFlatCodes.Name = "btnDeselectFlatCodes";
            this.btnDeselectFlatCodes.Size = new System.Drawing.Size(61, 23);
            this.btnDeselectFlatCodes.TabIndex = 16;
            this.btnDeselectFlatCodes.Text = "Deselect";
            this.btnDeselectFlatCodes.UseVisualStyleBackColor = true;
            this.btnDeselectFlatCodes.Click += new System.EventHandler(this.btnDeselectFlatCodes_Click);
            // 
            // btnImportFlatCodes
            // 
            this.btnImportFlatCodes.Location = new System.Drawing.Point(651, 241);
            this.btnImportFlatCodes.Name = "btnImportFlatCodes";
            this.btnImportFlatCodes.Size = new System.Drawing.Size(71, 23);
            this.btnImportFlatCodes.TabIndex = 17;
            this.btnImportFlatCodes.Text = "Import";
            this.btnImportFlatCodes.UseVisualStyleBackColor = true;
            this.btnImportFlatCodes.Click += new System.EventHandler(this.btnImportFlatCodes_Click);
            // 
            // frmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1252, 719);
            this.Controls.Add(this.btnImportFlatCodes);
            this.Controls.Add(this.btnDeselectFlatCodes);
            this.Controls.Add(this.btnSelectAllFlatCodes);
            this.Controls.Add(this.btnPasteFlatCodes);
            this.Controls.Add(this.btnCopyFlatCodes);
            this.Controls.Add(this.btnClearAllFlatcodes);
            this.Controls.Add(this.dgProxyList);
            this.Controls.Add(this.dgFlatCodes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.rtbView);
            this.Name = "frmDocument";
            this.Text = "New Document";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocument_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBaseBUSVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTalkBUSVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbButtonVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDoorVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRingVol)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlatCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProxyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbView;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnValidate;
        private System.Windows.Forms.ToolStripButton btnFix;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgFlatCodes;
        private System.Windows.Forms.TextBox txtValidation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTalkTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClosureTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbDoorVol;
        private System.Windows.Forms.TrackBar tbRingVol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtButtonVol;
        private System.Windows.Forms.TextBox txtDoorVol;
        private System.Windows.Forms.TextBox txtRingVol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbButtonVol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastFlat;
        private System.Windows.Forms.TextBox txtFirstFlat;
        private System.Windows.Forms.TextBox txtBaseBUSV;
        private System.Windows.Forms.TrackBar trkBaseBUSVoltage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTalkBUSV;
        private System.Windows.Forms.TrackBar trkTalkBUSVoltage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgProxyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyCode;
        private System.Windows.Forms.Button btnClearAllFlatcodes;
        private System.Windows.Forms.Button btnCopyFlatCodes;
        private System.Windows.Forms.Button btnPasteFlatCodes;
        private System.Windows.Forms.Button btnSelectAllFlatCodes;
        private System.Windows.Forms.Button btnDeselectFlatCodes;
        private System.Windows.Forms.Button btnImportFlatCodes;
    }
}