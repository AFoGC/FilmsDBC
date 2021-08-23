using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsDBC.CinemaDataTypes.CellDataClasses;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual
{
	public partial class SourceControl : UserControl
	{
		private Source source = null;
		public SourceControl(Source source)
		{
			InitializeComponent();

			this.source = source;
			this.textBox_name.Text = source.name;
			this.textBox_url.Text = source.sourceUrl;
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
			SourcesVisualizer.SourcesControl.FlowLayoutPanel_sources.Controls.SetChildIndex(this, 0);
		}
	}
}
