using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms
{
	public partial class GenreRequestControl : UserControl
	{
		private Genre genre = null;
		public Genre Genre
		{
			get { return genre; }
		}
		private bool included = true;
		public bool Included
		{
			get { return included; }
            set
            {
                if (value)
                {
					this.label_genre.BackColor = SystemColors.ControlDark;
				}
                else
                {
					this.label_genre.BackColor = SystemColors.Control;
				}
				included = value;
            }
		}
		public GenreRequestControl(Genre genre)
		{
			InitializeComponent();
			this.genre = genre;
			this.label_genre.Text = genre.Name;
		}

        private void label_genre_Click(object sender, EventArgs e)
        {
			Included = !included;
        }
    }
}
