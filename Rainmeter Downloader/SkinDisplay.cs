using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RMD {
    public partial class SkinDisplay : UserControl {
        string skinpath;
        string skinname;

        public SkinDisplay(string skinname, string skinpath) {
            InitializeComponent();

            this.skinpath = skinpath;
            this.skinname = skinname;

            this.skin_Name.Text = "Skin";
            this.skin_Info.Text = "Skin Info";
        }

        private void skin_Name_Click(object sender, EventArgs e) {
            Process.Start(skinpath);
        }
    }
}
