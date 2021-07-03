using FilmsDBC.CinemaDataTypes;
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
	public partial class CategoryElementUpdateControl : UserControl
	{
		private bool checkedElement;
		public bool CheckedElement { get { return checkedElement; } }
		Film film = null;
		public CategoryElementUpdateControl(Film film)
		{
			InitializeComponent();
			this.film = film;

			refresh();
		}

		private void button_setIndex_Click(object sender, EventArgs e)
		{
			//film.FranshiseListIndex = Convert.ToSByte(textBox_setElementIndex.Text);
			refresh();
		}

		private void refresh()
		{
			this.textBox_id.Text = film.ID.ToString();
			this.textBox_name.Text = film.Name;
			//this.textBox_setElementIndex.Text = film.FranshiseListIndex.ToString();
		}

        private void CategoryElementUpdateControl_Click(object sender, EventArgs e)
        {
			checkedElement = !checkedElement;
			if (checkedElement)
            {
				this.BackColor = Color.Blue;
            }
            else
            {
				this.BackColor = SystemColors.Control;
            }
        }
    }
}
