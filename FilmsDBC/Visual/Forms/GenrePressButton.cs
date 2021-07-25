using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.Forms
{
	public class GenrePressButton : FilmsDBC.Visual.Buttons.PressButton
	{
		private Genre genre = null;
		public Genre Genre
		{
			get { return genre; }
		}
		public GenrePressButton(Genre genre)
		{
			InitializeComponent();
			this.genre = genre;
			this.Text = genre.Name;
			this.DefaultColor = SystemColors.Control;
			this.Included_DefaultColor = SystemColors.ControlDark;
			this.ClickLocked = false;
			this.Included = true;
			this.Size = new Size(129, 20);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
			this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			this.SetDefaultButtonBlink();
			this.SetDefaultIncludedButtonBlink();
		}
	}
}
