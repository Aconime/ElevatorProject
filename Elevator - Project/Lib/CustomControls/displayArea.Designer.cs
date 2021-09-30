namespace ElevatorProject.Lib.CustomControls
{
    partial class DisplayArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayArea));
            this.panel3 = new System.Windows.Forms.Panel();
            this.FloorG = new System.Windows.Forms.Label();
            this.Floor1 = new System.Windows.Forms.Label();
            this.flickerGround = new System.Windows.Forms.Timer(this.components);
            this.flickerFirst = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.FloorG);
            this.panel3.Controls.Add(this.Floor1);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 32);
            this.panel3.TabIndex = 4;
            // 
            // FloorG
            // 
            this.FloorG.BackColor = System.Drawing.Color.Transparent;
            this.FloorG.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FloorG.ForeColor = System.Drawing.Color.DimGray;
            this.FloorG.Location = new System.Drawing.Point(39, 3);
            this.FloorG.Name = "FloorG";
            this.FloorG.Size = new System.Drawing.Size(17, 23);
            this.FloorG.TabIndex = 3;
            this.FloorG.Text = "G";
            this.FloorG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Floor1
            // 
            this.Floor1.BackColor = System.Drawing.Color.Transparent;
            this.Floor1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Floor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Floor1.Location = new System.Drawing.Point(12, 3);
            this.Floor1.Name = "Floor1";
            this.Floor1.Size = new System.Drawing.Size(17, 23);
            this.Floor1.TabIndex = 2;
            this.Floor1.Text = "1";
            this.Floor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flickerGround
            // 
            this.flickerGround.Interval = 400;
            this.flickerGround.Tick += new System.EventHandler(this.flickerGround_Tick);
            // 
            // flickerFirst
            // 
            this.flickerFirst.Interval = 400;
            this.flickerFirst.Tick += new System.EventHandler(this.flickerFirst_Tick);
            // 
            // DisplayArea
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(70, 34);
            this.MinimumSize = new System.Drawing.Size(70, 34);
            this.Name = "DisplayArea";
            this.Size = new System.Drawing.Size(70, 34);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FloorG;
        private System.Windows.Forms.Label Floor1;
        private System.Windows.Forms.Timer flickerGround;
        private System.Windows.Forms.Timer flickerFirst;
    }
}
