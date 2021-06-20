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
    public partial class CategoryControl : UserControl
    {
        Category categoryInfo = null;
        public CategoryControl(Category category)
        {
            InitializeComponent();
            this.categoryInfo = category;


        }
    }
}
