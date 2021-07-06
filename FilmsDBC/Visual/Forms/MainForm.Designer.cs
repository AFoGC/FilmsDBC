
namespace FilmsDBC.Visual.Forms
{
    partial class MainForm
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
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ShowCategories = new System.Windows.Forms.Button();
            this.button_ShowFilms = new System.Windows.Forms.Button();
            this.button_ShowSeries = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_main.AutoScroll = true;
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(235, 78);
            this.flowLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(960, 527);
            this.flowLayoutPanel_main.TabIndex = 0;
            // 
            // button_ShowCategories
            // 
            this.button_ShowCategories.Location = new System.Drawing.Point(1346, 96);
            this.button_ShowCategories.Name = "button_ShowCategories";
            this.button_ShowCategories.Size = new System.Drawing.Size(111, 23);
            this.button_ShowCategories.TabIndex = 1;
            this.button_ShowCategories.Text = "Show Categories";
            this.button_ShowCategories.UseVisualStyleBackColor = true;
            this.button_ShowCategories.Click += new System.EventHandler(this.button_ShowCategories_Click);
            // 
            // button_ShowFilms
            // 
            this.button_ShowFilms.Location = new System.Drawing.Point(1346, 125);
            this.button_ShowFilms.Name = "button_ShowFilms";
            this.button_ShowFilms.Size = new System.Drawing.Size(111, 23);
            this.button_ShowFilms.TabIndex = 2;
            this.button_ShowFilms.Text = "Show Films";
            this.button_ShowFilms.UseVisualStyleBackColor = true;
            this.button_ShowFilms.Click += new System.EventHandler(this.button_ShowFilms_Click);
            // 
            // button_ShowSeries
            // 
            this.button_ShowSeries.Location = new System.Drawing.Point(1346, 154);
            this.button_ShowSeries.Name = "button_ShowSeries";
            this.button_ShowSeries.Size = new System.Drawing.Size(111, 23);
            this.button_ShowSeries.TabIndex = 3;
            this.button_ShowSeries.Text = "Show Series";
            this.button_ShowSeries.UseVisualStyleBackColor = true;
            this.button_ShowSeries.Click += new System.EventHandler(this.button_ShowSeries_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(235, 55);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(154, 20);
            this.textBox_Search.TabIndex = 4;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(395, 55);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 20);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1346, 55);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save Tables";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 608);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_ShowSeries);
            this.Controls.Add(this.button_ShowFilms);
            this.Controls.Add(this.button_ShowCategories);
            this.Controls.Add(this.flowLayoutPanel_main);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.Button button_ShowCategories;
        private System.Windows.Forms.Button button_ShowFilms;
        private System.Windows.Forms.Button button_ShowSeries;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_save;
    }
}