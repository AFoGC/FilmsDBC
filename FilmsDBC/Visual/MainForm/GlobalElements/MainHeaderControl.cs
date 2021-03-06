using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements
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
            MainInfo.MainForm.Close();
        }

        private void clickButton_maximize_Click(object sender, EventArgs e)
        {
            if (MainInfo.MainForm.WindowState != FormWindowState.Maximized)
            {
                MainInfo.MainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MainInfo.MainForm.WindowState = FormWindowState.Normal;
            }
        }

        private void clickButton_minimize_Click(object sender, EventArgs e)
        {
            MainInfo.MainForm.WindowState = FormWindowState.Minimized;
        }
        
    }
}
