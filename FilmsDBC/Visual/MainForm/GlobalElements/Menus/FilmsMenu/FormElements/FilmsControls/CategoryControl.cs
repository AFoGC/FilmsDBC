using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls
{
    public partial class CategoryControl : UserControl, IFilmsControls
	{
		private Category categoryInfo = null;

		public Category CategoryInfo
		{
			get { return categoryInfo; }
		}

		public ControlCollection SimpleControls
		{
			get { return flowLayoutPanel_SimpleControls.Controls; }
		}

		public CategoryControl(Category category)
		{
			InitializeComponent();
			this.categoryInfo = category;

			this.label_update.SetDefaultButtonBlink();
			RefreshData();
		}

		public void RefreshData()
		{
			this.textBox_id.Text = categoryInfo.ID.ToString();
			this.textBox_name.Text = categoryInfo.Name;
			this.textBox_mark.Text = VisualHelper.markToText(Category.FormatToString(categoryInfo.Mark, -1));

			categoryFilms();
		}

		private Point controlPoint = new Point(830, 18);
		private Point panelPoint = new Point(800, 5);

		private void categoryFilms()
		{
			this.flowLayoutPanel_SimpleControls.Controls.Clear();

			Size panelSize = new Size(panelPoint);
			Size controlSize = new Size(controlPoint);

			this.Size = new Size(controlPoint);
			flowLayoutPanel_SimpleControls.Size = new Size(panelPoint);

			foreach (Film film in categoryInfo.Films)
			{
				panelSize.Height += 15;
				controlSize.Height += 15;
				this.Size = controlSize;
				flowLayoutPanel_SimpleControls.Size = panelSize;
				flowLayoutPanel_SimpleControls.Controls.Add(new SimpleControl(film));
			}

			foreach (SimpleControl simpleControl in flowLayoutPanel_SimpleControls.Controls)
			{
				flowLayoutPanel_SimpleControls.Controls.SetChildIndex(simpleControl, simpleControl.FilmInfo.FranshiseListIndex);
			}
		}

		public void AddSimpleCotrol(Film film)
		{
			Size controlSize = this.Size;
			Size panelSize = this.flowLayoutPanel_SimpleControls.Size;
			panelSize.Height += 15;
			controlSize.Height += 15;
			this.Size = controlSize;
			flowLayoutPanel_SimpleControls.Size = panelSize;

			this.flowLayoutPanel_SimpleControls.Controls.Add(new SimpleControl(film));

			film.FranshiseListIndex = Convert.ToSByte(flowLayoutPanel_SimpleControls.Controls.Count - 1);
		}

		public bool RemoveFilmFromCategory(SimpleControl simpleControl)
		{
			if (simpleControl.FilmInfo.FranshiseId == this.categoryInfo.ID)
			{
				flowLayoutPanel_SimpleControls.Controls.Remove(simpleControl);

				Size controlSize = this.Size;
				Size panelSize = this.flowLayoutPanel_SimpleControls.Size;
				panelSize.Height -= 15;
				controlSize.Height -= 15;
				this.Size = controlSize;
				flowLayoutPanel_SimpleControls.Size = panelSize;

				simpleControl.FilmInfo.FranshiseId = 0;
				simpleControl.FilmInfo.FranshiseListIndex = 0;

				foreach (Film film in categoryInfo.Films)
				{
					if (simpleControl.FilmInfo.FranshiseListIndex < film.FranshiseListIndex)
					{
						--film.FranshiseListIndex;
					}
				}

				return categoryInfo.Films.Remove(simpleControl.FilmInfo);
			}
			else
			{
				return false;
			}
		}

		private void label_update_Click(object sender, EventArgs e)
		{
			MainInfo.MainForm.MainControl.UpdateVisualizer.OpenUpdateControl(this, MainInfo.MainForm.MainControl.MoreInfoVisualizer);
		}

		public bool SetFindedElement(string search)
		{
			bool export = false;
			if (this.CategoryInfo.Name.ToLowerInvariant().Contains(search))
			{
				setVisualFinded();
			}

			foreach (IControls control in flowLayoutPanel_SimpleControls.Controls)
			{
				control.SetFindedElement(search);
			}

			return export;
		}

		private void setVisualFinded()
		{
			Color color = Color.FromArgb(0, 0 , 220);

			textBox_id.BackColor = color;
		}

		public void SetVisualDefault()
		{
			textBox_id.BackColor = Color.FromArgb(53, 53, 53);

			foreach (IControls control in flowLayoutPanel_SimpleControls.Controls)
			{
				control.SetVisualDefault();
			}
		}

		public bool HasSelectedGenre(Genre[] selectedGenres)
		{
			foreach (SimpleControl control in flowLayoutPanel_SimpleControls.Controls)
			{
				if (control.HasSelectedGenre(selectedGenres))
				{
					return true;
				}
			}

			return false;
		}

		public bool HasWatchedProperty(bool isWached)
		{
			foreach (SimpleControl control in flowLayoutPanel_SimpleControls.Controls)
			{
				if (control.HasWatchedProperty(isWached))
				{
					return true;
				}
			}

			return false;
		}

        public Control ToUpdateControl()
        {
			return new CategoryUpdateControl(this);
        }
    }
}
