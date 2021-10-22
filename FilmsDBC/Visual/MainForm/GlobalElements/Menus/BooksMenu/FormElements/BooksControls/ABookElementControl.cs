using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls
{
	[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<ABookElementControl, UserControl>))]
	public abstract class ABookElementControl : UserControl, IBooksControls
	{
		internal Book bookInfo = null;
		public Book BookInfo
        {
            get { return bookInfo; }
        }
		
		internal void SetSelectedElement(ABookElementControl controlInBuffer)
		{
			if (controlInBuffer != null)
			{
				controlInBuffer.SetVisualDefault();
			}

			MainInfo.MainForm.BooksControl.ControlInBuffer = this;
			setVisualSelected();
		}
		

		public bool SetFindedElement(string search)
		{
			if (this.BookInfo.Name.ToLowerInvariant().Contains(search))
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
	}
}
