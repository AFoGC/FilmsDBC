using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.StaticVisualClasses;
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

            this.textBox_id.Text = categoryInfo.ID.ToString();
            this.textBox_name.Text = category.Name;
            this.textBox_mark.Text = VisualHelper.markToText(Category.formatToString(category.Mark));

            //Add controls to Control
        }
    }
}
