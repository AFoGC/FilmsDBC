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

		public static void OpenUpdateForm(IControls userControl)
		{
			updateForm.Reinitialize(userControl);
			updateForm.Show();
		}
	}
}
