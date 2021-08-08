
namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
{
    partial class DirectoryPathSettingControl
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
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.clickButton_changeDirectory = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(200, 0);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.ReadOnly = true;
            this.textBox_filePath.Size = new System.Drawing.Size(300, 20);
            this.textBox_filePath.TabIndex = 1;
            // 
            // clickButton_changeDirectory
            // 
            this.clickButton_changeDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.Location = new System.Drawing.Point(500, 0);
            this.clickButton_changeDirectory.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.Name = "clickButton_changeDirectory";
            this.clickButton_changeDirectory.Size = new System.Drawing.Size(100, 20);
            this.clickButton_changeDirectory.TabIndex = 0;
            this.clickButton_changeDirectory.Text = "Change Directory";
            this.clickButton_changeDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(200, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Files directory path:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DirectoryPathSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_filePath);
            this.Controls.Add(this.clickButton_changeDirectory);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DirectoryPathSettingControl";
            this.Size = new System.Drawing.Size(1035, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_filePath;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton_changeDirectory;
        private System.Windows.Forms.Label label_name;
    }
}
