﻿using FilmsDBC.CinemaDataTypes;
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
			int result = 0;
			if (int.TryParse(textBox_addElement.Text, out result))
			{
				foreach (Film film in category.Films)
				{
					if (film.ID == result)
					{
						return;
					}
				}
				int i = 0;
				foreach (Film film in MainInformation.tableCollection.GetTable(typeof(Film)).Cells)
				{
					if (film.ID == result)
					{
						film.FranshiseId = category.ID;
						category.Films.Add(film);
						//categoryControl.RefreshData();
						categoryControl.AddSimpleCotrol(film);
						//categoryControl.flowLayoutPanel_SimpleControls.Controls.Add(new SimpleControl(film));

						if (MainInformation.MainForm.ControlsCondition == 1)
						{
							foreach (UserControl userControl in MainInformation.MainForm.flowLayoutPanel_main.Controls)
							{
								if (userControl.GetType() == typeof(SimpleControl))
								{
									SimpleControl simpleControl = (SimpleControl)userControl;
									if (simpleControl.FilmInfo == film)
									{
										MainInformation.MainForm.flowLayoutPanel_main.Controls.Remove(simpleControl);
									}
								}
							}
						}

						return;
					}
					++i;
				}
			}
		}
	}
}