using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls;
using FilmsDBC.Visual.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.MoreInfo
{
    public partial class MoreInfoControl : UserControl
    {
        public MoreInfoControl()
        {
            InitializeComponent();
        }

		public void Reinitialize(ISimpleControl simpleControl)
		{
			flowLayoutPanel_main.Controls.Clear();
			flowLayoutPanel_main.Controls.Add(simpleControl.ToMoreInfo());
		}

		private void pictureBox_Close_Click(object sender, EventArgs e)
		{
			MainInformation.MainForm.MainControl.InfoPanel.Controls.Remove(this);
		}
	}
}
