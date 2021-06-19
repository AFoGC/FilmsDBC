using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Controls
{
	public partial class FilmControl : UserControl
	{
		public Film filmInfo = null;

		public FilmControl(Film film)
		{
			InitializeComponent();
			this.filmInfo = film;

			this.textBox_id.Text = filmInfo.ID.ToString();
			this.textBox_name.Text = filmInfo.name;
			this.textBox_genre.Text = filmInfo.genre;
			this.textBox_realiseYear.Text = FormatText.formatToText(filmInfo.realiseYear);
			this.checkBox_watched.Checked = filmInfo.watched;
			this.textBox_watchDate.Text = FormatText.formatToText(filmInfo.dateOfWatch);
			this.textBox_mark.Text = FormatText.formatToText(filmInfo.mark);
			this.textBox_countOfviews.Text = FormatText.formatToText(filmInfo.countOfviews);
		}
	}
}
