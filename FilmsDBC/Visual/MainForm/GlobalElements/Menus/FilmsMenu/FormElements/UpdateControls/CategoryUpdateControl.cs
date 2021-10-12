using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls
{
    public partial class CategoryUpdateControl : UserControl, IUpdateControl
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
			category.Name = this.textBox_name.Text;
			categoryControl.RefreshData();
		}

		private void button_addElement_Click(object sender, EventArgs e)
		{
			if (MainInfo.MainForm.MainControl.ControlInBuffer != null)
			{
				if (MainInfo.MainForm.MainControl.ControlInBuffer.GetType() == typeof(SimpleControl))
				{
					SimpleControl simpleControl = (SimpleControl)MainInfo.MainForm.MainControl.ControlInBuffer;
					Film film = simpleControl.FilmInfo;
					if (film.FranshiseId == 0)
					{
						film.FranshiseId = category.ID;
						category.Films.Add(film);
						categoryControl.AddSimpleCotrol(film);
						MainInfo.MainForm.MainControl.flowLayoutPanel_main.Controls.Remove(simpleControl);
						MainInfo.MainForm.MainControl.ControlInBuffer = null;
					}
				}
			}
		}

		private void button_removeElement_Click(object sender, EventArgs e)
		{
			if (MainInfo.MainForm.MainControl.ControlInBuffer != null)
			{
				if (MainInfo.MainForm.MainControl.ControlInBuffer.GetType() == typeof(SimpleControl))
				{
					SimpleControl simpleControl = (SimpleControl)MainInfo.MainForm.MainControl.ControlInBuffer;
					Film film = simpleControl.FilmInfo;

					if (categoryControl.RemoveFilmFromCategory(simpleControl))
					{
						//this.categoryControl.flowLayoutPanel_SimpleControls.Controls.Remove(simpleControl);
						//this.categoryControl.RemoveSimpleControl();

						if (MainInfo.MainForm.MainControl.ControlsCondition == 1)
						{
							int i = 0;
							foreach (UserControl userControl in MainInfo.MainForm.MainControl.flowLayoutPanel_main.Controls)
							{
								if (userControl.GetType() == typeof(SimpleControl))
								{
									SimpleControl sControl = (SimpleControl)userControl;
									if (sControl.FilmInfo.ID > film.ID)
									{
										MainInfo.MainForm.MainControl.flowLayoutPanel_main.Controls.Add(simpleControl);
										MainInfo.MainForm.MainControl.flowLayoutPanel_main.Controls.SetChildIndex(simpleControl, i);
										break;
									}
								}
								++i;
							}
						}
					}
				}
			}
		}
	}
}
