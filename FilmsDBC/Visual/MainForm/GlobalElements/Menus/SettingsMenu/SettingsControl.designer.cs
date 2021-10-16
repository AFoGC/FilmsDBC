
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu
{
    partial class SettingsControl
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
            this.flowLayoutPanel_settings = new System.Windows.Forms.FlowLayoutPanel();
            this.clickButton_embraceSettings = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_settings
            // 
            this.flowLayoutPanel_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanel_settings.Location = new System.Drawing.Point(200, 132);
            this.flowLayoutPanel_settings.Name = "flowLayoutPanel_settings";
            this.flowLayoutPanel_settings.Size = new System.Drawing.Size(1035, 515);
            this.flowLayoutPanel_settings.TabIndex = 0;
            // 
            // clickButton_embraceSettings
            // 
            this.clickButton_embraceSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_embraceSettings.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_embraceSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clickButton_embraceSettings.Location = new System.Drawing.Point(1275, 132);
            this.clickButton_embraceSettings.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_embraceSettings.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_embraceSettings.Name = "clickButton_embraceSettings";
            this.clickButton_embraceSettings.Size = new System.Drawing.Size(100, 20);
            this.clickButton_embraceSettings.TabIndex = 1;
            this.clickButton_embraceSettings.Text = "Embrace Settings";
            this.clickButton_embraceSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_embraceSettings.Click += new System.EventHandler(this.clickButton_embraceSettings_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.clickButton_embraceSettings);
            this.Controls.Add(this.flowLayoutPanel_settings);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1485, 647);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_settings;
        private Buttons.ClickButton clickButton_embraceSettings;
    }
}
