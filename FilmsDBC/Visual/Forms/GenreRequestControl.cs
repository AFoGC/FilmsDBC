﻿using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms
{
    public partial class GenreRequestControl : UserControl
    {
        Genre genre = null;
        public GenreRequestControl()
        {
            InitializeComponent();
        }
    }
}
