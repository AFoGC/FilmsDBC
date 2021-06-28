using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MoreInfo
{
	public partial class MoreInfoForm : Form
	{
		public MoreInfoForm()
		{
			InitializeComponent();
		}

		public void Reinitialize(Film film)
		{
			flowLayoutPanel_main.Controls.Clear();
			if (GenreMethods.IsSerialGenre(film.Genre))
			{
				flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
			}
			else
			{
				flowLayoutPanel_main.Controls.Add(ControlsConverter.ToFilmControl(film));
			}
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}


		private Point lastPoint;
		private void panel_main_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void panel_main_MouseMove(object sender, MouseEventArgs e)
		{
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
	}
}
