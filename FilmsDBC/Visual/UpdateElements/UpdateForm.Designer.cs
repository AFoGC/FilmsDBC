
namespace FilmsDBC.Visual.UpdateElements
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.button_update);
            this.panel_main.Controls.Add(this.pictureBox_Close);
            this.panel_main.Controls.Add(this.flowLayoutPanel_main);
            this.panel_main.Location = new System.Drawing.Point(1, 1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(940, 80);
            this.panel_main.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(3, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(90, 20);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Подтвердить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
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
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(940, 50);
            this.flowLayoutPanel_main.TabIndex = 0;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(942, 82);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.Button button_update;
    }
}