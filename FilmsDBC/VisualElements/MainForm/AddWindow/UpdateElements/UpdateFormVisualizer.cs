using FilmsDBC.VisualElements.FilmControls.Interface;
using FilmsDBC.VisualElements.MainForm.AddWindow.MoreInfo;
using FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements.UpdateControls.SourceVisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements
{
	static class UpdateFormVisualizer
	{
		private static UpdateControl updateControl = new UpdateControl();
		public static UpdateControl UpdateControl { get { return updateControl; } }
		private static bool isOpen = false;
		public static bool IsOpen { get { return isOpen; } }

		public static void OpenUpdateControl(IControls userControl)
		{
			updateControl.Reinitialize(userControl);
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Add(updateControl);

            if (MoreInfoFormVisualizer.IsOpen)
			{
				MoreInfoFormVisualizer.HideMoreInfoControl();
			}
            if (SourcesVisualizer.IsOpen)
            {
				SourcesVisualizer.HideSourceControl();
            }

			isOpen = true;
		}

		public static void HideUpdateControl()
        {
			isOpen = false;
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(updateControl);

            if (SourcesVisualizer.IsOpen)
            {
				SourcesVisualizer.HideSourceControl();
			}
        }
	}
}
