﻿namespace fad2.UI.UserControls
{
    partial class SettingsString
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingKey = new MetroFramework.Controls.MetroLabel();
            this.SettingVersion = new MetroFramework.Controls.MetroLabel();
            this.SettingValue = new MetroFramework.Controls.MetroTextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.MetroToolTip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // SettingKey
            // 
            this.SettingKey.Location = new System.Drawing.Point(4, 5);
            this.SettingKey.Name = "SettingKey";
            this.SettingKey.Size = new System.Drawing.Size(223, 23);
            this.SettingKey.TabIndex = 0;
            // 
            // SettingVersion
            // 
            this.SettingVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingVersion.Location = new System.Drawing.Point(664, 9);
            this.SettingVersion.Name = "SettingVersion";
            this.SettingVersion.Size = new System.Drawing.Size(81, 19);
            this.SettingVersion.TabIndex = 2;
            this.SettingVersion.Text = "0.0.0.0";
            // 
            // SettingValue
            // 
            this.SettingValue.BackColor = System.Drawing.Color.Tomato;
            // 
            // 
            // 
            this.SettingValue.CustomButton.Image = null;
            this.SettingValue.CustomButton.Location = new System.Drawing.Point(357, 2);
            this.SettingValue.CustomButton.Name = "";
            this.SettingValue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.SettingValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SettingValue.CustomButton.TabIndex = 1;
            this.SettingValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SettingValue.CustomButton.UseSelectable = true;
            this.SettingValue.CustomButton.Visible = false;
            this.SettingValue.Lines = new string[0];
            this.SettingValue.Location = new System.Drawing.Point(233, 4);
            this.SettingValue.MaxLength = 32767;
            this.SettingValue.Name = "SettingValue";
            this.SettingValue.PasswordChar = '\0';
            this.SettingValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SettingValue.SelectedText = "";
            this.SettingValue.SelectionLength = 0;
            this.SettingValue.SelectionStart = 0;
            this.SettingValue.ShortcutsEnabled = true;
            this.SettingValue.Size = new System.Drawing.Size(383, 28);
            this.SettingValue.TabIndex = 1;
            this.SettingValue.UseSelectable = true;
            this.SettingValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SettingValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SettingValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingValue_KeyDown);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.WarningLabel.Location = new System.Drawing.Point(622, 6);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(36, 26);
            this.WarningLabel.TabIndex = 4;
            this.WarningLabel.Text = "i";
            this.MetroToolTip.SetToolTip(this.WarningLabel, "\r\n");
            // 
            // MetroToolTip
            // 
            this.MetroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroToolTip.StyleManager = null;
            this.MetroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SettingsString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SettingVersion);
            this.Controls.Add(this.SettingValue);
            this.Controls.Add(this.SettingKey);
            this.Name = "SettingsString";
            this.Size = new System.Drawing.Size(765, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel SettingKey;
        private MetroFramework.Controls.MetroLabel SettingVersion;
        private System.Windows.Forms.Label WarningLabel;
        protected MetroFramework.Controls.MetroTextBox SettingValue;
        protected MetroFramework.Components.MetroToolTip MetroToolTip;
    }
}
