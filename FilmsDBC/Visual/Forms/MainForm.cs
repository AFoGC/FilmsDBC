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

		TableCollection tables = MainInformation.tableCollection;
		public MainForm()
		{
			InitializeComponent();
		}
		
		private AElementControl controlInBuffer = null;
		public AElementControl ControlInBuffer
		{
			get { return controlInBuffer; }
			set { controlInBuffer = value; }
		}

		public void loadFilmTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new FilmControl(film));
			}
		}

		public void loadSerieTable()
		{
			flowLayoutPanel_main.Controls.Clear();
			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
			{
				if (film.Genre.IsSerialGenre)
				{
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
				}
			}
		}

		public void loadGenres()
		{
			flowLayoutPanel_requestsGenres.Controls.Clear();
			foreach (Genre genre in tables.GetTable(typeof(Genre)).Cells)
			{
				flowLayoutPanel_requestsGenres.Controls.Add(new GenreRequestControl(genre));
			}
		}

		public void loadCategories()
		{
			flowLayoutPanel_main.Controls.Clear();

			foreach (Category category in tables.GetTable(typeof(Category)).Cells)
			{
				flowLayoutPanel_main.Controls.Add(new CategoryControl(category));
			}

			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
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
			controlInBuffer = null;
		}

		private void button_ShowFilms_Click(object sender, EventArgs e)
		{
			controlsCondition = 2;
			loadFilmTable();
			controlInBuffer = null;
		}

		private void button_ShowSeries_Click(object sender, EventArgs e)
		{
			controlsCondition = 3;
			loadSerieTable();
			controlInBuffer = null;
		}

		private void button_Search_Click(object sender, EventArgs e)
		{
			foreach (IControls control in flowLayoutPanel_main.Controls)
			{
				control.SetDefaultVisualCondition();
			}

			if (textBox_Search.Text != "")
			{
				foreach (IControls control in flowLayoutPanel_main.Controls)
				{
					control.SetFindedElement(textBox_Search.Text);
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
				Table categoryTable = tables.GetTable(typeof(Category));
				categoryTable.addElement();
				CategoryControl categoryControl = new CategoryControl((Category)categoryTable.GetLastElement);
				flowLayoutPanel_main.Controls.Add(categoryControl);
				flowLayoutPanel_main.Controls.SetChildIndex(categoryControl, categoryTable.Cells.Count - 1);
			}
		}

		private void button_addFilm_Click(object sender, EventArgs e)
		{
			tables.GetTable(typeof(Film)).addElement();
			Film film = (Film)tables.GetTable(typeof(Film)).GetLastElement;
			switch (controlsCondition)
			{
				case 1:
					flowLayoutPanel_main.Controls.Add(new SimpleControl(film));
					break;
				case 2:
					flowLayoutPanel_main.Controls.Add(new FilmControl(film));
					break;
				case 3:
					film.Genre = (Genre)tables.GetTable(typeof(Genre)).GetElement(2);
					flowLayoutPanel_main.Controls.Add(ControlsConverter.ToSerieControl(film));
					break;
				default:
					break;
			}
		}
	}
}
