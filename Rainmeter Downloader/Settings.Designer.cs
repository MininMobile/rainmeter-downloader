namespace RMD {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.settings_Tabs = new System.Windows.Forms.TabControl();
            this.tab_General = new System.Windows.Forms.TabPage();
            this.tab_Advanced = new System.Windows.Forms.TabPage();
            this.settings_Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_Tabs
            // 
            this.settings_Tabs.Controls.Add(this.tab_General);
            this.settings_Tabs.Controls.Add(this.tab_Advanced);
            this.settings_Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_Tabs.Location = new System.Drawing.Point(0, 0);
            this.settings_Tabs.Name = "settings_Tabs";
            this.settings_Tabs.SelectedIndex = 0;
            this.settings_Tabs.Size = new System.Drawing.Size(751, 516);
            this.settings_Tabs.TabIndex = 0;
            // 
            // tab_General
            // 
            this.tab_General.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tab_General.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tab_General.Location = new System.Drawing.Point(4, 22);
            this.tab_General.Name = "tab_General";
            this.tab_General.Padding = new System.Windows.Forms.Padding(3);
            this.tab_General.Size = new System.Drawing.Size(743, 490);
            this.tab_General.TabIndex = 0;
            this.tab_General.Text = "General";
            // 
            // tab_Advanced
            // 
            this.tab_Advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tab_Advanced.Location = new System.Drawing.Point(4, 22);
            this.tab_Advanced.Name = "tab_Advanced";
            this.tab_Advanced.Size = new System.Drawing.Size(719, 466);
            this.tab_Advanced.TabIndex = 1;
            this.tab_Advanced.Text = "Advanced";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(751, 516);
            this.Controls.Add(this.settings_Tabs);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.settings_Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settings_Tabs;
        private System.Windows.Forms.TabPage tab_General;
        private System.Windows.Forms.TabPage tab_Advanced;
    }
}