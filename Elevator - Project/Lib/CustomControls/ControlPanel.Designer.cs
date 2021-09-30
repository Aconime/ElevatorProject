namespace ElevatorProject.Lib.CustomControls
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelText = new System.Windows.Forms.Label();
            this.floorNumber = new System.Windows.Forms.Label();
            this.groundFloorDefault = new System.Windows.Forms.PictureBox();
            this.firstFloorDefault = new System.Windows.Forms.PictureBox();
            this.groundFloorSelected = new System.Windows.Forms.PictureBox();
            this.firstFloorSelected = new System.Windows.Forms.PictureBox();
            this.arrowUp = new System.Windows.Forms.PictureBox();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flickerUp = new System.Windows.Forms.Timer(this.components);
            this.flickerDown = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.arrowUp);
            this.panel2.Controls.Add(this.arrowDown);
            this.panel2.Controls.Add(this.levelText);
            this.panel2.Controls.Add(this.floorNumber);
            this.panel2.Controls.Add(this.groundFloorDefault);
            this.panel2.Controls.Add(this.firstFloorDefault);
            this.panel2.Controls.Add(this.groundFloorSelected);
            this.panel2.Controls.Add(this.firstFloorSelected);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 340);
            this.panel2.TabIndex = 1;
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.levelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.levelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.levelText.Location = new System.Drawing.Point(107, 41);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(21, 21);
            this.levelText.TabIndex = 8;
            this.levelText.Text = "G";
            // 
            // floorNumber
            // 
            this.floorNumber.AutoSize = true;
            this.floorNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.floorNumber.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.floorNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.floorNumber.Location = new System.Drawing.Point(55, 27);
            this.floorNumber.Name = "floorNumber";
            this.floorNumber.Size = new System.Drawing.Size(53, 62);
            this.floorNumber.TabIndex = 5;
            this.floorNumber.Text = "1";
            // 
            // groundFloorDefault
            // 
            this.groundFloorDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloorDefault.BackgroundImage")));
            this.groundFloorDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloorDefault.Location = new System.Drawing.Point(42, 235);
            this.groundFloorDefault.Name = "groundFloorDefault";
            this.groundFloorDefault.Size = new System.Drawing.Size(75, 75);
            this.groundFloorDefault.TabIndex = 2;
            this.groundFloorDefault.TabStop = false;
            this.groundFloorDefault.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groundFloorDefault_MouseDown);
            this.groundFloorDefault.MouseUp += new System.Windows.Forms.MouseEventHandler(this.groundFloorDefault_MouseUp);
            // 
            // firstFloorDefault
            // 
            this.firstFloorDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloorDefault.BackgroundImage")));
            this.firstFloorDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloorDefault.Location = new System.Drawing.Point(42, 133);
            this.firstFloorDefault.Name = "firstFloorDefault";
            this.firstFloorDefault.Size = new System.Drawing.Size(75, 75);
            this.firstFloorDefault.TabIndex = 0;
            this.firstFloorDefault.TabStop = false;
            this.firstFloorDefault.MouseDown += new System.Windows.Forms.MouseEventHandler(this.firstFloorDefault_MouseDown);
            this.firstFloorDefault.MouseUp += new System.Windows.Forms.MouseEventHandler(this.firstFloorDefault_MouseUp);
            // 
            // groundFloorSelected
            // 
            this.groundFloorSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloorSelected.BackgroundImage")));
            this.groundFloorSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloorSelected.Location = new System.Drawing.Point(36, 229);
            this.groundFloorSelected.Name = "groundFloorSelected";
            this.groundFloorSelected.Size = new System.Drawing.Size(87, 87);
            this.groundFloorSelected.TabIndex = 3;
            this.groundFloorSelected.TabStop = false;
            this.groundFloorSelected.Visible = false;
            // 
            // firstFloorSelected
            // 
            this.firstFloorSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloorSelected.BackgroundImage")));
            this.firstFloorSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloorSelected.Location = new System.Drawing.Point(36, 127);
            this.firstFloorSelected.Name = "firstFloorSelected";
            this.firstFloorSelected.Size = new System.Drawing.Size(87, 87);
            this.firstFloorSelected.TabIndex = 1;
            this.firstFloorSelected.TabStop = false;
            this.firstFloorSelected.Visible = false;
            // 
            // arrowUp
            // 
            this.arrowUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.arrowUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowUp.BackgroundImage")));
            this.arrowUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowUp.Location = new System.Drawing.Point(111, 67);
            this.arrowUp.Name = "arrowUp";
            this.arrowUp.Size = new System.Drawing.Size(12, 12);
            this.arrowUp.TabIndex = 7;
            this.arrowUp.TabStop = false;
            this.arrowUp.Visible = false;
            // 
            // arrowDown
            // 
            this.arrowDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.arrowDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowDown.BackgroundImage")));
            this.arrowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowDown.Location = new System.Drawing.Point(111, 67);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(12, 12);
            this.arrowDown.TabIndex = 6;
            this.arrowDown.TabStop = false;
            this.arrowDown.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(19, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 79);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // flickerUp
            // 
            this.flickerUp.Interval = 400;
            this.flickerUp.Tick += new System.EventHandler(this.flickerUp_Tick);
            // 
            // flickerDown
            // 
            this.flickerDown.Interval = 400;
            this.flickerDown.Tick += new System.EventHandler(this.flickerDown_Tick);
            // 
            // ControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(160, 342);
            this.MinimumSize = new System.Drawing.Size(160, 342);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(160, 342);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox firstFloorSelected;
        private System.Windows.Forms.PictureBox firstFloorDefault;
        private System.Windows.Forms.PictureBox groundFloorDefault;
        private System.Windows.Forms.PictureBox groundFloorSelected;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox arrowUp;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label floorNumber;
        private System.Windows.Forms.Timer flickerUp;
        private System.Windows.Forms.Timer flickerDown;
        private System.Windows.Forms.Label levelText;
    }
}
