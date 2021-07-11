
namespace FilmsDBC.Visual.UpdateElements.UpdateControls.SourceVisual
{
    partial class SourcesForm
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
            this.flowLayoutPanel_sources = new System.Windows.Forms.FlowLayoutPanel();
            this.button_update = new System.Windows.Forms.Button();
            this.button_addElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_sources
            // 
            this.flowLayoutPanel_sources.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanel_sources.Name = "flowLayoutPanel_sources";
            this.flowLayoutPanel_sources.Size = new System.Drawing.Size(400, 20);
            this.flowLayoutPanel_sources.TabIndex = 0;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(0, 0);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(85, 20);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Подтвердить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_addElement
            // 
            this.button_addElement.Location = new System.Drawing.Point(85, 0);
            this.button_addElement.Name = "button_addElement";
            this.button_addElement.Size = new System.Drawing.Size(85, 20);
            this.button_addElement.TabIndex = 2;
            this.button_addElement.Text = "Добавить";
            this.button_addElement.UseVisualStyleBackColor = true;
            this.button_addElement.Click += new System.EventHandler(this.button_addElement_Click);
            // 
            // SourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 40);
            this.Controls.Add(this.button_addElement);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.flowLayoutPanel_sources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SourcesForm";
            this.Text = "SourcesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_sources;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_addElement;
    }
}