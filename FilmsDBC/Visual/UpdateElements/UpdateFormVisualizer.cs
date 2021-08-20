using FilmsDBC.Visual.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.UpdateElements
{
	static class UpdateFormVisualizer
	{
		private static UpdateForm updateForm = new UpdateForm();
		public static UpdateForm UpdateForm { get { return updateForm; } }
		private static bool isOpen = false;
		public static bool IsOpen { get { return isOpen; } }

		public static void OpenUpdateForm(IControls userControl)
		{
			updateForm.Reinitialize(userControl);
			updateForm.Show();
			isOpen = true;
		}

		public static void HideUpdateForm()
        {
			updateForm.Hide();
			isOpen = false;
        }
	}
}
