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

            // Get Rainmeter Skins
            _RMPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Rainmeter\\Skins";
            _Skins = Directory.GetDirectories(_RMPath);

            // Create Loop Variables
            int i = 0;
            bool skipped = false;

            // If @Backup Exists, skip it
            if (Path.GetFileName(_Skins[0]) == "@Backup") {
                skipped = true;

                i++;
            }
            
            while (i < _Skins.Length) {
                // Create SkinDisplay
                SkinDisplay sd = new SkinDisplay(Path.GetFileName(_Skins[i]), _Skins[i]);

                // Set SkinDisplay Options
                sd.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                sd.Top = skipped ? (i * 30) - 30 : i * 30;

                // Add SkinDisplay to Display
                skins_Container.Controls.Add(sd);

                // Iterate Loop
                i++;
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
