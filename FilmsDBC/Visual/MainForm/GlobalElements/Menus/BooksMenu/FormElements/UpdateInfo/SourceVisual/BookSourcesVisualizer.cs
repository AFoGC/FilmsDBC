using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateInfo.SourceVisual
{
    public static class BookSourcesVisualizer
    {
		public static void OpenSourceControl(Book book)
		{
			/*
			sourcesControl.Reinitialize(film);
			MainInfo.MainForm.MainControl.InfoPanel.Controls.Add(sourcesControl);
			if (isOpen == false)
			{
				System.Drawing.Size size = MainInfo.MainForm.BooksControl.InfoPanel.Size;
				size.Width += 420;
				MainInfo.MainForm.MainControl.InfoPanel.Size = size;
			}
			isOpen = true;
			*/
		}

		public static void HideSourceControl()
		{
			/*
			MainInfo.MainForm.MainControl.InfoPanel.Controls.Remove(sourcesControl);
			if (isOpen == true)
			{
				System.Drawing.Size size = MainInfo.MainForm.BooksControl.InfoPanel.Size;
				size.Width -= 420;
				MainInfo.MainForm.MainControl.InfoPanel.Size = size;
			}
			isOpen = false;
			*/
		}

		private static bool isOpen = false;
		public static bool IsOpen
		{
			get { return isOpen; }
		}
	}
}
