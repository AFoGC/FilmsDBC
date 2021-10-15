using FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu.FormElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu
{
    public partial class SettingsControl : UserControl
    {
        private ProfileSettingControl directoryPathSettingControl;
        public SettingsControl()
        {
            InitializeComponent();
            clickButton_embraceSettings.SetDefaultButtonBlink();

            directoryPathSettingControl = new ProfileSettingControl();

            RefreshControl();
            flowLayoutPanel_settings.Controls.Add(directoryPathSettingControl);
        }

        public void RefreshControl()
        {
            directoryPathSettingControl.RefreshControl();
        }

        private void clickButton_embraceSettings_Click(object sender, EventArgs e)
        {
            foreach (ISettingsControls setting in flowLayoutPanel_settings.Controls)
            {
                setting.GetSettings();
            }


            MainInfo.LoadTables();
        }
    }
}
