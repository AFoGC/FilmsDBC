
namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
{
    partial class ProfileSettingControl
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
            this.textBox_profileName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.comboBox_Profiles = new System.Windows.Forms.ComboBox();
            this.clickButton_changeDirectory = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // textBox_profileName
            // 
            this.textBox_profileName.Location = new System.Drawing.Point(210, 0);
            this.textBox_profileName.Name = "textBox_profileName";
            this.textBox_profileName.ReadOnly = true;
            this.textBox_profileName.Size = new System.Drawing.Size(290, 20);
            this.textBox_profileName.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(204, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Files directory path:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Profiles
            // 
            this.comboBox_Profiles.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_Profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Profiles.FormattingEnabled = true;
            this.comboBox_Profiles.Location = new System.Drawing.Point(500, -1);
            this.comboBox_Profiles.Name = "comboBox_Profiles";
            this.comboBox_Profiles.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Profiles.TabIndex = 3;
            // 
            // clickButton_changeDirectory
            // 
            this.clickButton_changeDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.Location = new System.Drawing.Point(625, 0);
            this.clickButton_changeDirectory.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.Name = "clickButton_changeDirectory";
            this.clickButton_changeDirectory.Size = new System.Drawing.Size(100, 20);
            this.clickButton_changeDirectory.TabIndex = 0;
            this.clickButton_changeDirectory.Text = "Change Directory";
            this.clickButton_changeDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_changeDirectory.Click += new System.EventHandler(this.clickButton_changeDirectory_Click);
            // 
            // ProfileSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_Profiles);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_profileName);
            this.Controls.Add(this.clickButton_changeDirectory);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProfileSettingControl";
            this.Size = new System.Drawing.Size(1035, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_profileName;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton_changeDirectory;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_Profiles;
    }
}
