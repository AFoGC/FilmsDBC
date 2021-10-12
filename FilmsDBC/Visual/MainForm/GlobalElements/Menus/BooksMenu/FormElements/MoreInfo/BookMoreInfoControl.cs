using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.MoreInfo
{
    public partial class BookMoreInfoControl : UserControl
    {
        public BookMoreInfoControl()
        {
            InitializeComponent();
        }

        public void Reinitialize(ISimpleControl simpleControl)
        {
            flowLayoutPanel_main.Controls.Clear();
            flowLayoutPanel_main.Controls.Add(simpleControl.ToMoreInfo());
        }
    }
}
