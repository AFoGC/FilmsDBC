using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls
{
    public partial class SerieUpdateControl : UserControl, IUpdateControl
	{
		private AElementControl control = null;
		private Serie serie = null;

		public SerieUpdateControl(SerieControl serieControl)
		{
			InitializeComponent();
			this.control = serieControl;

			this.serie = serieControl.SerieInfo;


			comboBox_genre.Items.AddRange(MainInfo.Tables.GenresTable.ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());

			label_comment.SetDefaultButtonBlink();
			label_sources.SetDefaultButtonBlink();

			refresh();
		}

		public SerieUpdateControl(FilmControl filmControl)
		{
			InitializeComponent();
			this.control = filmControl;

			Film film = filmControl.FilmInfo;

			foreach (Serie serie in MainInfo.Tables.SeriesTable)
			{
				if (serie.FilmId == film.ID)
				{
					this.serie = serie;
					goto cont;
				}
			}

			Serie ser = new Serie();
			ser.Film = film;

			MainInfo.Tables.SeriesTable.AddElement(ser);

			cont:
			comboBox_genre.Items.AddRange(MainInfo.Tables.GenresTable.ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());

			refresh();
		}

		private void refresh()
		{
			Film defFilm = MainInfo.Tables.FilmsTable.DefaultCell;

			this.textBox_id.Text = serie.Film.ID.ToString();
			this.textBox_name.Text = serie.Film.Name;
			this.comboBox_genre.SelectedItem = serie.Film.Genre;
			this.textBox_realiseYear.Text = Film.FormatToString(serie.Film.RealiseYear, defFilm.RealiseYear);
			this.checkBox_watched.Checked = serie.Film.Watched;
			this.dateUpdateControl_watchDate.Date = serie.Film.DateOfWatch;
			this.comboBox_mark.Text = VisualHelper.markToText(Film.FormatToString(serie.Film.Mark, defFilm.Mark));
			this.textBox_countOfviews.Text = Film.FormatToString(serie.Film.CountOfViews, defFilm.CountOfViews);
			this.textBox_comment.Text = serie.Film.Comment;

			Serie defSerie = MainInfo.Tables.SeriesTable.DefaultCell;

			this.dateUpdateControl_startWatchDate.Date = serie.StartWatchDate;
			this.textBox_countOfWatchedSeries.Text = Serie.FormatToString(serie.CountOfWatchedSeries, defSerie.CountOfWatchedSeries);
			this.textBox_totalSeries.Text = Serie.FormatToString(serie.TotalSeries, defSerie.TotalSeries);
		}

		public void UpdateElement()
		{
			serie.Film.Name = this.textBox_name.Text;
			serie.Film.Genre = (Genre)comboBox_genre.SelectedItem;
			serie.Film.RealiseYear = VisualHelper.TextToInt32(this.textBox_realiseYear.Text);
			serie.Film.Watched = this.checkBox_watched.Checked;
			serie.Film.DateOfWatch = this.dateUpdateControl_watchDate.Date;
			serie.Film.Mark = VisualHelper.TextToMark(this.comboBox_mark.Text);
			serie.Film.CountOfViews = VisualHelper.TextToInt32(this.textBox_countOfviews.Text);
			serie.Film.Comment = this.textBox_comment.Text;

			serie.StartWatchDate = this.dateUpdateControl_startWatchDate.Date;
			serie.CountOfWatchedSeries = VisualHelper.TextToInt32(this.textBox_countOfWatchedSeries.Text);
			serie.TotalSeries = VisualHelper.TextToInt32(this.textBox_totalSeries.Text);

			control.RefreshData();
		}

		private void label_sources_Click(object sender, EventArgs e)
		{
			MainInfo.MainForm.MainControl.UpdateVisualizer.SourcesVisualizer.OpenSourceControl(this.serie.Film.Sources);
		}

		private bool commentIsOpen = false;
		private void label_comment_Click(object sender, EventArgs e)
        {
			Size controlSize = this.Size;

			if (commentIsOpen) { controlSize.Height -= 20; }
			else { controlSize.Height += 20; }

			this.Size = controlSize;
			commentIsOpen = !commentIsOpen;
		}

        private void checkBox_watched_Click(object sender, EventArgs e)
        {
            if (dateUpdateControl_watchDate.IsEmpty)
            {
				dateUpdateControl_watchDate.Date = DateTime.Today;
            }


			int cows = 0;
			int ts = 0;
			bool emptyTotal = true;

            if (textBox_countOfWatchedSeries.Text != "")
            {
				cows = Convert.ToInt32(textBox_countOfWatchedSeries.Text);
			}

            if (textBox_totalSeries.Text != "")
            {
				ts = Convert.ToInt32(textBox_totalSeries.Text);
				emptyTotal = false;
			}

			if (cows < ts && emptyTotal == false)
            {
				textBox_countOfWatchedSeries.Text = textBox_totalSeries.Text;
			}


            if (textBox_countOfviews.Text == "")
            {
				textBox_countOfviews.Text = "1";
            }
        }
    }
}
