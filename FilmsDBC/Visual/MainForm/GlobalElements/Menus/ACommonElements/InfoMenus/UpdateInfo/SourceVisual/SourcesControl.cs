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
        private List<Source> exportSources = null;
        public List<Source> ExportSources
        {
            get { return exportSources; }
        }

        public SourcesControl()
        {
            InitializeComponent();
            this.Location = new Point(940, 0);
            sources = new List<Source>();
        }

        public void Reinitialize(List<Source> exportSources)
        {
            this.exportSources = exportSources;
            flowLayoutPanel_sources.Controls.Clear();
            while (sources.Count != 0)
            {
                sources.Remove(this.sources[0]);
            }

            foreach (Source source in exportSources)
            {
                sources.Add(source);
                addElement(source);
            }
        }

        private void addElement(Source source)
        {
            flowLayoutPanel_sources.Controls.Add(new SourceControl(source, this));
        }

        public void button_update_Click(object sender, EventArgs e)
        {
            while (exportSources.Count != 0)
            {
                sources.Remove(sources[0]);
            }

            foreach (SourceControl sourceControl in flowLayoutPanel_sources.Controls)
            {
                exportSources.Add(sourceControl.Source);
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
