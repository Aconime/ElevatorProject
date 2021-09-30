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
    public partial class CallButton : UserControl
    {
        public CallButton()
        {
            InitializeComponent();
        }
        
        // Custom property to change the button state via active and default state.
        // This shows if the button to call the elevator has been clicked or not.
        public bool isCalling {
            get {
                if (callDefault.Visible == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set {
                if (value == true)
                {
                    callDefault.Visible = false;
                    callActive.Visible = true;
                }
                else
                {
                    callDefault.Visible = true;
                    callActive.Visible = false;
                }
            }
        }

        // Event when elevator caller is clicked.
        public event EventHandler CallClicked;
        private void callDefault_Click(object sender, EventArgs e)
        {
            // Raising the event on the click event.
            if (CallClicked != null) {
                CallClicked(this, e);
            }
        }
        
    }
}
