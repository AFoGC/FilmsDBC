using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.HelpForms.ExitForm
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
            Save = false;
            CloseProg = false;
        }

        public Boolean Save { get; private set; }
        public Boolean CloseProg { get; private set; }

        private void ExitForm_Paint(object sender, PaintEventArgs e)
        {
            var rectIcon = new Rectangle(0, 0, Width - 1, Height - 1);
            Graphics graph = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.WhiteSmoke, 1))
            {
                graph.SmoothingMode = SmoothingMode.None;
                path.AddRectangle(rectIcon);
                graph.DrawPath(pen, path);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Save = true;
            CloseProg = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_DontSave_Click(object sender, EventArgs e)
        {
            CloseProg = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ExitForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
