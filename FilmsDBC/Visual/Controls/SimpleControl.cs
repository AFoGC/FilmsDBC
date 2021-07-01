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
	public partial class SimpleControl : UserControl
	{
		private Film filmInfo;

		public Film FilmInfo
		{
			get { return filmInfo; }
		}

		public SimpleControl(Film film)
		{
			InitializeComponent();
			this.filmInfo = film;

			textBox_id.Text = filmInfo.ID.ToString();
			textBox_name.Text = filmInfo.Name;
			textBox_genre.Text = filmInfo.Genre.Name;
			textBox_realiseYear.Text = Film.formatToString(filmInfo.RealiseYear);
			checkBox_watched.Checked = filmInfo.Watched;
		}

		private void label_info_Click(object sender, EventArgs e)
		{
			FormVisualizer.OpenMoreInfoForm(FilmInfo);
		}
	}
}
