using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Controls
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AElementControl, UserControl>))]
    public abstract class AElementControl : UserControl, IControls
    {
        internal Film filmInfo = null;
        public Film FilmInfo
        {
            get { return filmInfo; }
        }

        public abstract void ChangeColorToSearch();
        public abstract void ChangeColorToSelect();
    }
}
