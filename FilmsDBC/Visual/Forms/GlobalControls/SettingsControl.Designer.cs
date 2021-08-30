
namespace FilmsDBC.Visual.Forms.GlobalControls
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
            this.button_saveSettings = new System.Windows.Forms.Button();
            this.panel_buttonInterface = new System.Windows.Forms.Panel();
            this.panel_buttonInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_settings
            // 
            this.flowLayoutPanel_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel_settings.Location = new System.Drawing.Point(35, 122);
            this.flowLayoutPanel_settings.Name = "flowLayoutPanel_settings";
            this.flowLayoutPanel_settings.Size = new System.Drawing.Size(1035, 525);
            this.flowLayoutPanel_settings.TabIndex = 0;
            // 
            // button_saveSettings
            // 
            this.button_saveSettings.Location = new System.Drawing.Point(0, 0);
            this.button_saveSettings.Name = "button_saveSettings";
            this.button_saveSettings.Size = new System.Drawing.Size(100, 23);
            this.button_saveSettings.TabIndex = 1;
            this.button_saveSettings.Text = "Save Settings";
            this.button_saveSettings.UseVisualStyleBackColor = true;
            this.button_saveSettings.Click += new System.EventHandler(this.button_saveSettings_Click);
            // 
            // panel_buttonInterface
            // 
            this.panel_buttonInterface.Controls.Add(this.button_saveSettings);
            this.panel_buttonInterface.Location = new System.Drawing.Point(1076, 122);
            this.panel_buttonInterface.Name = "panel_buttonInterface";
            this.panel_buttonInterface.Size = new System.Drawing.Size(260, 100);
            this.panel_buttonInterface.TabIndex = 2;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_buttonInterface);
            this.Controls.Add(this.flowLayoutPanel_settings);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1485, 647);
            this.panel_buttonInterface.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_settings;
        private System.Windows.Forms.Button button_saveSettings;
        private System.Windows.Forms.Panel panel_buttonInterface;
    }
}
