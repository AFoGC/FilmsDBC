using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void GetSetting()
        {
            MainInformation.Settings.DirectoryPath = textBox_filePath.Text;
        }

        public void RefreshControl()
        {
            textBox_filePath.Text = MainInformation.Settings.DirectoryPath;
        }

        private void clickButton_changeDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox_filePath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
