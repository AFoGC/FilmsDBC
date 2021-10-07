using FilmsDBC.Visual.Buttons;
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
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();

            pressButton_Main.SetDefaultButtonBlink();
            pressButton_Main.SetDefaultIncludedButtonBlink();
            pressButton_Settings.SetDefaultButtonBlink();
            pressButton_Settings.SetDefaultIncludedButtonBlink();
            pressButton_Books.SetDefaultButtonBlink();
            pressButton_Books.SetDefaultIncludedButtonBlink();

            pressButton_Main.Included = true;
        }

        private void pressButton_Main_Click(object sender, EventArgs e)
        {
            changeSelectedButton((PressButton)sender);
            MainInfo.MainForm.MainControl.BringToFront();
        }

        private void pressButton_Settings_Click(object sender, EventArgs e)
        {
            changeSelectedButton((PressButton)sender);
            MainInfo.MainForm.SettingsControl.RefreshControl();
            MainInfo.MainForm.SettingsControl.BringToFront();
        }

        private void pressButton_Books_Click(object sender, EventArgs e)
        {
            changeSelectedButton((PressButton)sender);
            MainInfo.MainForm.BooksControl.BringToFront();
        }

        private void changeSelectedButton(PressButton pressButton)
        {
            foreach (PressButton button in this.Controls)
            {
                if (pressButton == button)
                {
                    pressButton.Included = true;
                    pressButton.ClickLocked = true;
                }
                else
                {
                    button.ClickLocked = false;
                    button.Included = false;
                }
            }
        }
    }
}
