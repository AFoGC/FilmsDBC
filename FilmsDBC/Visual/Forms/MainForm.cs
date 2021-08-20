using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.Controls;
using FilmsDBC.Visual.Forms.GlobalControls;
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
using TablesLibrary.Interpreter;

namespace FilmsDBC.Visual.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public MainControl MainControl
		{
			get { return mainControl; }
		}

		public SettingsControl SettingsControl
		{
			get { return settingsControl; }
		}

		public BooksControl BooksControl
		{
			get { return booksControl; }
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{
			/*
            if (MoreInfo.MoreInfoFormVisualizer.IsOpen)
            {
				//MoreInfo.MoreInfoFormVisualizer.MoreInfoForm.Activate();
				MoreInfo.MoreInfoFormVisualizer.MoreInfoForm.BringToFront();
			}
            if (UpdateElements.UpdateFormVisualizer.IsOpen)
            {
				//UpdateElements.UpdateFormVisualizer.UpdateForm.Activate();
            }
			*/
		}
	}
}
