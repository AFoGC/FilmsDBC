
namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
    partial class CategoryUpdateControl
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_controls = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_addElement = new System.Windows.Forms.TextBox();
            this.button_addElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 17;
            // 
            // flowLayoutPanel_controls
            // 
            this.flowLayoutPanel_controls.AutoScroll = true;
            this.flowLayoutPanel_controls.Location = new System.Drawing.Point(30, 20);
            this.flowLayoutPanel_controls.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            this.flowLayoutPanel_controls.Size = new System.Drawing.Size(500, 40);
            this.flowLayoutPanel_controls.TabIndex = 18;
            // 
            // textBox_addElement
            // 
            this.textBox_addElement.Location = new System.Drawing.Point(646, 0);
            this.textBox_addElement.Name = "textBox_addElement";
            this.textBox_addElement.Size = new System.Drawing.Size(38, 20);
            this.textBox_addElement.TabIndex = 19;
            // 
            // button_addElement
            // 
            this.button_addElement.Location = new System.Drawing.Point(690, 0);
            this.button_addElement.Name = "button_addElement";
            this.button_addElement.Size = new System.Drawing.Size(75, 20);
            this.button_addElement.TabIndex = 20;
            this.button_addElement.Text = "Add by Id";
            this.button_addElement.UseVisualStyleBackColor = true;
            this.button_addElement.Click += new System.EventHandler(this.button_addElement_Click);
            // 
            // CategoryUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_addElement);
            this.Controls.Add(this.textBox_addElement);
            this.Controls.Add(this.flowLayoutPanel_controls);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Name = "CategoryUpdateControl";
            this.Size = new System.Drawing.Size(830, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_controls;
        private System.Windows.Forms.TextBox textBox_addElement;
        private System.Windows.Forms.Button button_addElement;
    }
}
