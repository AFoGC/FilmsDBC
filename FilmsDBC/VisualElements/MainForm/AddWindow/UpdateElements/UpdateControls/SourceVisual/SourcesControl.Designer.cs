
namespace FilmsDBC.VisualElements.MainForm.AddWindow.UpdateElements.UpdateControls.SourceVisual
{
    partial class SourcesControl
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
            this.button_update = new System.Windows.Forms.Button();
            this.button_addElement = new System.Windows.Forms.Button();
            this.flowLayoutPanel_sources = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(0, 0);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(85, 20);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Подтвердить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_addElement
            // 
            this.button_addElement.Location = new System.Drawing.Point(85, 0);
            this.button_addElement.Name = "button_addElement";
            this.button_addElement.Size = new System.Drawing.Size(85, 20);
            this.button_addElement.TabIndex = 3;
            this.button_addElement.Text = "Добавить";
            this.button_addElement.UseVisualStyleBackColor = true;
            this.button_addElement.Click += new System.EventHandler(this.button_addElement_Click);
            // 
            // flowLayoutPanel_sources
            // 
            this.flowLayoutPanel_sources.AutoScroll = true;
            this.flowLayoutPanel_sources.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanel_sources.Name = "flowLayoutPanel_sources";
            this.flowLayoutPanel_sources.Size = new System.Drawing.Size(420, 70);
            this.flowLayoutPanel_sources.TabIndex = 4;
            // 
            // SourcesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_sources);
            this.Controls.Add(this.button_addElement);
            this.Controls.Add(this.button_update);
            this.Name = "SourcesControl";
            this.Size = new System.Drawing.Size(420, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_addElement;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_sources;
    }
}
