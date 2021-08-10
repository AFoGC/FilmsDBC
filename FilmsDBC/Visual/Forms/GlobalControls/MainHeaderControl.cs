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
            if (MainInformation.MainForm.WindowState != FormWindowState.Maximized)
            {
                MainInformation.MainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MainInformation.MainForm.WindowState = FormWindowState.Normal;
            }
        }

        private void clickButton_minimize_Click(object sender, EventArgs e)
        {
            MainInformation.MainForm.WindowState = FormWindowState.Minimized;
        }

        
        private Point lastPoint;
        private void MainHeaderControl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MainHeaderControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainInformation.MainForm.Left += e.X - lastPoint.X;
                MainInformation.MainForm.Top += e.Y - lastPoint.Y;
            }
        }
        
    }
}
