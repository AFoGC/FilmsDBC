using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Buttons
{
	public partial class DateUpdateControl : UserControl
	{
		DateTime date = new DateTime();

		public DateUpdateControl()
		{
			InitializeComponent();
		}

		private void refresh()
		{
			if (date != new DateTime())
			{
				if (date.Day < 10) { textBox_day.Text = "0"; }
				textBox_day.Text += date.Day.ToString();
				if (date.Month < 10) { textBox_month.Text = "0"; }
				textBox_month.Text += date.Month.ToString();

				textBox_year.Text = date.Year.ToString();
			}
			else
			{
				textBox_day.Text = "";
				textBox_month.Text = "";
				textBox_year.Text = "";
			}
		}

		private void textBox_date_Click(object sender, EventArgs e)
		{
			if (textBox_day.Text == "" && textBox_month.Text == "" && textBox_year.Text == "")
			{
				this.date = DateTime.Today;
				refresh();
			}
		}

		public DateTime Date
		{
			get
			{
				int year = 1, month = 1, day = 1; 

				if (textBox_year.Text != "") { year = Convert.ToInt32(this.textBox_year.Text); }
				if (textBox_month.Text != "") { month = Convert.ToInt32(this.textBox_month.Text); }
				if (textBox_day.Text != "") { day = Convert.ToInt32(this.textBox_day.Text); }

				date = new DateTime (year, month, day);
				return date;
			}
			set
			{
				date = value;
				refresh();
			}
		}

		public bool IsEmpty
        {
            get
            {
                if (textBox_year.Text == "" && textBox_month.Text == "" && textBox_day.Text == "")
                {
					return true;
                }
                else
                {
					return false;
                }
            }
        }
	}
}
