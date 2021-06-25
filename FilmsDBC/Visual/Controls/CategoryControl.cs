using FilmsDBC.CinemaDataTypes;
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

namespace FilmsDBC.Visual.Controls
{
	public partial class CategoryControl : UserControl
	{
		Category categoryInfo = null;
		public CategoryControl(Category category)
		{
			InitializeComponent();
			this.categoryInfo = category;

			this.textBox_id.Text = categoryInfo.ID.ToString();
			this.textBox_name.Text = category.Name;
			this.textBox_mark.Text = VisualHelper.markToText(Category.formatToString(category.Mark));

			categoryInfo.Films = category.Films;

			categoryFilms();
		}

		private void categoryFilms()
		{
			this.flowLayoutPanel_SimpleControls.Controls.Clear();

			Size panelSize = flowLayoutPanel_SimpleControls.Size;
			Size controlSize = this.Size;

			foreach (Film film in categoryInfo.Films)
            {
				panelSize.Height += 20;
				controlSize.Height += 20;
				this.Size = controlSize;
				flowLayoutPanel_SimpleControls.Size = panelSize;
				flowLayoutPanel_SimpleControls.Controls.Add(new SimpleControl(film));
            }
		}
	}
}
