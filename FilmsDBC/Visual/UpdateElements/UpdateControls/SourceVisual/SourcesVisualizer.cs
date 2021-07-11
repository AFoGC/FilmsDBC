using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual
{
	public static class SourcesVisualizer
	{
		private static SourcesForm sourcesForm = new SourcesForm();
		public static SourcesForm SourcesForm
        {
            get { return sourcesForm; }
        }
		public static void OpenSourceForm(Film film)
        {
			sourcesForm.Reinitialize(film);
			sourcesForm.Show();
        }
	}
}
