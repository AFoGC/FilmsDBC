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
    public partial class SourcesControl : UserControl
    {
        private Film film = null;
        public Film FilmInfo
        {
            get { return film; }
        }

        public SourcesControl()
        {
            InitializeComponent();
            this.Location = new Point(940, 0);
        }

        public void Reinitialize(Film film)
        {
            this.film = film;

            flowLayoutPanel_sources.Controls.Clear();
            foreach (Source source in film.Sources)
            {
                addElement(source);
            }
        }

        private void addElement(Source source)
        {
            flowLayoutPanel_sources.Controls.Add(new SourceControl(source));
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

        public FlowLayoutPanel FlowLayoutPanel_sources
        {
            get { return flowLayoutPanel_sources; }
        }
    }
}
