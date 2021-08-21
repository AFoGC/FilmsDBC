using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.MoreInfo;
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
	public partial class SimpleControl : AElementControl
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
			textBox_id.Text = filmInfo.ID.ToString();
			textBox_name.Text = filmInfo.Name;
			textBox_genre.Text = filmInfo.Genre.Name;
			textBox_realiseYear.Text = Film.formatToString(filmInfo.RealiseYear);
			checkBox_watched.Checked = filmInfo.Watched;
		}

		public override void SetVisualDefault()
		{
			Color color = SystemColors.Control;

			this.BackColor = color;
			this.label_info.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;

			this.label_info.SetDefaultButtonBlink();
		}

		internal override void setVisualSelected()
		{
			Color color = Color.FromArgb(0, 220, 0);

			this.BackColor = color;
			this.label_info.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;

			this.label_info.MouseEnterColor = Color.FromArgb(0, 255, 0);
			this.label_info.MouseDownColor = Color.FromArgb(0, 200, 0);
		}

		internal override void setVisualFinded()
		{
			Color color = Color.FromArgb(0, 0, 220);

			this.BackColor = color;
			this.label_info.DefaultColor = color;
			this.textBox_id.BackColor = color;
			this.textBox_name.BackColor = color;
			this.textBox_genre.BackColor = color;
			this.textBox_realiseYear.BackColor = color;

			this.label_info.MouseEnterColor = Color.FromArgb(0, 0, 255);
			this.label_info.MouseDownColor = Color.FromArgb(0, 0, 200);
		}

		private void label_info_Click(object sender, EventArgs e)
		{
			MoreInfoFormVisualizer.OpenMoreInfoForm(FilmInfo, this);
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}

		private void textBox_id_Click(object sender, EventArgs e)
		{
			SetSelectedElement(MainInformation.MainForm.MainControl.ControlInBuffer);
		}
	}
}
