using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Controls
{
    public partial class SerieControl : UserControl
    {
        Serie serieInfo = null;
        Film filmInfo = null;
        public SerieControl(Film film, Serie serie)
        {
            InitializeComponent();
            this.serieInfo = serie;
            this.filmInfo = film;


        }
    }
}
