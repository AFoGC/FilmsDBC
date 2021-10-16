
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo.SourceVisual
{
    partial class SourceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.pictureBox_prioritize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prioritize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(0, 0);
            this.textBox_name.MaxLength = 13;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_url
            // 
            this.textBox_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_url.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_url.Location = new System.Drawing.Point(100, 0);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(250, 20);
            this.textBox_url.TabIndex = 1;
            // 
            // pictureBox_prioritize
            // 
            this.pictureBox_prioritize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox_prioritize.Location = new System.Drawing.Point(365, 0);
            this.pictureBox_prioritize.Name = "pictureBox_prioritize";
            this.pictureBox_prioritize.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_prioritize.TabIndex = 2;
            this.pictureBox_prioritize.TabStop = false;
            this.pictureBox_prioritize.Click += new System.EventHandler(this.pictureBox_prioritize_Click);
            // 
            // SourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pictureBox_prioritize);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_name);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SourceControl";
            this.Size = new System.Drawing.Size(400, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prioritize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.PictureBox pictureBox_prioritize;
    }
}
