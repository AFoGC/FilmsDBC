﻿using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.VisualElements.FilmControls;
using FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements.UpdateControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.VisualElements.StaticVisualClasses
{
	public static class ControlsConverter
	{
		public static FilmControl ToFilmControl(Film film)
		{
			return new FilmControl(film);
		}

		public static FilmControl ToFilmControl(Film film, SimpleControl simpleControl)
        {
			FilmControl filmControl = new FilmControl(film);
			filmControl.simpleControl = simpleControl;
			return filmControl;
        }

		public static SerieControl ToSerieControl(Film film)
		{
			foreach(Serie serie in MainInformation.tableCollection.GetTable(typeof(Serie)).Cells)
			{
				if (serie.FilmId == film.ID)
				{
					return new SerieControl(film, serie);
				}
			}

			Serie ser = new Serie();
			ser.FilmId = film.ID;

			MainInformation.tableCollection.GetTable(typeof(Serie)).addElement(ser);

			return new SerieControl(film, (Serie)MainInformation.tableCollection.GetTable(typeof(Serie)).GetLastElement);
		}

		public static SerieControl ToSerieControl(Film film, SimpleControl simpleControl)
        {
			SerieControl serieControl = ToSerieControl(film);
			serieControl.simpleControl = simpleControl;
			return serieControl;
        }

		public static SimpleControl ToSimpleControl(Film film)
		{
			return new SimpleControl(film);
		}

		//---------------------------------------------

		public static void SetFilmValues(FilmUpdateControl control, Film film)
		{
			film.Name = control.textBox_name.Text;
			film.Genre = GenreMethods.GetByName(control.comboBox_genre.Text);
			film.RealiseYear = VisualHelper.TextToInt32(control.textBox_realiseYear.Text);
			film.Watched = control.checkBox_watched.Checked;
			film.Mark = VisualHelper.TextToMark(control.comboBox_mark.Text);
			film.CountOfViews = VisualHelper.TextToInt32(control.textBox_countOfviews.Text);
			film.DateOfWatch = control.dateUpdateControl_watchDate.Date;
			film.Comment = control.textBox_comment.Text;
		}

		public static void SetFilmValues(SerieUpdateControl control, Film film)
		{
			film.Name = control.textBox_name.Text;
			film.Genre = GenreMethods.GetByName(control.comboBox_genre.Text);
			film.RealiseYear = VisualHelper.TextToInt32(control.textBox_realiseYear.Text);
			film.Watched = control.checkBox_watched.Checked;
			film.DateOfWatch = control.dateUpdateControl_watchDate.Date;
			film.Mark = VisualHelper.TextToMark(control.comboBox_mark.Text);
			film.CountOfViews = VisualHelper.TextToInt32(control.textBox_countOfviews.Text);
			film.Comment = control.textBox_comment.Text;
		}

		public static void SetSerieValues(SerieUpdateControl control, Serie serie)
		{
			serie.StartWatchDate = control.dateUpdateControl_startWatchDate.Date;
			serie.CountOfWatchedSeries = VisualHelper.TextToInt32(control.textBox_countOfWatchedSeries.Text);
			serie.TotalSeries = VisualHelper.TextToInt32(control.textBox_totalSeries.Text);
		}

		public static void SetCategoryValues(CategoryUpdateControl control, Category category)
        {
			category.Name = control.textBox_name.Text;
        }
	}
}