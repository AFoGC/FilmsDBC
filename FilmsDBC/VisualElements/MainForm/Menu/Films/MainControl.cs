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
using TablesLibrary.Interpreter;

namespace FilmsDBC.VisualElements.MainForm.Menu.Films
{
	public partial class MainControl : UserControl
	{
		public MainControl()
		{
			InitializeComponent();
		}

		TableCollection tables = MainInformation.tableCollection;
		List<UserControl> tableControls = new List<UserControl>();

		private AElementControl controlInBuffer = null;
		public AElementControl ControlInBuffer
		{
			get { return controlInBuffer; }
			set { controlInBuffer = value; }
		}

		public Panel InfoPanel
        {
            get { return panel_Info; }
        }

		public void loadGenres()
		{
			flowLayoutPanel_requestsGenres.Controls.Clear();
			foreach (Genre genre in tables.GetTable(typeof(Genre)).Cells)
			{
				flowLayoutPanel_requestsGenres.Controls.Add(new GenrePressButton(genre));
			}
		}

		private void clearControls()
		{
			flowLayoutPanel_main.Controls.Clear();
			tableControls.Clear();
		}

		public void loadFilmTable()
		{
			clearControls();
			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
			{
				tableControls.Add(new FilmControl(film));
			}
			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		public void loadSerieTable()
		{
			clearControls();
			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
			{
				if (film.Genre.IsSerialGenre)
				{
					tableControls.Add(ControlsConverter.ToSerieControl(film));
				}
			}
			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		public void loadCategories()
		{
			clearControls();

			foreach (Category category in tables.GetTable(typeof(Category)).Cells)
			{
				tableControls.Add(new CategoryControl(category));
			}

			foreach (Film film in tables.GetTable(typeof(Film)).Cells)
			{
				if (film.FranshiseId == 0)
				{
					tableControls.Add(new SimpleControl(film));
				}
			}

			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		public void loadPriorityTable()
		{
			clearControls();

			Table priTable = tables.GetTable(typeof(PriorityFilm));
			PriorityFilm film;
			for (int i = 0; i < tables.GetTable(typeof(PriorityFilm)).Cells.Count; i++)
			{
				film = (PriorityFilm)priTable.Cells[i];

				if (film.Film.Watched)
                {
					tables.GetTable(typeof(PriorityFilm)).Cells.Remove(film);
					--i;
				}
                else
                {
					tableControls.Add(new SimpleControl(film.Film));
				}
			}

			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		private int controlsCondition = 1;
		public int ControlsCondition { get { return controlsCondition; } }
		private void button_ShowCategories_Click(object sender, EventArgs e)
		{
			controlsCondition = 1;
			loadCategories();
			controlInBuffer = null;
			unLockGenreButtons();
		}

		private void button_ShowFilms_Click(object sender, EventArgs e)
		{
			controlsCondition = 2;
			loadFilmTable();
			controlInBuffer = null;
			unLockGenreButtons();
		}

		private void button_ShowSeries_Click(object sender, EventArgs e)
		{
			controlsCondition = 3;
			loadSerieTable();
			controlInBuffer = null;
			lockNotSerialGenreButtons();
		}

		private void button_ShowPriorityFilms_Click(object sender, EventArgs e)
		{
			controlsCondition = 4;
			loadPriorityTable();
			controlInBuffer = null;
			unLockGenreButtons();
		}

		private void lockNotSerialGenreButtons()
		{
			foreach (GenrePressButton button in flowLayoutPanel_requestsGenres.Controls)
			{
				if (!button.Genre.IsSerialGenre)
				{
					button.Included = false;
					button.ClickLocked = true;
				}
			}
		}
		private void unLockGenreButtons()
		{
			foreach (GenrePressButton button in flowLayoutPanel_requestsGenres.Controls)
			{
				button.ClickLocked = false;
				button.Included = true;
			}
		}

		private void button_Search_Click(object sender, EventArgs e)
		{
			foreach (IControls control in flowLayoutPanel_main.Controls)
			{
				control.SetVisualDefault();
			}

			if (textBox_Search.Text != "")
			{
				String searchStr = textBox_Search.Text.ToLowerInvariant();

				foreach (IControls control in flowLayoutPanel_main.Controls)
				{
					control.SetFindedElement(searchStr);
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
			IControls control = new SimpleControl(film);
			switch (controlsCondition)
			{
				case 1:
					break;
				case 2:
					control = new FilmControl(film);
					break;
				case 3:
					film.Genre = (Genre)tables.GetTable(typeof(Genre)).GetElement(2);
					control = ControlsConverter.ToSerieControl(film);
					break;
				default:
					return;
			}

			tableControls.Add((UserControl)control);
			flowLayoutPanel_main.Controls.Add((UserControl)control);
		}

		private void button_AddToPriority_Click(object sender, EventArgs e)
		{
			if (controlInBuffer != null)
			{
				tables.GetTable(typeof(PriorityFilm)).addElement();
				PriorityFilm priorityFilm = (PriorityFilm)tables.GetTable(typeof(PriorityFilm)).GetLastElement;
				priorityFilm.Film = controlInBuffer.FilmInfo;
			}
		}

		private void button_filter_Click(object sender, EventArgs e)
		{
			flowLayoutPanel_main.Controls.Clear();
			Genre[] genres = getSelectedGenres();

			foreach (IControls control in tableControls)
			{
				if (watchedRequestControl.IsAllIncluded)
				{
					if (control.HasSelectedGenre(genres))
					{
						flowLayoutPanel_main.Controls.Add((UserControl)control);
					}
				}
				else
				{
					if (control.HasSelectedGenre(genres) && control.HasWatchedProperty(watchedRequestControl.IsWatched))
					{
						flowLayoutPanel_main.Controls.Add((UserControl)control);
					}
				}
			}
		}

		private Genre[] getSelectedGenres()
		{
			List<Genre> genres = new List<Genre>();
			foreach (GenrePressButton requestControl in flowLayoutPanel_requestsGenres.Controls)
			{
				if (requestControl.Included)
				{
					genres.Add(requestControl.Genre);
				}
			}
			return genres.ToArray();
		}
	}
}
