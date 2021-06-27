using FilmsDBC.CinemaDataTypes;
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
			flowLayoutPanel1.Controls.Clear();
			if (film.Genre == "м/с" || film.Genre == "сериал")
			{
				flowLayoutPanel1.Controls.Add(ControlsConverter.ToSerieControl(film));
			}
			else
			{
				flowLayoutPanel1.Controls.Add(ControlsConverter.ToFilmControl(film));
			}
		}
	}
}
