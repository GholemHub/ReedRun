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
        public FontDialog font = new FontDialog();
        public string readText;
        public Reeding(string readText)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.readText = GetRRText(readText);

            this.KeyDown += new KeyEventHandler(OnPress);

           
        }

        public string GetRRText(string readText)
        {
            string str = String.Empty;
            int i = 0;
            


            while (readText.Length > i)
            {
                if (readText[i] == '.' || readText[i] == ','
                    || readText[i] == ';' || readText[i] == '.'
                    || readText[i] == '-' || readText[i] == '(' || readText[i] == ')')
                {
                    i++;
                }
                
                if(i <= readText.Length)
                    str += readText[i];

                i++;
            }
            return str;
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

      

        private void Reeding_Load(object sender, EventArgs e)
        {
           
        }
        private bool RunBool = true;
        private bool PauseBool = true;

        public void SetRunBool(bool atg)
        {
            RunBool = atg;
        }
        public void SetPauseBool(bool atg)
        {
            PauseBool = atg;
        }

        public void StartRead()
        {
            int i = 0;

            while (i < readText.Length)
            {

                if (PauseBool)
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

                        //Thread.Sleep(300);

                        Action action = () =>
                        {
                            label1.Text = str;
                            Refresh();
                        };
                        if (InvokeRequired)
                            Invoke(action);
                        else
                            action();


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
                    i++;
                }
                
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartRead);

            thread.Start();

            Run.BackColor = Color.Black;
            Pause.BackColor = Color.Gray;
            Run.BackColor = Color.Gray;

            label1.Text = "The End!!!";
            Refresh();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            SetPauseBool(!PauseBool);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SetRunBool(false);
            label1.Text = "The End!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            font.ShowDialog();
            label1.Font = font.Font;
        }
    }
}
