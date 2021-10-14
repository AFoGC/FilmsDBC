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
    public partial class SimpleControl : AElementControl, ISimpleControl
	{

		public SimpleControl(Film film)
		{
			InitializeComponent();
			this.filmInfo = film;

			this.label_info.SetDefaultButtonBlink();
			RefreshData();
		}

		public override void RefreshData()
		{
			Film defFilm = MainInfo.Tables.FilmsTable.DefaultCell;

			textBox_id.Text = filmInfo.ID.ToString();
			textBox_name.Text = filmInfo.Name;
			textBox_genre.Text = filmInfo.Genre.Name;
			textBox_realiseYear.Text = Film.FormatToString(filmInfo.RealiseYear, defFilm.RealiseYear);
			checkBox_watched.Checked = filmInfo.Watched;
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

		internal override void setVisualFinded()
		{
			Color color = Color.FromArgb(0, 0, 220);

			this.textBox_id.BackColor = color;
		}

		private void label_info_Click(object sender, EventArgs e)
		{
			MainInfo.MainForm.MainControl.MoreInfoVisualizer.OpenMoreInfoForm(this, MainInfo.MainForm.MainControl.UpdateVisualizer);
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}

		private void textBox_id_Click(object sender, EventArgs e)
		{
			SetSelectedElement(MainInfo.MainForm.MainControl.ControlInBuffer);
		}

		public Control ToMoreInfo()
        {
            if (filmInfo.Genre.IsSerialGenre)
            {
				return new SerieControl(this);
            }
            else
            {
				return new FilmControl(this);
            }
        }

        public override Control ToUpdateControl()
        {
			if (filmInfo.Genre.IsSerialGenre)
			{
				return new SerieUpdateControl(new SerieControl(this));
			}
			else
			{
				return new FilmUpdateControl(new FilmControl(this));
			}
		}
    }
}
