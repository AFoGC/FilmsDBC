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
		private bool clicked = false;
		public bool Clicked
		{
			get { return clicked; }
		}
		public GenreRequestControl(Genre genre)
		{
			InitializeComponent();
			this.genre = genre;
			this.label_genre.Text = genre.Name;
		}

        private void label_genre_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
				this.label_genre.BackColor = SystemColors.ControlDark;
			}
            else
            {
				this.label_genre.BackColor = SystemColors.Control;
			}
			clicked = !clicked;
        }
    }
}
