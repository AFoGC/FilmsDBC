
using System;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls
{
    partial class BookSimpleControl
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
            this.components = new System.ComponentModel.Container();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_readed = new System.Windows.Forms.CheckBox();
            this.clickButton_info = new FilmsDBC.Visual.Buttons.ClickButton();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.Location = new System.Drawing.Point(2, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(27, 13);
            this.textBox_id.TabIndex = 2;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(31, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(178, 13);
            this.textBox_name.TabIndex = 16;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_genre
            // 
            this.textBox_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_genre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_genre.Location = new System.Drawing.Point(211, 1);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.ReadOnly = true;
            this.textBox_genre.Size = new System.Drawing.Size(98, 13);
            this.textBox_genre.TabIndex = 26;
            this.toolTip_description.SetToolTip(this.textBox_genre, "genre");
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_realiseYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_realiseYear.Location = new System.Drawing.Point(311, 1);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.ReadOnly = true;
            this.textBox_realiseYear.Size = new System.Drawing.Size(28, 13);
            this.textBox_realiseYear.TabIndex = 27;
            this.toolTip_description.SetToolTip(this.textBox_realiseYear, "realise year");
            // 
            // checkBox_readed
            // 
            this.checkBox_readed.AutoSize = true;
            this.checkBox_readed.Location = new System.Drawing.Point(360, 1);
            this.checkBox_readed.Name = "checkBox_readed";
            this.checkBox_readed.Size = new System.Drawing.Size(15, 14);
            this.checkBox_readed.TabIndex = 28;
            this.toolTip_description.SetToolTip(this.checkBox_readed, "is watched");
            this.checkBox_readed.UseVisualStyleBackColor = true;
            this.checkBox_readed.Click += new System.EventHandler(this.checkBox_readed_Click);
            // 
            // clickButton_info
            // 
            this.clickButton_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_info.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_info.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clickButton_info.Location = new System.Drawing.Point(395, 1);
            this.clickButton_info.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_info.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_info.Name = "clickButton_info";
            this.clickButton_info.Size = new System.Drawing.Size(110, 13);
            this.clickButton_info.TabIndex = 40;
            this.clickButton_info.Text = "More Info";
            this.clickButton_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_description.SetToolTip(this.clickButton_info, "open more info menu");
            this.clickButton_info.Click += new System.EventHandler(this.clickButton_info_Click);
            // 
            // BookSimpleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.clickButton_info);
            this.Controls.Add(this.checkBox_readed);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookSimpleControl";
            this.Size = new System.Drawing.Size(505, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_genre;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_readed;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton_info;
        private System.Windows.Forms.ToolTip toolTip_description;
    }
}
