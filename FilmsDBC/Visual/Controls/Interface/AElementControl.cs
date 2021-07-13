using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Controls
{
	[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AElementControl, UserControl>))]
	public abstract class AElementControl : UserControl, IControls
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
				controlInBuffer.SetDefaultVisualCondition();
			}

			MainInformation.MainForm.ControlInBuffer = this;
			setVisualSelected();
		}

		public bool SetFindedElement(String searchLine)
        {
			if (this.FilmInfo.Name.Contains(searchLine))
			{
				setVisualFinded();
				return true;
			}

			return false;
		}

		public abstract void SetDefaultVisualCondition();
		internal abstract void setVisualSelected();
		internal abstract void setVisualFinded();
		public abstract void RefreshData();
    }
}
