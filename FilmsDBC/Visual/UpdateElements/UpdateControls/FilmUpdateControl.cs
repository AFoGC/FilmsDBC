﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
    public partial class FilmUpdateControl : UserControl
    {
        UserControl userControl = null;
        public FilmUpdateControl(UserControl userControl)
        {
            InitializeComponent();
            this.userControl = userControl;
        }
    }
}