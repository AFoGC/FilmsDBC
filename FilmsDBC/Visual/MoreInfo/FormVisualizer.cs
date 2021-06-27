using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.MoreInfo
{
	static class FormVisualizer
	{
		private static MoreInfoForm infoForm = new MoreInfoForm();
		public static void OpenMoreInfoForm(Film film)
		{
			infoForm.Reinitialize(film);
			infoForm.Show();

			//Надо сделать собственую реализацию дизайна формы, в особености кнопки закрытия,
			//которая реализовывала бы метод infoForm.Hide();
		}
	}
}
