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
using Emgu.CV.Structure;

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

            if (!DarkMode.darkMode)
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }else
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.White;
            }

            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "The End!";
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label2.Text = e.ProgressPercentage.ToString();
        }
        private int i = 0;
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            SetButtonColor2();

            while (i < readText.Length)
            {
                    

                if (PauseBool)
                {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

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
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
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

            SetButtonColor();

            worker.ReportProgress(i);
            
            
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

        public int SpeedReading = 300;

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Up:

                    break;

                case Keys.Down:

                    break;
            }
        }
        public char[] word = new char[50];

      

        private void Reeding_Load(object sender, EventArgs e)
        {
           
        }
      
        private bool RunBool = true;
        private bool PauseBool = true;
        public bool AlredyRun = false;

        public void SetRunBool(bool atg)
        {
            RunBool = atg;
        }
        public void SetPauseBool(bool atg)
        {
            PauseBool = atg;
        }

        public void SetAlredyRunBool(bool arg)
        {
            AlredyRun = !arg;
        }
        //public Thread thread;

        private void Run_Click_1(object sender, EventArgs e)
        {
            SetButtonColor();
            worker.RunWorkerAsync();
            Run.Enabled = false;
            Refresh();
        }

        public void Pause_Click_1(object sender, EventArgs e)
        {
            SetPauseBool(!PauseBool);
        }

        public void SetButtonColor()
        {
            //MessageBox.Show("23");
            if (DarkMode.darkMode)
            {
                Stop.BackColor = Color.Gray;
                Pause.BackColor = Color.Gray;
                Run.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }
            else
            {
                Stop.BackColor = Color.Black;
                Pause.BackColor = Color.Black;
                Run.BackColor = Color.Black;
                button1.BackColor = Color.Black;
            }
        }
        private void SetButtonColor2()
        {
            if (DarkMode.darkMode)
            {
                Stop.BackColor = Color.Black;
                Pause.BackColor = Color.Black;
                Run.BackColor = Color.Black;
                button1.BackColor = Color.Black;
            }
            else
            {
                Stop.BackColor = Color.Gray;
                Pause.BackColor = Color.Gray;
                Run.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }
        }

        private void Stop_Click_1(object sender, EventArgs e)
        { 
            worker.CancelAsync();
            SetButtonColor();
            Run.Enabled = true;
            SetRunBool(false);
            SetAlredyRunBool(true);
            SetPauseBool(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            font.ShowDialog();
            label1.Font = font.Font;
        }

        private void Speed_Click(object sender, EventArgs e)
        {
            
           /* const string message =
        "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);*/
        }
    }
}
