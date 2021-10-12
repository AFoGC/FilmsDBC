using FilmsDBC.DataAccessLayer.CinemaDataTables;
using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.MoreInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.MenuElements;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu
{
    public partial class MainControl : UserControl
	{
		public MainControl()
		{
			InitializeComponent();
			moreInfoVisualizer = new MoreInfoFormVisualizer(panel_Info);
			updateVisualizer = new UpdateFormVisualizer(panel_Info);
		}

		private MoreInfoFormVisualizer moreInfoVisualizer;
		public MoreInfoFormVisualizer MoreInfoVisualizer
        {
            get { return moreInfoVisualizer; }
        }
		private UpdateFormVisualizer updateVisualizer;
		public UpdateFormVisualizer UpdateVisualizer
        {
            get { return updateVisualizer; }
        }


		private List<UserControl> tableControls = new List<UserControl>();

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
			foreach (Genre genre in MainInfo.Tables.GenresTable)
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
			foreach (Film film in MainInfo.Tables.FilmsTable)
			{
				tableControls.Add(new FilmControl(film));
			}
			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		public void loadSerieTable()
		{
			clearControls();
			foreach (Film film in MainInfo.Tables.FilmsTable)
			{
				if (film.Genre.IsSerialGenre)
				{
					tableControls.Add(new SerieControl(film));
				}
			}
			flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
		}

		public void loadCategories()
		{
			clearControls();

			foreach (Category category in MainInfo.Tables.CategoriesTable)
			{
				tableControls.Add(new CategoryControl(category));
			}

			foreach (Film film in MainInfo.Tables.FilmsTable)
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

			PriorityFilmsTable priTable = MainInfo.Tables.PriorityFilmsTable;

			PriorityFilm film;
			for (int i = 0; i < MainInfo.Tables.PriorityFilmsTable.Count; i++)
			{
				film = priTable[i];

				if (film.Film.Watched)
                {
					MainInfo.Tables.PriorityFilmsTable.Remove(film);
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
			MainInfo.TableCollection.SaveTables();
		}

		private void button_addCategory_Click(object sender, EventArgs e)
		{
			if (controlsCondition == 1)
			{
				CategoriesTable categoryTable = MainInfo.Tables.CategoriesTable;
				categoryTable.AddElement();
				CategoryControl categoryControl = new CategoryControl((Category)categoryTable.GetLastElement);
				flowLayoutPanel_main.Controls.Add(categoryControl);
				flowLayoutPanel_main.Controls.SetChildIndex(categoryControl, categoryTable.Count - 1);
			}
		}

		private void button_addFilm_Click(object sender, EventArgs e)
		{
			MainInfo.Tables.FilmsTable.AddElement();
			Film film = MainInfo.Tables.FilmsTable.GetLastElement;
			IControls control = new SimpleControl(film);
			switch (controlsCondition)
			{
				case 1:
					break;
				case 2:
					control = new FilmControl(film);
					break;
				case 3:
					film.Genre =  MainInfo.Tables.GenresTable.GetFirstSeriealGenre(); //(Genre)tables.GetTable(typeof(Genre)).GetElement(2);
					control = new SerieControl(film);
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
				MainInfo.Tables.PriorityFilmsTable.AddElement();
				PriorityFilm priorityFilm = MainInfo.Tables.PriorityFilmsTable.GetLastElement; //(PriorityFilm)tables.GetTable(typeof(PriorityFilm)).GetLastElement;
				priorityFilm.Film = controlInBuffer.FilmInfo;
			}
		}

		private void button_filter_Click(object sender, EventArgs e)
		{
			flowLayoutPanel_main.Controls.Clear();
			Genre[] genres = getSelectedGenres();

			foreach (IFilmsControls control in tableControls)
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
