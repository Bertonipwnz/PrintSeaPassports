using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public class Class1: Control
    {
        
        private bool roundingEnable = false;
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }

        }
        private int roundingPercent = 100;
        public int Rounding
        {
            get => roundingPercent;
                set
            {
                if(value >= 00 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }

        }

        

        private StringFormat SF = new StringFormat();
        private bool  MouseEntered = false;
        private bool MousePressed = false;


        public Class1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 30);
            BackColor = Color.Tomato;
            ForeColor = Color.White;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);
           

            //krug
            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundingValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = krugh.RoundedRectangle(rect, roundingValue);

            //osnovnoi
            graph.DrawPath(new Pen(BackColor), rectPath);
            graph.FillPath(new SolidBrush(BackColor), rectPath);
           
           
            if(MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);

            }
            // при нажатии кнопки
             if (MousePressed)
            {
                 graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                  graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            
              }
               graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);


            
        }

       
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
           Invalidate();
        }
    }
}
