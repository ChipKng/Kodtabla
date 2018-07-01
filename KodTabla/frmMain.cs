using System;
using System.Windows.Forms;

namespace KodTabla
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Hex file to read";
            dlg.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            if ( dlg.ShowDialog() == DialogResult.OK )
            {
                frmDocument doc = new frmDocument();
                doc.MdiParent = this;
                doc.fileName = dlg.FileName;
                presentDocument(doc);
            }
        }

        private static void presentDocument(frmDocument doc)
        {
            doc.Show();
            doc.Focus();
            doc.WindowState = FormWindowState.Normal;
            doc.WindowState = FormWindowState.Maximized;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocument doc = new frmDocument();
            doc.MdiParent = this;
            presentDocument(doc);
        }

        private void tSBNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void tSBOpenFile_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

    }
}
