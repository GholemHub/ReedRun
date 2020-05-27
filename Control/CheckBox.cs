using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace ReedRun
{
    public class MyCheckBox : Control
    {

        #region -- Переменные --
        Rectangle rect;
        int TogglePosX_ON;
        int TogglePosX_OFF;

        //Animation Toggle;

        #endregion

        #region -- Свойства --
        public bool Checked { get; set; } = false;
        public Color BackColorON { get; set; } = Color.Red;
        #endregion
        public MyCheckBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Cursor = Cursors.Hand;

            Size = new Size(40, 15);

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;
            rect = new Rectangle(1, 1, Width - 3, Height - 3);
            TogglePosX_ON = rect.Width - rect.Height;
            TogglePosX_OFF = rect.X;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Size = new Size(60, 35);
            rect = new Rectangle(1, 1, Width - 3, Height - 3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

           
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            Pen TSPen = new Pen(Color.FromArgb(29, 29, 29), 3);
            Pen TSPenToggle = new Pen(Color.FromArgb(29, 29, 29), 3);

            
            
            GraphicsPath rectGP = RoundedRectangle(rect, rect.Height);
            
            Rectangle rectToggle = new Rectangle(rect.X, rect.Y, rect.Height, rect.Height);

            g.DrawPath(TSPen, rectGP);
            
            if(Checked == true)
            {
                rectToggle.Location = new Point(TogglePosX_ON, rect.Y);
                g.FillPath(new SolidBrush(BackColorON), rectGP);
            }
            else
            {
                rectToggle.Location = new Point(TogglePosX_OFF, rect.Y);
                g.FillPath(new SolidBrush(BackColorON), rectGP);
            }

            

            g.DrawEllipse (TSPenToggle, rectToggle);
            g.FillEllipse (new SolidBrush(Color.White), rectToggle  );
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SwitchToggle();

        }

        private void SwitchToggle()
        {
            Checked = !Checked;
            Invalidate();
        }

        private GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();
            return gp;
            
        }
    }
            
}
