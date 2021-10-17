using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.HelpForms.ExitForm;
using FilmsDBC.Visual.MainForm.GlobalElements;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu;
using FilmsDBC.Visual.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablesLibrary.Interpreter;

namespace FilmsDBC.Visual.MainForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.FormClosing += new FormClosingEventHandler(openExitForm);
		}

		private void openExitForm(object sender, FormClosingEventArgs e)
        {
			using (ExitForm exitForm = new ExitForm())
            {
                if (exitForm.ShowDialog() == DialogResult.OK)
                {
                    if (exitForm.Save == true)
                    {
						MainInfo.TableCollection.SaveTables();
                    }

					e.Cancel = !exitForm.CloseProg;
                }
            }
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


		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void mainHeaderControl_MouseDown(object sender, MouseEventArgs e)
        {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}
