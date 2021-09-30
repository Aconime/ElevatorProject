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
    public partial class Doors : UserControl
    {
        public Doors()
        {
            InitializeComponent();
        }

        // 0 => Doors closed.
        // 1 => Doors open.
        public int doorStatus = 0;

        // Function that can be called from any class to close the doors.
        public void closeDoors() {
            doorsClose.Start();
        }

        // Function that can be called from any class to open the doors.
        public void openDoors() {
            doorsOpen.Start();
            this.BackColor = Color.Gray;
        }

        // Close doors animation (using timer).
        private void doorsClose_Tick(object sender, EventArgs e)
        {
            doorLeft.Left += 1;
            doorRight.Left -= 1;

            if (doorLeft.Location.X == 0 || doorRight.Location.X == (this.Width / 2) + 1)
            {
                doorsClose.Stop();
                this.BackColor = Color.DarkGray;
                doorStatus = 0; // Doors closed status.
            }
        }

        // Open doors animation (using timer).
        private void doorsOpen_Tick(object sender, EventArgs e)
        {
            doorLeft.Left -= 1;
            doorRight.Left += 1;

            if (doorLeft.Location.X == -(doorLeft.Width + 5) || doorRight.Location.X == this.Width - 5)
            {
                doorsOpen.Stop();
                doorStatus = 1; // Doors open status.
            }
        }
    }
}
