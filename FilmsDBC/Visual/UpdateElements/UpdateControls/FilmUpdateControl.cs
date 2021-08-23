using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.Controls;
using FilmsDBC.Visual.StaticVisualClasses;
using FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
	public partial class FilmUpdateControl : UserControl, IUpdateControl
	{
		private FilmControl filmControl = null;
		private Film film = null;
		public FilmUpdateControl(FilmControl filmControl)
		{
			InitializeComponent();
			this.filmControl = filmControl;
			this.film = filmControl.FilmInfo;

			comboBox_genre.Items.AddRange(GenreMethods.GetAllGenresNames().ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());
			refresh();

			label_comment.SetDefaultButtonBlink();
			label_sources.SetDefaultButtonBlink();
		}

		private void refresh()
		{
			this.textBox_id.Text = film.ID.ToString();
			this.textBox_name.Text = film.Name;
			this.comboBox_genre.Text = film.Genre.Name;
			this.textBox_realiseYear.Text = Film.formatToString(film.RealiseYear);
			this.checkBox_watched.Checked = film.Watched;
			this.comboBox_mark.Text = VisualHelper.markToText(Film.formatToString(film.Mark));
			this.textBox_countOfviews.Text = Film.formatToString(film.CountOfViews);
			this.dateUpdateControl_watchDate.Date = film.DateOfWatch;
			this.textBox_comment.Text = film.Comment;
		}

		public void UpdateElement()
		{
			ControlsConverter.SetFilmValues(this, film);
			filmControl.RefreshData();
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

			if (textBox_countOfviews.Text == "")
			{
				textBox_countOfviews.Text = "1";
			}
		}
    }
}
