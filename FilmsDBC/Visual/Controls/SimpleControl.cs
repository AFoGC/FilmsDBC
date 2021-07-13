using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.MoreInfo;
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

		public override void SetDefaultVisualCondition()
		{
			this.BackColor = SystemColors.Control;
		}

		internal override void setVisualSelected()
		{
			this.BackColor = Color.Green;
		}

		internal override void setVisualFinded()
		{
			this.BackColor = Color.Blue;
		}

		private void label_info_Click(object sender, EventArgs e)
		{
			MoreInfoFormVisualizer.OpenMoreInfoForm(FilmInfo);
		}

		private void checkBox_watched_Click(object sender, EventArgs e)
		{
			checkBox_watched.Checked = !checkBox_watched.Checked;
		}

		private void textBox_id_Click(object sender, EventArgs e)
		{
			MainInformation.MainForm.ControlInBuffer = this;
		}
	}
}
