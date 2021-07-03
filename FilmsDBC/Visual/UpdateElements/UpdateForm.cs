﻿using FilmsDBC.Visual.Controls;
using FilmsDBC.Visual.UpdateElements.UpdateControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.UpdateElements
{
	public partial class UpdateForm : Form
	{
		public UpdateForm()
		{
			InitializeComponent();
		}

		public void Reinitialize(UserControl control)
		{
			flowLayoutPanel_main.Controls.Clear();
			if (control.GetType() == typeof(FilmControl))
			{
				flowLayoutPanel_main.Controls.Add(new FilmUpdateControl((FilmControl)control));
				return;
			}
			if (control.GetType() == typeof(SerieControl))
			{
				flowLayoutPanel_main.Controls.Add(new SerieUpdateControl((SerieControl)control));
				return;
			}
			if (control.GetType() == typeof(CategoryControl))
			{
				flowLayoutPanel_main.Controls.Add(new CategoryUpdateControl((CategoryControl)control));
				return;
			}

			throw new Exception("Wrong type of control");
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			Control userControl = flowLayoutPanel_main.Controls[0];
			if (userControl.GetType() == typeof(FilmUpdateControl))
			{
				FilmUpdateControl control = (FilmUpdateControl)userControl;
				control.UpdateElement();
				return;
			}
			if (userControl.GetType() == typeof(SerieUpdateControl))
			{
				SerieUpdateControl control = (SerieUpdateControl)userControl;
				control.UpdateElement();
				return;
			}
			if (userControl.GetType() == typeof(CategoryUpdateControl))
			{

				return;
			}
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		Point lastPoint = new Point();
		private void panel_main_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void panel_main_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
	}
}
