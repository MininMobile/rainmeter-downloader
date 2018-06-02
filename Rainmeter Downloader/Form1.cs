using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMD {
    public partial class Menu : Form {
        private string _DocumentsPath;
        private string[] _Skins;

        public Menu() {
            InitializeComponent();

            _DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _Skins = Directory.GetFiles(_DocumentsPath, "*.*");

            int y = 0;
            foreach(var file in _Skins) {
                SkinDisplay sd = new SkinDisplay(file, _DocumentsPath + file);

                y += 1;

                sd.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                sd.Top = y * 30;

                skins_Container.Controls.Add(sd);
            }
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
