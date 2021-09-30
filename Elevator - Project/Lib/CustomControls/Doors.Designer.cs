namespace ElevatorProject.Lib.CustomControls
{
    partial class Doors
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.doorRight = new System.Windows.Forms.Panel();
            this.doorLeft = new System.Windows.Forms.Panel();
            this.doorsOpen = new System.Windows.Forms.Timer(this.components);
            this.doorsClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // doorRight
            // 
            this.doorRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doorRight.BackColor = System.Drawing.Color.Gainsboro;
            this.doorRight.Location = new System.Drawing.Point(106, 0);
            this.doorRight.Name = "doorRight";
            this.doorRight.Size = new System.Drawing.Size(104, 268);
            this.doorRight.TabIndex = 3;
            // 
            // doorLeft
            // 
            this.doorLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doorLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.doorLeft.Location = new System.Drawing.Point(0, 0);
            this.doorLeft.Name = "doorLeft";
            this.doorLeft.Size = new System.Drawing.Size(104, 268);
            this.doorLeft.TabIndex = 2;
            // 
            // doorsOpen
            // 
            this.doorsOpen.Interval = 1;
            this.doorsOpen.Tick += new System.EventHandler(this.doorsOpen_Tick);
            // 
            // doorsClose
            // 
            this.doorsClose.Interval = 16;
            this.doorsClose.Tick += new System.EventHandler(this.doorsClose_Tick);
            // 
            // Doors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.doorLeft);
            this.Controls.Add(this.doorRight);
            this.Name = "Doors";
            this.Size = new System.Drawing.Size(210, 268);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel doorRight;
        private System.Windows.Forms.Panel doorLeft;
        private System.Windows.Forms.Timer doorsOpen;
        private System.Windows.Forms.Timer doorsClose;
    }
}
