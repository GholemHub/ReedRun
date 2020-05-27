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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

      

        private void FileManager_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            //this.Close();
        }

        private void Reed_Click(object sender, EventArgs e)
        {
            Reed reed = new Reed();
            reed.ShowDialog();
        }

        private void myCheckBox1_Click(object sender, EventArgs e)
        {
            
            if (DarkMode.darkMode)
            {
                this.BackColor = Color.White;
                Refresh();
            }
            else 
            {
                this.BackColor = Color.Black;
                Refresh();
            }
            DarkMode.SetDarkMode(DarkMode.darkMode);

        }
    }
}
