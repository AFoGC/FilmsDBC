using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.MoreInfo
{
	public class MoreInfoFormVisualizer
	{

		private MoreInfoControl infoControl = new MoreInfoControl();
		public MoreInfoControl MoreInfoControl
		{
            get { return infoControl; }
        }

		private bool isOpen = false;
		public bool IsOpen
        {
            get { return isOpen; }
        }

		private Control parentControl = null;
		public MoreInfoFormVisualizer(Control parentControl)
		{
			this.parentControl = parentControl;
		}

		public void OpenMoreInfoForm(ISimpleControl simpleControl, UpdateFormVisualizer updateVisualizer)
		{
			infoControl.Reinitialize(simpleControl);
			parentControl.Controls.Add(infoControl);

			if (updateVisualizer.IsOpen)
			{
				updateVisualizer.HideUpdateControl();
			}

			isOpen = true;
			
		}

		public void HideMoreInfoControl()
        {
			isOpen = false;
			parentControl.Controls.Remove(infoControl);
		}
	}
}
