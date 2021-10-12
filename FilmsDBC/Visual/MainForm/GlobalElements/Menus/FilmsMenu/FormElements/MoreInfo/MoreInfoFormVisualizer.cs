using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateInfo;
using FilmsDBC.Visual.UpdateElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.MoreInfo
{
	static class MoreInfoFormVisualizer
	{
		private static MoreInfoControl infoControl = new MoreInfoControl();
		public static MoreInfoControl MoreInfoControl
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

			if (UpdateFormVisualizer.IsOpen)
			{
				UpdateFormVisualizer.HideUpdateControl();
			}

			isOpen = true;
			
		}

		public static void HideMoreInfoControl()
        {
			isOpen = false;
			MainInfo.MainForm.BooksControl.InfoPanel.Controls.Remove(infoControl);
		}
	}
}
