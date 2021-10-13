using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCDesignTest.FilmsControls;

namespace UCDesignTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new FilmControl());
            flowLayoutPanel1.Controls.Add(new FilmControl());
            flowLayoutPanel1.Controls.Add(new FilmControl());
            flowLayoutPanel1.Controls.Add(new FilmControl());
            flowLayoutPanel1.Controls.Add(new FilmControl());
        }
    }
}
