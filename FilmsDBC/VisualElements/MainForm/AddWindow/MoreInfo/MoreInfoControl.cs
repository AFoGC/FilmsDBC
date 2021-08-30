using FilmsDBC.CinemaDataTypes;
using FilmsDBC.VisualElements.FilmControls;
using FilmsDBC.VisualElements.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.VisualElements.MainForm.AddWindow.MoreInfo
{
    public partial class MoreInfoControl : UserControl
    {
        public MoreInfoControl()
        {
            InitializeComponent();
        }

		public void Reinitialize(Film film, SimpleControl simpleContol)
		{
			flowLayoutPanel_main.Controls.Clear();
			if (film.Genre.IsSerialGenre)
			{
				flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film, simpleContol));
			}
			else
			{
				flowLayoutPanel_main.Controls.Add(ControlsConverter.ToFilmControl(film, simpleContol));
			}
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(this);
		}
	}
}
