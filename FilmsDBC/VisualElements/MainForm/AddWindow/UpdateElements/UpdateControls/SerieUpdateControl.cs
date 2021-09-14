﻿using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.VisualElements.FilmControls;
using FilmsDBC.VisualElements.FilmControls.Interface;
using FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements.UpdateControls.SourceVisual;
using FilmsDBC.VisualElements.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements.UpdateControls
{
	public partial class SerieUpdateControl : UserControl, IUpdateControl
	{
		private AElementControl control = null;
		private Serie serie = null;
		private Film film = null;

		public SerieUpdateControl(SerieControl serieControl)
		{
			InitializeComponent();
			this.control = serieControl;

			this.serie = serieControl.SerieInfo;
			this.film = serieControl.FilmInfo;

			comboBox_genre.Items.AddRange(GenreMethods.GetAllGenresNames().ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());

			label_comment.SetDefaultButtonBlink();
			label_sources.SetDefaultButtonBlink();

			refresh();
		}

		public SerieUpdateControl(FilmControl filmControl)
		{
			InitializeComponent();
			this.control = filmControl;

			this.film = filmControl.FilmInfo;

			foreach (Serie serie in MainInformation.tableCollection.GetTable(typeof(Serie)).Cells)
			{
				if (serie.FilmId == film.ID)
				{
					this.serie = serie;
					goto cont;
				}
			}

			Serie ser = new Serie();
			ser.FilmId = film.ID;

			MainInformation.tableCollection.GetTable(typeof(Serie)).addElement(ser);

			cont:
			comboBox_genre.Items.AddRange(GenreMethods.GetAllGenresNames().ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());

			refresh();
		}

		private void refresh()
		{
			this.textBox_id.Text = film.ID.ToString();
			this.textBox_name.Text = film.Name;
			this.comboBox_genre.Text = film.Genre.Name;
			this.textBox_realiseYear.Text = Film.formatToString(film.RealiseYear);
			this.checkBox_watched.Checked = film.Watched;
			this.dateUpdateControl_watchDate.Date = film.DateOfWatch;
			this.comboBox_mark.Text = VisualHelper.markToText(Film.formatToString(film.Mark));
			this.textBox_countOfviews.Text = Film.formatToString(film.CountOfViews);
			this.textBox_comment.Text = film.Comment;

			this.dateUpdateControl_startWatchDate.Date = serie.StartWatchDate;
			this.textBox_countOfWatchedSeries.Text = Serie.formatToString(serie.CountOfWatchedSeries);
			this.textBox_totalSeries.Text = Serie.formatToString(serie.TotalSeries);
		}

		public void UpdateElement()
		{
			ControlsConverter.SetFilmValues(this, film);
			ControlsConverter.SetSerieValues(this, serie);
			control.RefreshData();
		}

		private void label_sources_Click(object sender, EventArgs e)
		{
			SourcesVisualizer.OpenSourceControl(this.film);
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