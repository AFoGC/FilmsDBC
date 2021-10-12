using FilmsDBC.DataAccessLayer.CinemaDataTypes;
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
    public partial class SourcesControl : UserControl
    {
        private List<Source> sources = null;
        public List<Source> Sources
        {
            get { return sources; }
        }

        public SourcesControl()
        {
            InitializeComponent();
            this.Location = new Point(940, 0);
        }

        public void Reinitialize(List<Source> sources)
        {
            this.sources = sources;

            flowLayoutPanel_sources.Controls.Clear();
            foreach (Source source in sources)
            {
                addElement(source);
            }
        }

        private void addElement(Source source)
        {
            flowLayoutPanel_sources.Controls.Add(new SourceControl(source, this));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            while (sources.Count != 0)
            {
                sources.Remove(sources[0]);
            }

            foreach (SourceControl sourceControl in flowLayoutPanel_sources.Controls)
            {
                sources.Add(sourceControl.Source);
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
