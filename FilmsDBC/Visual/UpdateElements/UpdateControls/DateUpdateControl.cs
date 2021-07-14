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
	public partial class DateUpdateControl : UserControl
	{
		DateTime date = new DateTime();
		public DateUpdateControl(DateTime date)
		{
			InitializeComponent();

			if (this.date != date)
			{
				this.date = date;
				refresh();
			}
		}

		private void refresh()
		{
			textBox_day.Text = date.Day.ToString();
			textBox_month.Text = date.Month.ToString();
			textBox_year.Text = date.Year.ToString();
		}

		private void textBox_date_Click(object sender, EventArgs e)
		{
			if (textBox_day.Text == "" && textBox_month.Text == "" && textBox_year.Text == "")
			{
				this.date = DateTime.Today;
				refresh();
			}
		}

		public DateTime GetDate
		{
			get
			{
				date = new DateTime (
						Convert.ToInt32(textBox_year.Text),
						Convert.ToInt32(textBox_month.Text),
						Convert.ToInt32(textBox_year.Text)
						);
				return date;
			}
		}
	}
}
