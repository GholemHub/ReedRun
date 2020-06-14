namespace ReedRun
{
    partial class MainMenu
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TectChoose = new ReedRun.UserButton();
            this.RecognizeText = new ReedRun.UserButton();
            this.Exit = new ReedRun.UserButton();
            this.myCheckBox1 = new ReedRun.MyCheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TectChoose
            // 
            this.TectChoose.BackColor = System.Drawing.Color.Gray;
            this.TectChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TectChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TectChoose.ForeColor = System.Drawing.Color.White;
            this.TectChoose.Location = new System.Drawing.Point(254, 94);
            this.TectChoose.Name = "TectChoose";
            this.TectChoose.Size = new System.Drawing.Size(245, 85);
            this.TectChoose.TabIndex = 0;
            this.TectChoose.Text = "Text Choose";
            this.TectChoose.Click += new System.EventHandler(this.TectChoose_Click);
            // 
            // RecognizeText
            // 
            this.RecognizeText.BackColor = System.Drawing.Color.Gray;
            this.RecognizeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecognizeText.ForeColor = System.Drawing.Color.White;
            this.RecognizeText.Location = new System.Drawing.Point(254, 185);
            this.RecognizeText.Name = "RecognizeText";
            this.RecognizeText.Size = new System.Drawing.Size(245, 85);
            this.RecognizeText.TabIndex = 1;
            this.RecognizeText.Text = "Recognize Text";
            this.RecognizeText.Click += new System.EventHandler(this.RecognizeText_Click_1);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gray;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(254, 276);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(245, 85);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click_2);
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.BackColor = System.Drawing.Color.White;
            this.myCheckBox1.BackColorON = System.Drawing.Color.Red;
            this.myCheckBox1.Checked = false;
            this.myCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCheckBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.myCheckBox1.Location = new System.Drawing.Point(505, 367);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.Size = new System.Drawing.Size(60, 35);
            this.myCheckBox1.TabIndex = 3;
            this.myCheckBox1.Text = "myCheckBox1";
            this.myCheckBox1.Click += new System.EventHandler(this.myCheckBox1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.myCheckBox1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TectChoose, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RecognizeText, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 456);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private UserButton TectChoose;
        private UserButton RecognizeText;
        private UserButton Exit;
        private MyCheckBox myCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}