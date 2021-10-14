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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.MenuElements
{
	public partial class WatchedRequestControl : UserControl
	{
		public WatchedRequestControl()
		{
			InitializeComponent();
			label_requestUnwatched.SetDefaultButtonBlink();
			label_requestUnwatched.SetDefaultIncludedButtonBlink();
			label_requestWatched.SetDefaultButtonBlink();
			label_requestWatched.SetDefaultIncludedButtonBlink();
		}

		public PressButton PressButtonWatched
        {
            get { return label_requestWatched; }
        }

		public PressButton PressButtonUnwatched
        {
            get { return label_requestUnwatched; }
        }

		public bool IsWatched
		{
            get { return label_requestWatched.Included; }
			set { label_requestWatched.Included = value; }
		}

		public bool IsUnwatched
        {
            get { return label_requestUnwatched.Included; }
            set { label_requestUnwatched.Included = value; }
        }

		public bool IsAllIncluded
        {
            get
            {
                if (label_requestWatched.Included && label_requestUnwatched.Included)
                {
					return true;
                }
                else
                {
					return false;
				}
            }
        }
	}
}
