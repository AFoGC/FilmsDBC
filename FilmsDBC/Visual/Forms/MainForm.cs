using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Controls;
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

namespace FilmsDBC.Visual.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			//loadSimpleTable();
			loadTable();
		}

		private void loadFilmTable()
		{
			foreach (Film film in MainInformation.tableCollection.GetTable(2).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new FilmControl(film));
			}
		}

		private void loadTable()
        {
            foreach (Film film in MainInformation.tableCollection.GetTable(2).Cells)
            {
                if (film.Genre == "м/с" || 
					film.Genre == "сериал"
					)
                {
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
                }
                else
                {
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToFilmControl(film));
                }
            }
        }

		private void loadSimpleTable()
        {
            foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
            {
				flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSimpleControl(film));
            }
        }
	}
}
