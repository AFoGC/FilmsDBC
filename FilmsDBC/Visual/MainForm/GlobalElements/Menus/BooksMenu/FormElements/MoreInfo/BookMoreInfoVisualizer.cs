using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.MoreInfo
{
    public static class BookMoreInfoVisualizer
    {
		private static BookMoreInfoControl infoControl = new BookMoreInfoControl();
		public static BookMoreInfoControl MoreInfoControl
		{
			get { return infoControl; }
		}

		private static bool isOpen = false;
		public static bool IsOpen
		{
			get { return isOpen; }
		}

		
		public static void OpenMoreInfoForm(ISimpleControl simpleControl)
		{
			infoControl.Reinitialize(simpleControl);
			MainInfo.MainForm.BooksControl.InfoPanel.Controls.Add(infoControl);

			if (BookUpdateFormVisualizer.IsOpen)
			{
				BookUpdateFormVisualizer.HideUpdateControl();
			}

			isOpen = true;

		}

		public static void HideMoreInfoControl()
		{
			isOpen = false;
			MainInfo.MainForm.MainControl.InfoPanel.Controls.Remove(infoControl);
		}
		
		
	}
}
