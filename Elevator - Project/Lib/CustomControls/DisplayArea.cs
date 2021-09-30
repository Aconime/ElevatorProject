using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorProject.Lib.CustomControls
{
    public partial class DisplayArea : UserControl
    {
        public DisplayArea()
        {
            InitializeComponent();
        }

        // Enum for a list of options available for the DisplayArea to use.
        public enum floorStat { First, Ground, GoingFirst, GoingGround }
        public floorStat fs = floorStat.First; // Default option.

        // Property to change the options.
        public floorStat FloorDisplay {
            get { return fs; }
            set {
                fs = value;
                if (fs == floorStat.First)
                {
                    flickerFirst.Stop();
                    flickerGround.Stop();
                    Floor1.ForeColor = Color.FromArgb(52, 152, 219);
                    FloorG.ForeColor = Color.DimGray;
                }
                else if (fs == floorStat.Ground)
                {
                    flickerFirst.Stop();
                    flickerGround.Stop();
                    FloorG.ForeColor = Color.FromArgb(52, 152, 219);
                    Floor1.ForeColor = Color.DimGray;
                }
                else if (fs == floorStat.GoingFirst)
                {
                    flickerGround.Stop();
                    FloorG.ForeColor = Color.DimGray;
                    flickerFirst.Start();
                }
                else if (fs == floorStat.GoingGround) {
                    flickerFirst.Stop();
                    Floor1.ForeColor = Color.DimGray;
                    flickerGround.Start();
                }
            }
        }

        // Flicker animations the color of the number selected on the properties.
        private void flickerGround_Tick(object sender, EventArgs e)
        {
            if (FloorG.ForeColor == Color.FromArgb(52, 152, 219)) {
                FloorG.ForeColor = Color.DimGray;
            }
            else {
                FloorG.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }
        private void flickerFirst_Tick(object sender, EventArgs e)
        {
            if (Floor1.ForeColor == Color.FromArgb(52, 152, 219))
            {
                Floor1.ForeColor = Color.DimGray;
            }
            else
            {
                Floor1.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }
    }
}
