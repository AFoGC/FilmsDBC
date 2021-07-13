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
		public static void OpenMoreInfoForm(Film film, SimpleControl simpleControl)
		{
			infoForm.Reinitialize(film, simpleControl);
			infoForm.Show();
		}
	}
}
