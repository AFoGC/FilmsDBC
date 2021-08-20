using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Controls;
using FilmsDBC.Visual.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MoreInfo
{
	static class MoreInfoFormVisualizer
	{
		private static MoreInfoForm infoForm = new MoreInfoForm();
		public static MoreInfoForm MoreInfoForm
        {
            get { return infoForm; }
        }

		private static bool isOpen = false;
		public static bool IsOpen
        {
            get { return isOpen; }
        }
		public static void OpenMoreInfoForm(Film film, SimpleControl simpleControl)
		{
			infoForm.Reinitialize(film, simpleControl);
			infoForm.Show();
			isOpen = true;
		}

		public static void HideMoreInfoForm()
        {
			isOpen = false;
			infoForm.Hide();
        }
	}
}
