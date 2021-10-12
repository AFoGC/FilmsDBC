using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.MoreInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateInfo.SourceVisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateInfo
{
    public static class BookUpdateFormVisualizer
    {
		private static BooksUpdateControl updateControl = new BooksUpdateControl();
		public static BooksUpdateControl UpdateControl { get { return updateControl; } }
		private static bool isOpen = false;
		public static bool IsOpen { get { return isOpen; } }

		public static void OpenUpdateControl(IControls userControl)
		{
			updateControl.Reinitialize(userControl);
			MainInfo.MainForm.BooksControl.InfoPanel.Controls.Add(updateControl);

			if (BookMoreInfoVisualizer.IsOpen)
			{
				BookMoreInfoVisualizer.HideMoreInfoControl();
			}
			if (BookSourcesVisualizer.IsOpen)
			{
				BookSourcesVisualizer.HideSourceControl();
			}

			isOpen = true;
		}

		public static void HideUpdateControl()
		{
			isOpen = false;
			MainInfo.MainForm.BooksControl.InfoPanel.Controls.Remove(updateControl);

			if (BookSourcesVisualizer.IsOpen)
			{
				BookSourcesVisualizer.HideSourceControl();
			}
		}
	}
}
