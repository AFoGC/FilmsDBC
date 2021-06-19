using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Controls;
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

			loadFilmTable();
		}

		private void loadFilmTable()
		{
			foreach (Film film in MainInformation.tableCollection.getTable(2).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new FilmControl(film));
			}
		}
	}
}
