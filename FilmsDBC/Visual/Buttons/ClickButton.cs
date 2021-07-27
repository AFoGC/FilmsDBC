using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Buttons
{
    public partial class ClickButton : Label
    {
        public ClickButton()
        {
            InitializeComponent();
        }

        private Color mouseEnterColor;
        private Color defaultColor;
        private Color mouseDownColor;

        public Color MouseEnterColor
        {
            get { return mouseEnterColor; }
            set { mouseEnterColor = value; }
        }
        public Color DefaultColor
        {
            get { return defaultColor; }
            set 
            {
                defaultColor = value;
                BackColor = value;
            }
        }
        public Color MouseDownColor
        {
            get { return mouseDownColor; }
            set { mouseDownColor = value; }
        }
        public void SetDefaultButtonBlink()
        {
            mouseEnterColor = Color.FromArgb(defaultColor.R + 15, defaultColor.G + 15, defaultColor.B + 15);
            mouseDownColor = Color.FromArgb(defaultColor.R - 10, defaultColor.G - 10, defaultColor.B - 10);
        }

        private void this_mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = this.mouseEnterColor;
        }

        private void this_mouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.defaultColor;
        }

        private void this_mouseDown(object sender, EventArgs e)
        {
            this.BackColor = this.mouseDownColor;
        }

        private void this_mouseUp(object sender, EventArgs e)
        {
            this.BackColor = this.mouseEnterColor;
        }
    }
}
