using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls
{
    public partial class SerieControl : AElementControl
	{
		public SimpleControl simpleControl = null;

		private Serie serieInfo = null;

		public Serie SerieInfo
		{
			get { return serieInfo; }
		}

		public SerieControl(Film film, Serie serie)
		{
			initialise();
			this.serieInfo = serie;
			this.filmInfo = film;

			RefreshData();
		}

		public SerieControl(Film film)
        {
			initialise();
			this.filmInfo = film;
			this.serieInfo = findSerie();

			RefreshData();
		}

		public SerieControl(Serie serie)
        {
			initialise();
			this.filmInfo = serie.Film;
			this.serieInfo = serie;

			RefreshData();
        }

		public SerieControl(SimpleControl simpleControl)
        {
			initialise();
			this.filmInfo = simpleControl.filmInfo;
			this.serieInfo = findSerie();
			this.simpleControl = simpleControl;

			RefreshData();
		}

		private Serie findSerie()
        {
			foreach (Serie serie in MainInfo.Tables.SeriesTable)
			{
				if (serie.FilmId == filmInfo.ID)
				{
					return serie;
				}
			}

			Serie ser = new Serie();
			ser.Film = filmInfo;

			return ser;
        }

		private void initialise()
        {
			InitializeComponent();

			this.label_comment.SetDefaultButtonBlink();
			this.label_copyUrl.SetDefaultButtonBlink();
			this.label_update.SetDefaultButtonBlink();
		}

		public override void RefreshData()
		{
			Film defFilm = MainInfo.Tables.FilmsTable.DefaultCell;

			this.textBox_id.Text = filmInfo.ID.ToString();
			this.textBox_name.Text = filmInfo.Name;
			this.textBox_genre.Text = filmInfo.Genre.Name;
			this.textBox_realiseYear.Text = Film.FormatToString(filmInfo.RealiseYear, defFilm.RealiseYear);
			this.checkBox_watched.Checked = filmInfo.Watched;
			this.textBox_watchDate.Text = Film.FormatToString(filmInfo.DateOfWatch, defFilm.DateOfWatch);
			this.textBox_mark.Text = VisualHelper.markToText(Film.FormatToString(filmInfo.Mark, defFilm.Mark));
			this.textBox_countOfviews.Text = Film.FormatToString(filmInfo.CountOfViews, defFilm.CountOfViews);

			Serie defSerie = MainInfo.Tables.SeriesTable.DefaultCell;

			this.textBox_startWatchDate.Text = Serie.FormatToString(serieInfo.StartWatchDate, defSerie.StartWatchDate);
			this.textBox_countOfWatchedSeries.Text = Serie.FormatToString(serieInfo.CountOfWatchedSeries, defSerie.CountOfWatchedSeries);
			this.textBox_totalSeries.Text = Serie.FormatToString(serieInfo.TotalSeries, defSerie.TotalSeries);
			this.refreshSourceLabel();

			if (simpleControl != null)
			{
				simpleControl.RefreshData();
			}
		}

		public void refreshSourceLabel()
		{
			if (filmInfo.Sources.Count == 0)
			{
				label_copyUrl.Text = "no url";
			}
			else
			{
				if (filmInfo.Sources[0].name != "")
				{
					label_copyUrl.Text = "url: " + filmInfo.Sources[0].name;
				}
				else
				{
					label_copyUrl.Text = "copy url";
				}
			}
		}

		internal override void setVisualFinded()
		{
			Color color = Color.FromArgb(0, 0, 220);
			this.textBox_id.BackColor = color;
		}

		public override void SetVisualDefault()
		{
			Color color = Color.FromArgb(53, 53, 53);
			this.textBox_id.BackColor = color;
		}

		internal override void setVisualSelected()
		{
			Color color = Color.FromArgb(0, 220, 0);
			this.textBox_id.BackColor = color;
		}

		private void label_update_Click(object sender, EventArgs e)
		{
			MainInfo.MainForm.MainControl.UpdateVisualizer.OpenUpdateControl(this, MainInfo.MainForm.MainControl.MoreInfoVisualizer);
		}

		private void label_copyUrl_Click(object sender, EventArgs e)
		{
			if (filmInfo.Sources.Count != 0)
			{
				Clipboard.SetText(filmInfo.Sources[0].sourceUrl);
			}
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}

		private void textBox_id_Click(object sender, EventArgs e)
		{
			SetSelectedElement(MainInfo.MainForm.MainControl.ControlInBuffer);
		}

		private bool commentIsOpen = false;
		private void label_comment_Click(object sender, EventArgs e)
		{
			textBox_comment.Text = filmInfo.Comment;
			Size controlSize = this.Size;

			if (commentIsOpen) { controlSize.Height -= 20; }
			else { controlSize.Height += 20; }

			this.Size = controlSize;
			commentIsOpen = !commentIsOpen;
		}

        public override Control ToUpdateControl()
        {
			return new SerieUpdateControl(this);
        }
    }
}
