
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls
{
    partial class CategoryControl
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
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_SimpleControls = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.label_update = new FilmsDBC.Visual.Buttons.ClickButton();
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
            // textBox_mark
            // 
            this.textBox_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mark.Location = new System.Drawing.Point(211, 1);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.ReadOnly = true;
            this.textBox_mark.Size = new System.Drawing.Size(42, 13);
            this.textBox_mark.TabIndex = 36;
            this.toolTip_description.SetToolTip(this.textBox_mark, "mark");
            // 
            // flowLayoutPanel_SimpleControls
            // 
            this.flowLayoutPanel_SimpleControls.Location = new System.Drawing.Point(29, 15);
            this.flowLayoutPanel_SimpleControls.Name = "flowLayoutPanel_SimpleControls";
            this.flowLayoutPanel_SimpleControls.Size = new System.Drawing.Size(800, 5);
            this.flowLayoutPanel_SimpleControls.TabIndex = 43;
            // 
            // label_update
            // 
            this.label_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_update.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_update.Location = new System.Drawing.Point(750, 1);
            this.label_update.MouseDownColor = System.Drawing.Color.Empty;
            this.label_update.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(80, 13);
            this.label_update.TabIndex = 42;
            this.label_update.Text = "update";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_description.SetToolTip(this.label_update, "open update menu");
            this.label_update.Click += new System.EventHandler(this.label_update_Click);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.flowLayoutPanel_SimpleControls);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(830, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_mark;
        private FilmsDBC.Visual.Buttons.ClickButton label_update;
        internal System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SimpleControls;
        private System.Windows.Forms.ToolTip toolTip_description;
    }
}
