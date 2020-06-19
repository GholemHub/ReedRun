using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReedRun
{
    public partial class SpeedForm : Form
    {
        public SpeedForm()
        {
            InitializeComponent();
            ShowValue();
        }

       public void ShowValue()
        {
            label1.Text = trackBar1.Value.ToString();
            Refresh();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            //trackBar1.Value.ToString();
        }
    }
}
