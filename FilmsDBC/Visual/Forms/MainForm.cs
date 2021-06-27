using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
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
				if (GenreMethods.IsSerialGenre(film.Genre))
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

			foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
			{
				if (film.FranshiseId == 0)
				{
					flowLayoutPanel_main.Controls.Add(new SimpleControl(film));
				}
			}
		}

		private void button_ShowCategories_Click(object sender, EventArgs e)
		{
			controlsCondition = 1;
			loadCategories();
		}

		private void button_ShowFilms_Click(object sender, EventArgs e)
		{
			controlsCondition = 2;
			loadFilmTable();
		}

		private void button_ShowSeries_Click(object sender, EventArgs e)
		{
			controlsCondition = 3;
			loadSerieTable();
		}

		private int controlsCondition = 1;
		private void button_Search_Click(object sender, EventArgs e)
		{
			Color searchedColor = Color.Blue;

			switch (controlsCondition)
			{
				case 1:
					foreach (UserControl userControl in flowLayoutPanel_main.Controls)
					{
						if (userControl.GetType() == typeof(SimpleControl))
						{
							SimpleControl simpleControl = (SimpleControl)userControl;
							if (simpleControl.FilmInfo.Name.Contains(textBox_Search.Text))
							{
								userControl.BackColor = searchedColor;
							}
							
						}
						else
						{
							CategoryControl categoryControl = (CategoryControl)userControl;
							foreach(SimpleControl simpleControl in categoryControl.SimpleControls)
							{
								if (simpleControl.FilmInfo.Name.Contains(textBox_Search.Text))
								{
									simpleControl.BackColor = searchedColor;
								}
							}
						}
					}
					break;

				case 2:
					foreach (FilmControl filmControl in flowLayoutPanel_main.Controls)
					{
						if (filmControl.FilmInfo.Name.Contains(textBox_Search.Text))
						{
							filmControl.BackColor = searchedColor;
						}
					}
					break;

				case 3:
					foreach (SerieControl serieControl in flowLayoutPanel_main.Controls)
					{
						if (serieControl.FilmInfo.Name.Contains(textBox_Search.Text))
						{
							serieControl.BackColor = searchedColor;
						}
					}
					break;

				default:
					break;
			}
		}
	}
}
