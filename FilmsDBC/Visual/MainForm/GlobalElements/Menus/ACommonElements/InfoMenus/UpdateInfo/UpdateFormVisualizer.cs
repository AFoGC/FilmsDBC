using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.MoreInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo.SourceVisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo
{
	public class UpdateFormVisualizer
	{
		private UpdateControl updateControl;
		public UpdateControl UpdateControl { get { return updateControl; } }
		private bool isOpen = false;
		public bool IsOpen { get { return isOpen; } }

		private SourcesVisualizer sourcesVisualizer;
		public SourcesVisualizer SourcesVisualizer
        {
			get { return sourcesVisualizer; }
        }

		private Control parentControl = null;
		public Control ParentControl
        {
            get { return parentControl; }
        }

		public UpdateFormVisualizer(Control parentControl)
		{
			this.parentControl = parentControl;
			this.sourcesVisualizer = new SourcesVisualizer(this);
			this.updateControl = new UpdateControl(this);
		}

		public void OpenUpdateControl(IControls userControl, MoreInfoFormVisualizer moreVisualizer)
		{
			updateControl.Reinitialize(userControl);
			parentControl.Controls.Add(updateControl);

            if (moreVisualizer.IsOpen)
			{
				moreVisualizer.HideMoreInfoControl();
			}
            if (sourcesVisualizer.IsOpen)
            {
				sourcesVisualizer.HideSourceControl();
            }

			isOpen = true;
		}

		public void HideUpdateControl()
        {
			isOpen = false;
			parentControl.Controls.Remove(updateControl);

            if (sourcesVisualizer.IsOpen)
            {
				sourcesVisualizer.HideSourceControl();
			}
        }
	}
}
