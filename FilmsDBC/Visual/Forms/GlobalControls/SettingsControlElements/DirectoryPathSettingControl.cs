using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
{
    public partial class DirectoryPathSettingControl : UserControl, ISettingsControls
    {
        public DirectoryPathSettingControl()
        {
            InitializeComponent();
            clickButton_changeDirectory.SetDefaultButtonBlink();
        }

        public void RefreshControl()
        {
            //textBox_filePath.Text = MainInformation.Settings.TablePath;
        }
    }
}
