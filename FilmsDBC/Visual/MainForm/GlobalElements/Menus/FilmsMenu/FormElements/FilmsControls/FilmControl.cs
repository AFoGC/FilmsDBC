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
    public partial class FilmControl : AElementControl
	{
		public SimpleControl simpleControl = null;

		public FilmControl(Film film)
		{
			InitializeComponent();
			this.filmInfo = film;

			this.label_comment.SetDefaultButtonBlink();
			this.label_copyUrl.SetDefaultButtonBlink();
			this.label_update.SetDefaultButtonBlink();

			RefreshData();
		}

		public FilmControl(SimpleControl simpleControl)
        {
			InitializeComponent();
			this.filmInfo = simpleControl.filmInfo;
			this.simpleControl = simpleControl;

			this.label_comment.SetDefaultButtonBlink();
			this.label_copyUrl.SetDefaultButtonBlink();
			this.label_update.SetDefaultButtonBlink();


			RefreshData();
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
			this.textBox_comment.Text = filmInfo.Comment;
			this.RefreshSourceLabel();

			if (simpleControl != null)
			{
				simpleControl.RefreshData();
			}
		}

		public void RefreshSourceLabel()
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

		private void label_update_Click(object sender, EventArgs e)
		{
			MainInfo.MainForm.MainControl.UpdateVisualizer.OpenUpdateControl(this, MainInfo.MainForm.MainControl.MoreInfoVisualizer);
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}

		private void label_copyUrl_Click(object sender, EventArgs e)
		{
			if (filmInfo.Sources.Count != 0)
			{
				Clipboard.SetText(filmInfo.Sources[0].sourceUrl);
			}
		}

		internal override void setVisualFinded()
		{
			Color color = Color.FromArgb(0, 0, 220);
			this.textBox_id.BackColor = color;
		}

		internal override void setVisualSelected()
		{
			Color color = Color.FromArgb(0, 220, 0);
			this.textBox_id.BackColor = color;
		}

		public override void SetVisualDefault()
		{
			Color color = Color.FromArgb(53, 53, 53);
			this.textBox_id.BackColor = color;
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

			if (commentIsOpen) { controlSize.Height -= 15; }
			else { controlSize.Height += 15; }

			this.Size = controlSize;
			commentIsOpen = !commentIsOpen;
		}

        public override Control ToUpdateControl()
        {
			if (filmInfo.Genre.IsSerialGenre)
			{
				return new SerieUpdateControl(this);
			}
			else
			{
				return new FilmUpdateControl(this);
			}
        }
    }
}
