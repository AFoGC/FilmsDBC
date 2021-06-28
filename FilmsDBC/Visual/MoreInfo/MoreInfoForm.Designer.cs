
namespace FilmsDBC.Visual.MoreInfo
{
    partial class MoreInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreInfoForm));
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(940, 50);
            this.flowLayoutPanel_main.TabIndex = 0;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.InitialImage")));
            this.pictureBox_Close.Location = new System.Drawing.Point(917, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 1;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.pictureBox_Close);
            this.panel_main.Controls.Add(this.flowLayoutPanel_main);
            this.panel_main.Location = new System.Drawing.Point(1, 1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(940, 80);
            this.panel_main.TabIndex = 2;
            this.panel_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            this.panel_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseMove);
            // 
            // MoreInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(942, 82);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Panel panel_main;
    }
}