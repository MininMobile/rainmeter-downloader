namespace RMD {
    partial class SkinDisplay {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.skin_Info = new System.Windows.Forms.Label();
            this.skin_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.65903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.34097F));
            this.tableLayoutPanel1.Controls.Add(this.skin_Info, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.skin_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // skin_Info
            // 
            this.skin_Info.AutoSize = true;
            this.skin_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin_Info.Location = new System.Drawing.Point(150, 0);
            this.skin_Info.Name = "skin_Info";
            this.skin_Info.Size = new System.Drawing.Size(240, 30);
            this.skin_Info.TabIndex = 1;
            this.skin_Info.Text = "[SKIN INFO]";
            this.skin_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skin_Name
            // 
            this.skin_Name.AutoSize = true;
            this.skin_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin_Name.Location = new System.Drawing.Point(3, 0);
            this.skin_Name.Name = "skin_Name";
            this.skin_Name.Size = new System.Drawing.Size(141, 30);
            this.skin_Name.TabIndex = 2;
            this.skin_Name.Text = "[SKIN NAME]";
            this.skin_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skin_Name.Click += new System.EventHandler(this.skin_Name_Click);
            // 
            // SkinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "SkinDisplay";
            this.Size = new System.Drawing.Size(393, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label skin_Info;
        private System.Windows.Forms.Label skin_Name;
    }
}
