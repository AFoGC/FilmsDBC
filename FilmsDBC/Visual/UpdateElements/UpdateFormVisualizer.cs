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

		public static void OpenMoreInfoForm(UserControl userControl)
		{
			updateForm.Reinitialize(userControl);
			updateForm.Show();
		}
	}
}
