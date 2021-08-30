using FilmsDBC.Visual.Controls;
using FilmsDBC.Visual.UpdateElements.UpdateControls;
using FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements
{
    public partial class UpdateControl : UserControl
    {
        public UpdateControl()
        {
            InitializeComponent();
        }

		public void Reinitialize(IControls icontrol)
		{
			flowLayoutPanel_main.Controls.Clear();
			IControls control = null;

			if (icontrol.GetType() == typeof(SimpleControl))
			{
				SimpleControl cont = (SimpleControl)icontrol;
				FilmControl fcont = new FilmControl(cont.FilmInfo);
				fcont.simpleControl = (SimpleControl)icontrol;
				control = fcont;
			}
			else
			{
				control = icontrol;
			}

			if (control.GetType() == typeof(FilmControl))
			{
				FilmControl filmControl = (FilmControl)control;
				if (filmControl.FilmInfo.Genre.IsSerialGenre)
				{
					flowLayoutPanel_main.Controls.Add(new SerieUpdateControl(filmControl));
				}
				else
				{
					flowLayoutPanel_main.Controls.Add(new FilmUpdateControl(filmControl));
				}
				return;
			}
			if (control.GetType() == typeof(SerieControl))
			{
				flowLayoutPanel_main.Controls.Add(new SerieUpdateControl((SerieControl)control));
				return;
			}
			if (control.GetType() == typeof(CategoryControl))
			{
				flowLayoutPanel_main.Controls.Add(new CategoryUpdateControl((CategoryControl)control));
				return;
			}

			throw new Exception("Wrong type of control");
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			IUpdateControl control = (IUpdateControl)flowLayoutPanel_main.Controls[0];
			control.UpdateElement();
			MainInformation.tableCollection.saveTables();
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(this);
			SourcesVisualizer.HideSourceControl();
		}
	}
}
