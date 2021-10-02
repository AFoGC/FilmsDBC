using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.UpdateInfo
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
			flowLayoutPanel_main.Controls.Add(icontrol.ToUpdateControl());
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			IUpdateControl control = (IUpdateControl)flowLayoutPanel_main.Controls[0];
			control.UpdateElement();
			//MainInformation.tableCollection.saveTables();
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(this);
			SourcesVisualizer.HideSourceControl();
		}
	}
}
