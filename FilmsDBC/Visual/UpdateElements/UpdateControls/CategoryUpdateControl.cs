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

namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
	public partial class CategoryUpdateControl : UserControl
	{
		private CategoryControl categoryControl = null;
		private Category category = null;
		public CategoryUpdateControl(CategoryControl categoryControl)
		{
			InitializeComponent();
			this.categoryControl = categoryControl;
			this.category = categoryControl.CategoryInfo;

			refresh();
		}

		private void refresh()
		{
			this.textBox_id.Text = category.ID.ToString();
			this.textBox_name.Text = category.Name;

		}


		public void UpdateElement()
		{
			ControlsConverter.SetCategoryValues(this, category);
			categoryControl.RefreshData();
		}

		private void button_addElement_Click(object sender, EventArgs e)
		{
			if (MainInformation.MainForm.ControlInBuffer != null)
			{
				if (MainInformation.MainForm.ControlInBuffer.GetType() == typeof(SimpleControl))
				{
					SimpleControl simpleControl = (SimpleControl)MainInformation.MainForm.ControlInBuffer;
					Film film = simpleControl.FilmInfo;
					if (film.FranshiseId == 0)
					{
						film.FranshiseId = category.ID;
						category.Films.Add(film);
						categoryControl.AddSimpleCotrol(film);
						MainInformation.MainForm.flowLayoutPanel_main.Controls.Remove(simpleControl);
						MainInformation.MainForm.ControlInBuffer = null;
					}
				}
			}
		}
	}
}
