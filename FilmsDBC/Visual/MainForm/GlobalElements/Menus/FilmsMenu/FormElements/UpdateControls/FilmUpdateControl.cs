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
    public partial class FilmUpdateControl : UserControl, IUpdateControl
	{
		private FilmControl filmControl = null;
		private Film film = null;
		public FilmUpdateControl(FilmControl filmControl)
		{
			InitializeComponent();
			this.filmControl = filmControl;
			this.film = filmControl.FilmInfo;

			comboBox_genre.Items.AddRange(MainInfo.Tables.GenresTable.ToArray());
			comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());
			refresh();

			label_comment.SetDefaultButtonBlink();
			label_sources.SetDefaultButtonBlink();
		}

		private void refresh()
		{
			Film defFilm = MainInfo.Tables.FilmsTable.DefaultCell;

			this.textBox_id.Text = film.ID.ToString();
			this.textBox_name.Text = film.Name;
			this.comboBox_genre.SelectedItem = film.Genre;
			this.textBox_realiseYear.Text = Film.FormatToString(film.RealiseYear, defFilm.RealiseYear);
			this.checkBox_watched.Checked = film.Watched;
			this.comboBox_mark.SelectedItem = VisualHelper.markToText(Film.FormatToString(film.Mark, defFilm.Mark));
			this.textBox_countOfviews.Text = Film.FormatToString(film.CountOfViews, defFilm.CountOfViews);
			this.dateUpdateControl_watchDate.Date = film.DateOfWatch;
			this.textBox_comment.Text = film.Comment;
		}

		public void UpdateElement()
		{
			film.Name = this.textBox_name.Text;
			film.Genre = (Genre)this.comboBox_genre.SelectedItem;
			film.RealiseYear = VisualHelper.TextToInt32(this.textBox_realiseYear.Text);
			film.Watched = this.checkBox_watched.Checked;
			film.Mark = VisualHelper.TextToMark(this.comboBox_mark.Text);
			film.CountOfViews = VisualHelper.TextToInt32(this.textBox_countOfviews.Text);
			film.DateOfWatch = this.dateUpdateControl_watchDate.Date;
			film.Comment = this.textBox_comment.Text;

			filmControl.RefreshData();
		}

        private void label_sources_Click(object sender, EventArgs e)
        {
			MainInfo.MainForm.MainControl.UpdateVisualizer.SourcesVisualizer.OpenSourceControl(this.film.Sources);
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
