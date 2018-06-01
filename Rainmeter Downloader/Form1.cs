using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMD {
    public partial class Menu : Form {
        private string _DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Menu() {
            InitializeComponent();
        }

        private void button_BrowseLocal_Click(object sender, EventArgs e) {
            Process.Start(_DocumentsPath + "\\Rainmeter\\Skins");
        }

        private void button_Browse_Click(object sender, EventArgs e) {

        }

        private void button_Settings_Click(object sender, EventArgs e) {

        }
    }
}
