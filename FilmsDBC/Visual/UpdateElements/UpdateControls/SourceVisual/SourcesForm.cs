using FilmsDBC.CinemaDataTypes;
using FilmsDBC.CinemaDataTypes.CellDataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual
{
	public partial class SourcesForm : Form
	{
		private Film film = null;
		public Film FilmInfo
		{
			get { return film; }
		}
		public SourcesForm()
		{
			InitializeComponent();
			defaultSize = this.Size;
			defaultPanelSize = flowLayoutPanel_sources.Size;
		}

		Size defaultPanelSize;
		Size defaultSize;

		public void Reinitialize(Film film)
		{
			this.film = film;
			this.Size = defaultSize;
			flowLayoutPanel_sources.Size = defaultPanelSize;

			flowLayoutPanel_sources.Controls.Clear();
			foreach (Source source in film.Sources)
			{
				addElement(source);
			}

		}

		private void addElement(Source source)
		{
			Size size = this.Size;
			Size panelSize = flowLayoutPanel_sources.Size;

			size.Height += 20;
			panelSize.Height += 20;
			flowLayoutPanel_sources.Controls.Add(new SourceControl(source));

			this.Size = size;
			flowLayoutPanel_sources.Size = panelSize;
		}

		public FlowLayoutPanel FlowLayoutPanel_sources
		{
			get { return flowLayoutPanel_sources; }
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			film.Sources = new List<Source>();

			foreach (SourceControl sourceControl in flowLayoutPanel_sources.Controls)
			{
				film.Sources.Add(sourceControl.Source);
			}
		}

		private void button_addElement_Click(object sender, EventArgs e)
		{
			addElement(new Source());
		}

		Point lastPoint = new Point();
		private void SourcesForm_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void SourcesForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
	}
}
