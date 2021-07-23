using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual
{
    public static class ButtonStaticClass
    {
		public static void label_MouseDown(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			Color color = label.BackColor;

			label.BackColor = Color.FromArgb(
				color.A,
				color.R + 20,
				color.G + 20,
				color.B + 20
				);

			//int r = color.R + 20;
			//int g = color.G + 20;
			//int b = color.B + 20;
			//label.BackColor;
		}
		public static void label_MouseUp(object sender, EventArgs e)
		{
			
		}

		public static void label_MouseEnter(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			Color color = label.BackColor;

			int r, g, b;

			
			r = color.R - 20 < 0 ? 0 : color.R - 20;
			g = color.G - 20 < 0 ? 0 : color.G - 20;
			b = color.B - 20 < 0 ? 0 : color.B - 20;
			

			label.BackColor = Color.FromArgb(color.A, r, g, b);
		}
		public static void label_MouseLeave(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			Color color = label.BackColor;

			label.BackColor = Color.FromArgb(
				color.A,
				color.R + 20,
				color.G + 20,
				color.B + 20
				);
		}
	}
}
