using FilmsDBC.DataAccessLayer.CinemaDataTypes.CellDataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo.SourceVisual
{
	public partial class SourceControl : UserControl
	{
		private SourcesControl sourcesControl;
		private Source source = null;
		public SourceControl(Source source, SourcesControl sourcesControl)
		{
			InitializeComponent();

			this.source = source;
			this.textBox_name.Text = source.name;
			this.textBox_url.Text = source.sourceUrl;
			this.sourcesControl = sourcesControl;
		}

		public Source Source
		{
			get
			{
				source.name = textBox_name.Text;
				source.sourceUrl = textBox_url.Text;
				return source;
			}
		}

		private void pictureBox_prioritize_Click(object sender, EventArgs e)
		{
			sourcesControl.FlowLayoutPanel_sources.Controls.SetChildIndex(this, 0);
		}
	}
}
