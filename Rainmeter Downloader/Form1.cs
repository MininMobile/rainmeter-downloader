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
        private string _RMPath;
        private string[] _Skins;

        public Menu() {
            InitializeComponent();

            _RMPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Rainmeter\\Skins";
            _Skins = Directory.GetDirectories(_RMPath);

            int y = -1;
            foreach(var file in _Skins) {
                y++;
                SkinDisplay sd = new SkinDisplay(Path.GetFileName(file), file);
                
                sd.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                sd.Top = y * 30;

                skins_Container.Controls.Add(sd);
            }
        }

        private void button_BrowseLocal_Click(object sender, EventArgs e) {
            Process.Start(_RMPath);
        }

        private void button_Browse_Click(object sender, EventArgs e) {

        }

        private void button_Settings_Click(object sender, EventArgs e) {

        }
    }
}
