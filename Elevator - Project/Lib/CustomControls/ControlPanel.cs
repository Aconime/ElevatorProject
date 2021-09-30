using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ElevatorProject.Lib.CustomControls
{
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();
        }
        
        #region "Custom Control Properties"
        // This property allows the application to change the floor number on the display user control.
        public string floorNumberDisplay
        {
            get
            {
                return floorNumber.Text;
            }
            set { floorNumber.Text = value; }
        }

        // Elevator arrow direction (UP / DOWN / STOPPED).
        public enum arrDir { Stopped, Up, Down }
        arrDir ad = arrDir.Stopped;
        public arrDir ArrowDirection
        {
            get { return ad; }
            set
            {
                ad = value;
                if (ad == arrDir.Up)
                {
                    arrowDown.Visible = false;
                    levelText.Text = "1";
                    flickerUp.Start();
                    flickerDown.Stop();
                }
                else if (ad == arrDir.Down)
                {
                    arrowUp.Visible = false;
                    levelText.Text = "G";
                    flickerDown.Start();
                    flickerUp.Stop();
                }
                else if (ad == arrDir.Stopped)
                {
                    arrowDown.Visible = false;
                    arrowUp.Visible = false;
                    levelText.Text = "";
                    flickerDown.Stop();
                    flickerUp.Stop();
                }
            }
        }
        #endregion

        // Creating the up and down button events.
        // This can allow the app to gather input data by using the control dynamically.
        public event EventHandler UpClicked;
        public event EventHandler DownClicked;

        // Button Click Effect (MouseDown & MouseUp Events).
        private void firstFloorDefault_MouseUp(object sender, MouseEventArgs e)
        {
            firstFloorSelected.Visible = false;
            firstFloorDefault.Visible = true;

            if (UpClicked != null)
            {
                UpClicked(this, e);
            }
        }

        // Button Click Effect (MouseDown & MouseUp Events).
        private void groundFloorDefault_MouseUp(object sender, MouseEventArgs e)
        {
            groundFloorSelected.Visible = false;
            groundFloorDefault.Visible = true;

            if (DownClicked != null)
            {
                DownClicked(this, e);
            }
        }

        // Button Click Effect (MouseDown & MouseUp Events).
        private void firstFloorDefault_MouseDown(object sender, MouseEventArgs e)
        {
            firstFloorSelected.Visible = true;
            firstFloorDefault.Visible = false;
        }
        

        // Button Click Effect (MouseDown & MouseUp Events).
        private void groundFloorDefault_MouseDown(object sender, MouseEventArgs e)
        {
            groundFloorSelected.Visible = true;
            groundFloorDefault.Visible = false;
        }
        

        // Flicker the up arrow on the display area of the panel.
        private void flickerUp_Tick(object sender, EventArgs e)
        {
            if (arrowUp.Visible == false)
            {
                arrowUp.Visible = true;
            }
            else if (arrowUp.Visible == true) {
                arrowUp.Visible = false;
            }
        }

        // Flicker the down arrow on the display area of the panel.
        private void flickerDown_Tick(object sender, EventArgs e)
        {
            if (arrowDown.Visible == false)
            {
                arrowDown.Visible = true;
            }
            else if (arrowDown.Visible == true)
            {
                arrowDown.Visible = false;
            }
        }
    }
}
