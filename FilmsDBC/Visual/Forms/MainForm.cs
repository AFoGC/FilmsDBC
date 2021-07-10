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
using TablesLibrary.Interpreter;

namespace FilmsDBC.Visual.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		Color searchColor = Color.Blue;
		Color defaultColor = SystemColors.Control;
		Color selectColor = Color.Green;

		private UserControl controlInBuffer = null;
		public UserControl ControlInBuffer
		{
            get { return controlInBuffer; }
			set 
			{
                if (controlInBuffer != null)
                {
					controlInBuffer.BackColor = defaultColor;
                }
				controlInBuffer = value;
				if (value != null)
                {
					controlInBuffer.BackColor = selectColor;
				}
			}
        }

		public void loadFilmTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new FilmControl(film));
			}
		}

		public void loadSerieTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
			{
				if (film.Genre.IsSerialGenre)
				{
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
				}
			}
		}

		public void loadCategories()
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

		private int controlsCondition = 1;
		public int ControlsCondition { get { return controlsCondition; } }
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

		private void button_Search_Click(object sender, EventArgs e)
		{ 
			if (textBox_Search.Text != "")
			{
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
									userControl.BackColor = searchColor;
								}

							}
							else
							{
								CategoryControl categoryControl = (CategoryControl)userControl;
                                if (categoryControl.CategoryInfo.Name.Contains(textBox_Search.Text))
                                {
									categoryControl.BackColor = searchColor;
								}
								foreach (SimpleControl simpleControl in categoryControl.SimpleControls)
								{
									if (simpleControl.FilmInfo.Name.Contains(textBox_Search.Text))
									{
										simpleControl.BackColor = searchColor;
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
								filmControl.BackColor = searchColor;
							}
						}
						break;

					case 3:
						foreach (SerieControl serieControl in flowLayoutPanel_main.Controls)
						{
							if (serieControl.FilmInfo.Name.Contains(textBox_Search.Text))
							{
								serieControl.BackColor = searchColor;
							}
						}
						break;

					default:
						break;
				}
			}
            else
            {
                foreach (UserControl userControl in flowLayoutPanel_main.Controls)
                {
                    if (userControl.GetType() == typeof(CategoryControl))
                    {
						CategoryControl categoryControl = (CategoryControl)userControl;
						categoryControl.BackColor = defaultColor;
                        foreach (SimpleControl simpleControl in categoryControl.flowLayoutPanel_SimpleControls.Controls)
                        {
							simpleControl.BackColor = defaultColor;
                        }
                    }
                    else
                    {
						userControl.BackColor = defaultColor;
					}
                }
            }
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			MainInformation.tableCollection.saveTables();
		}

		private void button_addCategory_Click(object sender, EventArgs e)
		{
			if (controlsCondition == 1)
			{
				Table categoryTable = MainInformation.tableCollection.GetTable(typeof(Category));
				categoryTable.addElement();
				CategoryControl categoryControl = new CategoryControl((Category)categoryTable.GetLastElement);
				flowLayoutPanel_main.Controls.Add(categoryControl);
				flowLayoutPanel_main.Controls.SetChildIndex(categoryControl, categoryTable.Cells.Count - 1);
			}
		}

		private void button_addFilm_Click(object sender, EventArgs e)
		{
			MainInformation.tableCollection.GetTable(typeof(Film)).addElement();
			Film film = (Film)MainInformation.tableCollection.GetTable(typeof(Film)).GetLastElement;
			switch (controlsCondition)
			{
				case 1:
					flowLayoutPanel_main.Controls.Add(new SimpleControl(film));
					break;
				case 2:
					flowLayoutPanel_main.Controls.Add(new FilmControl(film));
					break;
				case 3:
					film.Genre = (Genre)MainInformation.tableCollection.GetTable(typeof(Genre)).GetElement(2);
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
					break;
				default:
					break;
			}
		}
	}
}
