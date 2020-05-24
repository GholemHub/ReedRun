using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace ReedRun
{
    public partial class Reed : Form
    {
        public Reed()
        {
            InitializeComponent();
        }
        private string filePath = string.Empty;
        public string readText;
        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                readText = File.ReadAllText(filePath);
                
                richTextBox1.Text = readText;
            }
            else
            {
                MessageBox.Show("No Selected Image!", "Coose Image!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GoReed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reeding reeding = new Reeding(readText);
            reeding.ShowDialog();
        }
    }
}
