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
			loadCategories();
		}

		private void loadFilmTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new FilmControl(film));
			}
		}

		private void loadSerieTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in MainInformation.tableCollection.GetTable(2).Cells)
			{
				if (film.Genre == "м/с" || 
					film.Genre == "сериал"
					)
				{
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
				}
			}
		}

		private void loadCategories()
		{
			flowLayoutPanel_main.Controls.Clear();

			foreach (Category category in MainInformation.tableCollection.GetTable(typeof(Category)).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new CategoryControl(category));
			}

			//CategoryControl categoryControl = new CategoryControl(new Category());
			foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
			{
				if (film.FranshiseId == 0)
				{
					//categoryControl.
					flowLayoutPanel_main.Controls.Add(new SimpleControl(film));
				}
			}
		}

		private void button_ShowCategories_Click(object sender, EventArgs e)
		{
			loadCategories();
		}

		private void button_ShowFilms_Click(object sender, EventArgs e)
		{
			loadFilmTable();
		}

		private void button_ShowSeries_Click(object sender, EventArgs e)
		{
			loadSerieTable();
		}

		private void button_Search_Click(object sender, EventArgs e)
		{

		}
	}
}
