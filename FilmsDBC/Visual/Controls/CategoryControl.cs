using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Forms;
using FilmsDBC.Visual.StaticVisualClasses;
using FilmsDBC.Visual.UpdateElements;
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

			RefreshData();
		}

		public void RefreshData()
		{
			this.textBox_id.Text = categoryInfo.ID.ToString();
			this.textBox_name.Text = categoryInfo.Name;
			this.textBox_mark.Text = VisualHelper.markToText(Category.formatToString(categoryInfo.Mark));

			categoryFilms();
		}

		private Point controlPoint = new Point(830, 25);
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
				panelSize.Height += 20;
				controlSize.Height += 20;
				this.Size = controlSize;
				flowLayoutPanel_SimpleControls.Size = panelSize;
				flowLayoutPanel_SimpleControls.Controls.Add(new SimpleControl(film));
			}
		}

		private void label_update_Click(object sender, EventArgs e)
		{
			UpdateFormVisualizer.OpenUpdateForm(this);
		}
	}
}
