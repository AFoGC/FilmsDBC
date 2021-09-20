using FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms.GlobalControls
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


            MainInformation.LoadTables();
            MainInformation.MainForm.MainControl.loadCategories();
            MainInformation.MainForm.MainControl.loadGenres();
        }
    }
}
