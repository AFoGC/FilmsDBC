
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls
{
    partial class BookCategoryUpdateContol
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_removeElement = new System.Windows.Forms.Button();
            this.button_addElement = new System.Windows.Forms.Button();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(31, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(178, 13);
            this.textBox_name.TabIndex = 19;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.Location = new System.Drawing.Point(2, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(27, 13);
            this.textBox_id.TabIndex = 18;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // button_removeElement
            // 
            this.button_removeElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button_removeElement.FlatAppearance.BorderSize = 0;
            this.button_removeElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeElement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_removeElement.Location = new System.Drawing.Point(690, 20);
            this.button_removeElement.Name = "button_removeElement";
            this.button_removeElement.Size = new System.Drawing.Size(100, 20);
            this.button_removeElement.TabIndex = 23;
            this.button_removeElement.Text = "Remove Selected";
            this.button_removeElement.UseVisualStyleBackColor = false;
            this.button_removeElement.Click += new System.EventHandler(this.button_removeElement_Click);
            // 
            // button_addElement
            // 
            this.button_addElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button_addElement.FlatAppearance.BorderSize = 0;
            this.button_addElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addElement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_addElement.Location = new System.Drawing.Point(690, 0);
            this.button_addElement.Name = "button_addElement";
            this.button_addElement.Size = new System.Drawing.Size(100, 20);
            this.button_addElement.TabIndex = 22;
            this.button_addElement.Text = "Add Selected";
            this.button_addElement.UseVisualStyleBackColor = false;
            this.button_addElement.Click += new System.EventHandler(this.button_addElement_Click);
            // 
            // BookCategoryUpdateContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.button_removeElement);
            this.Controls.Add(this.button_addElement);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Name = "BookCategoryUpdateContol";
            this.Size = new System.Drawing.Size(830, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_removeElement;
        private System.Windows.Forms.Button button_addElement;
        private System.Windows.Forms.ToolTip toolTip_description;
    }
}
