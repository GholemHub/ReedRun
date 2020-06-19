namespace ReedRun
{
    partial class SpeedForm
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Ok = new ReedRun.UserButton();
            this.Сancel = new ReedRun.UserButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Location = new System.Drawing.Point(12, 49);
            this.trackBar1.Maximum = 600;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(391, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 300;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Gray;
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(12, 237);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 30);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Сancel
            // 
            this.Сancel.BackColor = System.Drawing.Color.Gray;
            this.Сancel.ForeColor = System.Drawing.Color.White;
            this.Сancel.Location = new System.Drawing.Point(303, 237);
            this.Сancel.Name = "Сancel";
            this.Сancel.Size = new System.Drawing.Size(100, 30);
            this.Сancel.TabIndex = 6;
            this.Сancel.Text = "Сancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // SpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(416, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Сancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpeedForm";
            this.Text = "SpeedForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private UserButton Сancel;
        private UserButton Ok;
    }
}