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
    public partial class MarkSystemSettingControl : UserControl
    {
        public MarkSystemSettingControl()
        {
            InitializeComponent();

            switch (MainInformation.Settings.MarkSystem)
            {
                case 3:
                    comboBox_marksSystem.Text = "3/3";
                    break;
                case 5:
                    comboBox_marksSystem.Text = "5/5";
                    break;
                case 6:
                    comboBox_marksSystem.Text = "6/5";
                    break;
                case 10:
                    comboBox_marksSystem.Text = "10/10";
                    break;
                case 100:
                    comboBox_marksSystem.Text = "100/100";
                    break;
            }
        }
    }
}
