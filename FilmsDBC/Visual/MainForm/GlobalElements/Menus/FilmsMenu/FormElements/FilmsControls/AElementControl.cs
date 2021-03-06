using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AElementControl, UserControl>))]
	public abstract class AElementControl : UserControl, IFilmsControls
	{
		internal Film filmInfo = null;
		public Film FilmInfo
		{
			get { return filmInfo; }
		}

		internal void SetSelectedElement(AElementControl controlInBuffer)
		{
			if (controlInBuffer != null)
			{
				controlInBuffer.SetVisualDefault();
			}

			MainInfo.MainForm.MainControl.ControlInBuffer = this;
			setVisualSelected();
		}

		public bool SetFindedElement(String searchLine)
		{
			if (this.FilmInfo.Name.ToLowerInvariant().Contains(searchLine))
			{
				setVisualFinded();
				return true;
			}

			return false;
		}

		public abstract void SetVisualDefault();
		public abstract void RefreshData();
		public abstract Control ToUpdateControl();
		internal abstract void setVisualSelected();
		internal abstract void setVisualFinded();

		public bool HasSelectedGenre(Genre[] selectedGenres)
		{
			foreach (Genre genre in selectedGenres)
			{
				if (genre == filmInfo.Genre)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasWatchedProperty(bool isWached)
		{
            if (isWached == FilmInfo.Watched)
            {
				return true;
            }
            else
            {
				return false;
			}
		}
    }
}
