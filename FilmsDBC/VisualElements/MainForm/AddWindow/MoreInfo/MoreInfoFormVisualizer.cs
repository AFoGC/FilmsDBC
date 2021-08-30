using FilmsDBC.CinemaDataTypes;
using FilmsDBC.VisualElements.FilmControls;
using FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.VisualElements.MainForm.AddWindow.MoreInfo
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
		public static void OpenMoreInfoForm(Film film, SimpleControl simpleControl)
		{
			infoControl.Reinitialize(film, simpleControl);
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Add(infoControl);

			if (UpdateFormVisualizer.IsOpen)
			{
				UpdateFormVisualizer.HideUpdateControl();
			}

			isOpen = true;
		}

		public static void HideMoreInfoControl()
        {
			isOpen = false;
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(infoControl);
		}
	}
}
