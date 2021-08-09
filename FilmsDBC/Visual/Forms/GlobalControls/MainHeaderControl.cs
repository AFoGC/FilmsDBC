using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms.GlobalControls
{
    public partial class MainHeaderControl : UserControl
    {
        public MainHeaderControl()
        {
            InitializeComponent();

            clickButton_maximize.SetDefaultButtonBlink();
            clickButton_minimize.SetDefaultButtonBlink();
            clickButton_close.SetDefaultButtonBlink();
        }

        private void clickButton_close_Click(object sender, EventArgs e)
        {
            MainInformation.MainForm.Close();
        }

        private void clickButton_maximize_Click(object sender, EventArgs e)
        {
            MainInformation.MainForm.MaximizeBox = !MainInformation.MainForm.MaximizeBox;
        }

        private void clickButton_minimize_Click(object sender, EventArgs e)
        {
            MainInformation.MainForm.MinimizeBox = true;
        }
    }
}
