using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms
{
	public partial class WatchedRequestControl : UserControl
	{
		public WatchedRequestControl()
		{
			InitializeComponent();
		}

		private bool watchedIncluded = true;
		public bool WatchedIncluded
		{
			get { return watchedIncluded; }
			set
			{
				if (value)
				{
					label_requestWatched.BackColor = SystemColors.ControlDark;
				}
				else
				{
					label_requestWatched.BackColor = SystemColors.Control;
				}
				watchedIncluded = value;
			}
		}
		private bool unwatchedIncluded = true;
		public bool UnwatchedIncluded
		{
			get { return unwatchedIncluded; }
			set
			{
				if (value)
				{
					label_requestUnwatched.BackColor = SystemColors.ControlDark;
				}
				else
				{
					label_requestUnwatched.BackColor = SystemColors.Control;
				}
				unwatchedIncluded = value;
			}
		}


		private void label_requestWatched_Click(object sender, EventArgs e)
		{
			WatchedIncluded = !watchedIncluded;
		}

		private void label_requestUnwatched_Click(object sender, EventArgs e)
		{
			UnwatchedIncluded = !unwatchedIncluded;
		}
	}
}
