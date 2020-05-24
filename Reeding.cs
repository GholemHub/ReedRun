using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ReedRun
{
    public partial class Reeding : Form
    {
        public string readText;
        public Reeding(string readText)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.readText = readText;
            //timer1.Interval = 40; 

            //timer1.Tick += new EventHandler(Update);

            

            this.KeyDown += new KeyEventHandler(OnPress);

         //   label1.Text = readText;
        }
        public int j = 0;
        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Space:

                    break;
             }
        }
        public char[] word = new char[50];

        public void Update(object sender, EventArgs e)
        {

           
        }

        private void Reeding_Load(object sender, EventArgs e)
        {
           
        }
        private bool RunBool = true;
        private void Run_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < readText.Length; i++)
            {
                if (!RunBool) return;
                if (readText[i] == ' ' || readText[i] == '\n' || readText[i] == ',' 
                    || readText[i] == ';' || readText[i] == '.'
                    || readText[i] == '-' || readText[i] == '(' || readText[i] == ')')
                {
                    string str = "";
                    for (int q = 0; q < j; q++)
                    {
                        str += word[q];
                    }
                    label1.Text = str;
                    Refresh();
                    Thread.Sleep(300);
                    j = 0;
                    word = null;
                    word = new char[50];
                }
                else
                {
                    word[j] = readText[i];
                    j++;
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            RunBool = false;
        }
    }
}
