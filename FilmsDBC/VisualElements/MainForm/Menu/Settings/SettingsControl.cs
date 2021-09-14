﻿using FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.VisualElements.MainForm.Menu.Settings
{
    public partial class SettingsControl : UserControl
    {
        private DirectoryPathSettingControl directoryPathSettingControl;
        public SettingsControl()
        {
            InitializeComponent();

            directoryPathSettingControl = new DirectoryPathSettingControl();

            RefreshControl();
            flowLayoutPanel_settings.Controls.Add(directoryPathSettingControl);
        }

        public void RefreshControl()
        {
            directoryPathSettingControl.RefreshControl();
        }
    }
}