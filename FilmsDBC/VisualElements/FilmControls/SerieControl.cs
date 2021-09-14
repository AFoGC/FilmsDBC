﻿using FilmsDBC.CinemaDataTypes;
using FilmsDBC.VisualElements.FilmControls.Interface;
using FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements;
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

namespace FilmsDBC.VisualElements.FilmControls
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
			InitializeComponent();
			this.serieInfo = serie;
			this.filmInfo = film;

			this.label_comment.SetDefaultButtonBlink();
			this.label_copyUrl.SetDefaultButtonBlink();
			this.label_update.SetDefaultButtonBlink();

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
			this.BackColor = color;
			this.label_comment.DefaultColor = color;
			this.label_copyUrl.DefaultColor = color;
			this.label_update.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;
			this.textBox_startWatchDate.BackColor = color;
			this.textBox_countOfWatchedSeries.BackColor = color;
			this.textBox_watchDate.BackColor = color;
			this.textBox_totalSeries.BackColor = color;
			this.textBox_mark.BackColor = color;
			this.textBox_countOfviews.BackColor = color;
			this.textBox_comment.BackColor = color;

			Color colorMouseEnter = Color.FromArgb(0, 0, 255);
			this.label_comment.MouseEnterColor = colorMouseEnter;
			this.label_copyUrl.MouseEnterColor = colorMouseEnter;
			this.label_update.MouseEnterColor = colorMouseEnter;

			Color colorMouseDown = Color.FromArgb(0, 0, 200);
			this.label_comment.MouseDownColor = colorMouseDown;
			this.label_copyUrl.MouseDownColor = colorMouseDown;
			this.label_update.MouseDownColor = colorMouseDown;
		}

		public override void SetVisualDefault()
		{
			Color color = SystemColors.Control;
			this.BackColor = color;
			this.label_comment.DefaultColor = color;
			this.label_copyUrl.DefaultColor = color;
			this.label_update.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;
			this.textBox_startWatchDate.BackColor = color;
			this.textBox_countOfWatchedSeries.BackColor = color;
			this.textBox_watchDate.BackColor = color;
			this.textBox_totalSeries.BackColor = color;
			this.textBox_mark.BackColor = color;
			this.textBox_countOfviews.BackColor = color;
			this.textBox_comment.BackColor = color;

			this.label_comment.SetDefaultButtonBlink();
			this.label_copyUrl.SetDefaultButtonBlink();
			this.label_update.SetDefaultButtonBlink();
		}

		internal override void setVisualSelected()
		{
			Color color = Color.FromArgb(0, 220, 0);
			this.BackColor = color;
			this.label_comment.DefaultColor = color;
			this.label_copyUrl.DefaultColor = color;
			this.label_update.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;
			this.textBox_startWatchDate.BackColor = color;
			this.textBox_countOfWatchedSeries.BackColor = color;
			this.textBox_watchDate.BackColor = color;
			this.textBox_totalSeries.BackColor = color;
			this.textBox_mark.BackColor = color;
			this.textBox_countOfviews.BackColor = color;
			this.textBox_comment.BackColor = color;

			Color colorMouseEnter = Color.FromArgb(0, 255, 0);
			this.label_comment.MouseEnterColor = colorMouseEnter;
			this.label_copyUrl.MouseEnterColor = colorMouseEnter;
			this.label_update.MouseEnterColor = colorMouseEnter;

			Color colorMouseDown = Color.FromArgb(0, 200, 0);
			this.label_comment.MouseDownColor = colorMouseDown;
			this.label_copyUrl.MouseDownColor = colorMouseDown;
			this.label_update.MouseDownColor = colorMouseDown;
		}

		private void label_update_Click(object sender, EventArgs e)
		{
			UpdateFormVisualizer.OpenUpdateControl(this);
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
			SetSelectedElement(MainInformation.MainForm.MainControl.ControlInBuffer);
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
	}
}