using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.StaticVisualClasses;
using FilmsDBC.Visual.UpdateElements;
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
	public partial class SerieControl : AElementControl
	{
		private Serie serieInfo = null;

		public Serie SerieInfo
		{
			get { return serieInfo; }
		}

		public SerieControl(Film film, Serie serie)
		{
			InitializeComponent();
			this.serieInfo = serie;
			this.filmInfo = film;

			RefreshData();
		}

		public override void RefreshData()
		{
			this.textBox_id.Text = filmInfo.ID.ToString();
			this.textBox_name.Text = filmInfo.Name;
			this.textBox_genre.Text = filmInfo.Genre.Name;
			this.textBox_realiseYear.Text = Film.formatToString(filmInfo.RealiseYear);
			this.checkBox_watched.Checked = filmInfo.Watched;
			this.textBox_watchDate.Text = Film.formatToString(filmInfo.DateOfWatch);
			this.textBox_mark.Text = VisualHelper.markToText(Film.formatToString(filmInfo.Mark));
			this.textBox_countOfviews.Text = Film.formatToString(filmInfo.CountOfViews);

			this.textBox_startWatchDate.Text = Serie.formatToString(serieInfo.StartWatchDate);
			this.textBox_countOfWatchedSeries.Text = Serie.formatToString(serieInfo.CountOfWatchedSeries);
			this.textBox_totalSeries.Text = Serie.formatToString(serieInfo.TotalSeries);
		}

		internal override void setVisualFinded()
		{
			this.BackColor = Color.Blue;
		}

		public override void SetDefaultVisualCondition()
		{
			this.BackColor = SystemColors.Control;
		}

		internal override void setVisualSelected()
		{
			this.BackColor = Color.Green;
		}

		private void label_update_Click(object sender, EventArgs e)
		{
			UpdateFormVisualizer.OpenUpdateForm(this);
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}
	}
}
