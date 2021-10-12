using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.DataAccessLayer.CinemaDataTypes.CellDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo.SourceVisual
{
    public class SourcesVisualizer
	{
		private SourcesControl sourcesControl = new SourcesControl();
		public SourcesControl SourcesControl
        {
            get { return sourcesControl; }
        }
		private bool isOpen = false;
		public bool IsOpen
		{
			get { return isOpen; }
		}
		private UpdateFormVisualizer updateVisualizer = null;
		public SourcesVisualizer(UpdateFormVisualizer updateVisualizer)
		{
			this.updateVisualizer = updateVisualizer;
		}

		public void OpenSourceControl(List<Source> sources)
        {
			sourcesControl.Reinitialize(sources);
			updateVisualizer.ParentControl.Controls.Add(sourcesControl);
            if (isOpen == false)
            {
				System.Drawing.Size size = updateVisualizer.ParentControl.Size;
				size.Width += 420;
				updateVisualizer.ParentControl.Size = size;
			}
			isOpen = true;
		}

		public void HideSourceControl()
        {
			updateVisualizer.ParentControl.Controls.Remove(sourcesControl);
            if (isOpen == true)
            {
				System.Drawing.Size size = updateVisualizer.ParentControl.Size;
				size.Width -= 420;
				updateVisualizer.ParentControl.Size = size;
			}
			isOpen = false;
        }
	}
}
