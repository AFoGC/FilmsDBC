
namespace FilmsDBC.Visual.Controls
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.label_update = new System.Windows.Forms.Label();
            this.flowLayoutPanel_SimpleControls = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 16;
            // 
            // textBox_mark
            // 
            this.textBox_mark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mark.Location = new System.Drawing.Point(210, 0);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.Size = new System.Drawing.Size(45, 20);
            this.textBox_mark.TabIndex = 36;
            // 
            // label_update
            // 
            this.label_update.Location = new System.Drawing.Point(850, 0);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(80, 20);
            this.label_update.TabIndex = 42;
            this.label_update.Text = "update";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_SimpleControls
            // 
            this.flowLayoutPanel_SimpleControls.Location = new System.Drawing.Point(30, 20);
            this.flowLayoutPanel_SimpleControls.Name = "flowLayoutPanel_SimpleControls";
            this.flowLayoutPanel_SimpleControls.Size = new System.Drawing.Size(940, 25);
            this.flowLayoutPanel_SimpleControls.TabIndex = 43;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_SimpleControls);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(970, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_mark;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SimpleControls;
    }
}
