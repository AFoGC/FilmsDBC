using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual
{
    public static class SourcesVisualizer
	{
		private static SourcesControl sourcesControl = new SourcesControl();
		public static SourcesControl SourcesControl
        {
            get { return sourcesControl; }
        }

		public static void OpenSourceControl(Film film)
        {
			sourcesControl.Reinitialize(film);
			MainInfo.MainForm.MainControl.InfoPanel.Controls.Add(sourcesControl);
            if (isOpen == false)
            {
				System.Drawing.Size size = MainInfo.MainForm.MainControl.InfoPanel.Size;
				size.Width += 420;
				MainInfo.MainForm.MainControl.InfoPanel.Size = size;
			}
			isOpen = true;
		}

		public static void HideSourceControl()
        {
			MainInfo.MainForm.MainControl.InfoPanel.Controls.Remove(sourcesControl);
            if (isOpen == true)
            {
				System.Drawing.Size size = MainInfo.MainForm.MainControl.InfoPanel.Size;
				size.Width -= 420;
				MainInfo.MainForm.MainControl.InfoPanel.Size = size;
			}
			isOpen = false;
        }

		private static bool isOpen = false;
		public static bool IsOpen
		{
			get { return isOpen; }
		}
	}
}
