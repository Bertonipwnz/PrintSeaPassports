using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class krugh
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X+rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y+rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y+rect.Height-RoundSize, RoundSize, RoundSize, 90, 90);
            gp.CloseFigure();

            return gp;
        }
    }
}
