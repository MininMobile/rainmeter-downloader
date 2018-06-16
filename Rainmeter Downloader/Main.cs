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
        private SkinDisplay _SkinDisplay = new SkinDisplay(0, "Example Skin", "C:\\");

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
                skins_Scroll.Maximum = (_Skins.Length - 1) * 2;
                skipped = true;

                i++;
            } else {
                skins_Scroll.Maximum = _Skins.Length * 2;
            }
            
            while (i < _Skins.Length) {
                // Create SkinDisplay Origin
                int origin = 0;

                // Set SkinDisplay Position
                if (skipped)
                    origin = (i * _SkinDisplay.Height) - _SkinDisplay.Height;
                else
                    origin = i * _SkinDisplay.Height;

                // Create SkinDisplay
                SkinDisplay sd = new SkinDisplay(origin, Path.GetFileName(_Skins[i]), _Skins[i]);

                // Set SkinDisplay Anchor
                sd.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                // Add SkinDisplay to Display
                skins_Container.Controls.Add(sd);

                // Iterate Loop
                i++;
            }
        }

        private void skins_Scroll_Scroll(object sender, ScrollEventArgs e) {
            foreach (SkinDisplay sd in skins_Container.Controls) {
                sd.UpdatePosition(skins_Scroll.Value);
            }
        }

        private void button_BrowseLocal_Click(object sender, EventArgs e) {
            Process.Start(_RMPath);
        }

        private void button_Browse_Click(object sender, EventArgs e) {

        }

        private void button_Settings_Click(object sender, EventArgs e) {
            Settings settings = new Settings();

            settings.Open();
        }
    }
}
