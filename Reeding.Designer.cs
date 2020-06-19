namespace ReedRun
{
    partial class Reeding
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Run = new ReedRun.UserButton();
            this.Pause = new ReedRun.UserButton();
            this.Stop = new ReedRun.UserButton();
            this.button1 = new ReedRun.UserButton();
            this.Speed = new ReedRun.UserButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(202, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(202, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Run, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Pause, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Stop, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Speed, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.Gray;
            this.Run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Run.ForeColor = System.Drawing.Color.White;
            this.Run.Location = new System.Drawing.Point(3, 3);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(194, 116);
            this.Run.TabIndex = 5;
            this.Run.Text = "Reed";
            this.Run.Click += new System.EventHandler(this.Run_Click_1);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Gray;
            this.Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(3, 125);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(194, 116);
            this.Pause.TabIndex = 6;
            this.Pause.Text = "Pouse";
            this.Pause.Click += new System.EventHandler(this.Pause_Click_1);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Gray;
            this.Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(3, 247);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(194, 116);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 116);
            this.button1.TabIndex = 8;
            this.button1.Text = "Style";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.Color.Gray;
            this.Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Speed.ForeColor = System.Drawing.Color.White;
            this.Speed.Location = new System.Drawing.Point(403, 125);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(194, 116);
            this.Speed.TabIndex = 9;
            this.Speed.Text = "Speed";
            this.Speed.Click += new System.EventHandler(this.Speed_Click);
            // 
            // Reeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reeding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reeding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reeding_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserButton Run;
        private UserButton Pause;
        private UserButton Stop;
        private UserButton button1;
        private UserButton Speed;
    }
}