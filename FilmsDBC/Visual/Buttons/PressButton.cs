using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Buttons
{
    public partial class PressButton : Label
    {
        public PressButton()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(this.this_Click);
        }

        private bool included = false;
        public bool Included
        {
            get { return included; }
            set
            {
                if (included)
                {
                    this.MouseEnter -= new EventHandler(this.this_Included_mouseEnter);
                    this.MouseLeave -= new EventHandler(this.this_Included_mouseLeave);
                    this.MouseDown -= new MouseEventHandler(this.this_Included_mouseDown);
                    this.Click -= new EventHandler(this.this_Included_mouseUp);
                }
                else
                {
                    this.MouseEnter -= new EventHandler(this.this_NotIncluded_mouseEnter);
                    this.MouseLeave -= new EventHandler(this.this_NotIncluded_mouseLeave);
                    this.MouseDown -= new MouseEventHandler(this.this_NotIncluded_mouseDown);
                    this.Click -= new EventHandler(this.this_NotIncluded_mouseUp);
                }

                included = value;
                if (included)
                {
                    BackColor = included_defaultColor;
                    this.MouseEnter += new EventHandler(this.this_Included_mouseEnter);
                    this.MouseLeave += new EventHandler(this.this_Included_mouseLeave);
                    this.MouseDown += new MouseEventHandler(this.this_Included_mouseDown);
                    this.Click += new EventHandler(this.this_Included_mouseUp);
                }
                else
                {
                    BackColor = defaultColor;
                    this.MouseEnter += new EventHandler(this.this_NotIncluded_mouseEnter);
                    this.MouseLeave += new EventHandler(this.this_NotIncluded_mouseLeave);
                    this.MouseDown += new MouseEventHandler(this.this_NotIncluded_mouseDown);
                    this.Click += new EventHandler(this.this_NotIncluded_mouseUp);
                }
            }
        }

        private bool clickLocked = false;
        public bool ClickLocked
        {
            get { return clickLocked; }
            set
            {
                if (!clickLocked)
                {
                    this.MouseClick -= new MouseEventHandler(this.this_Click);
                }

                clickLocked = value;

                if (clickLocked)
                {
                    this.MouseClick -= new MouseEventHandler(this.this_Click);
                }
                else
                {
                    this.MouseClick += new MouseEventHandler(this.this_Click);
                }
            }
        }

        private Color included_mouseEnterColor;
        private Color included_defaultColor;
        private Color included_mouseDownColor;
        private Color mouseEnterColor;
        private Color defaultColor;
        private Color mouseDownColor;

        public void SetDefaultButtonBlink()
        {
            mouseEnterColor = Color.FromArgb(defaultColor.R + 15, defaultColor.G + 15, defaultColor.B + 15);
            mouseDownColor = Color.FromArgb(defaultColor.R - 10, defaultColor.G - 10, defaultColor.B - 10);
        }
        public void SetDefaultIncludedButtonBlink()
        {
            included_mouseEnterColor = Color.FromArgb(included_defaultColor.R + 15, included_defaultColor.G + 15, included_defaultColor.B + 15);
            included_mouseDownColor = Color.FromArgb(included_defaultColor.R - 10, included_defaultColor.G - 10, included_defaultColor.B - 10);
        }

        public Color Included_MouseEnterColor
        {
            get { return included_mouseEnterColor; }
            set { included_mouseEnterColor = value; }
        }
        public Color Included_DefaultColor
        {
            get { return included_defaultColor; }
            set 
            {
                included_defaultColor = value;
            }
        }
        public Color Included_MouseDownColor
        {
            get { return included_mouseDownColor; }
            set { included_mouseDownColor = value; }
        }

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

        private void this_Included_mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = this.included_mouseEnterColor;
        }
        private void this_NotIncluded_mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = this.mouseEnterColor;
        }

        private void this_Included_mouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.included_defaultColor;
        }
        private void this_NotIncluded_mouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.defaultColor;
        }

        private void this_Included_mouseDown(object sender, EventArgs e)
        {
            this.BackColor = this.included_mouseDownColor;
        }
        private void this_NotIncluded_mouseDown(object sender, EventArgs e)
        {
            this.BackColor = this.mouseDownColor;
        }

        private void this_Included_mouseUp(object sender, EventArgs e)
        {
            this.BackColor = this.included_mouseDownColor;
        }
        private void this_NotIncluded_mouseUp(object sender, EventArgs e)
        {
            this.BackColor = this.mouseDownColor;
        }

        private void this_Click(object sender, EventArgs e)
        {
            this.Included = !this.Included;

            if (Included)
            {
                this.BackColor = this.included_mouseEnterColor;
            }
            else
            {
                this.BackColor = this.mouseEnterColor;
            }
        }
    }
}
