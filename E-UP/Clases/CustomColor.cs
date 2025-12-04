using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_UP.Clases
{
    internal class CustomColor : ProfessionalColorTable
    {

        public override Color MenuStripGradientBegin => Color.FromArgb(42, 35, 54);    // Color base
        public override Color MenuStripGradientEnd => Color.FromArgb(42, 35, 54);      // Color base
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Indigo, new Rectangle(Point.Empty, e.Item.Size));
                e.Item.ForeColor = Color.FromArgb(217, 210, 208);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

    }
}
