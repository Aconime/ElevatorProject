namespace ElevatorProject
{
    partial class elevatorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevatorForm));
            this.mainElevator = new System.Windows.Forms.PictureBox();
            this.clearEvents = new System.Windows.Forms.Button();
            this.saveEvents = new System.Windows.Forms.Button();
            this.loadEvents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventHistoryList = new System.Windows.Forms.ListView();
            this.timeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.animateDown = new System.Windows.Forms.Timer(this.components);
            this.animateUp = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groundFloorDoors = new ElevatorProject.Lib.CustomControls.Doors();
            this.firstFloorDoors = new ElevatorProject.Lib.CustomControls.Doors();
            this.elevatorControlPanel = new ElevatorProject.Lib.CustomControls.ControlPanel();
            this.callBtn_FloorG = new ElevatorProject.Lib.CustomControls.CallButton();
            this.callBtn_Floor1 = new ElevatorProject.Lib.CustomControls.CallButton();
            this.firstDisplay = new ElevatorProject.Lib.CustomControls.DisplayArea();
            this.groundDisplay = new ElevatorProject.Lib.CustomControls.DisplayArea();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // mainElevator
            // 
            this.mainElevator.BackColor = System.Drawing.Color.Gray;
            this.mainElevator.Location = new System.Drawing.Point(15, 59);
            this.mainElevator.Name = "mainElevator";
            this.mainElevator.Size = new System.Drawing.Size(210, 268);
            this.mainElevator.TabIndex = 15;
            this.mainElevator.TabStop = false;
            // 
            // clearEvents
            // 
            this.clearEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearEvents.Location = new System.Drawing.Point(563, 698);
            this.clearEvents.Name = "clearEvents";
            this.clearEvents.Size = new System.Drawing.Size(98, 32);
            this.clearEvents.TabIndex = 26;
            this.clearEvents.Text = "Clear All";
            this.clearEvents.UseVisualStyleBackColor = true;
            this.clearEvents.Click += new System.EventHandler(this.clearEvents_Click);
            // 
            // saveEvents
            // 
            this.saveEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEvents.Enabled = false;
            this.saveEvents.Location = new System.Drawing.Point(826, 698);
            this.saveEvents.Name = "saveEvents";
            this.saveEvents.Size = new System.Drawing.Size(112, 32);
            this.saveEvents.TabIndex = 25;
            this.saveEvents.Text = "Save Events";
            this.saveEvents.UseVisualStyleBackColor = true;
            this.saveEvents.Click += new System.EventHandler(this.saveEvents_Click);
            // 
            // loadEvents
            // 
            this.loadEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadEvents.Location = new System.Drawing.Point(708, 698);
            this.loadEvents.Name = "loadEvents";
            this.loadEvents.Size = new System.Drawing.Size(112, 32);
            this.loadEvents.TabIndex = 24;
            this.loadEvents.Text = "Load Events";
            this.loadEvents.UseVisualStyleBackColor = true;
            this.loadEvents.Click += new System.EventHandler(this.loadEvents_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.eventHistoryList);
            this.panel1.Location = new System.Drawing.Point(564, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 642);
            this.panel1.TabIndex = 23;
            // 
            // eventHistoryList
            // 
            this.eventHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventHistoryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventHistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventHistoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeDate,
            this.eventDescription});
            this.eventHistoryList.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.eventHistoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.eventHistoryList.FullRowSelect = true;
            this.eventHistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eventHistoryList.Location = new System.Drawing.Point(1, 1);
            this.eventHistoryList.Name = "eventHistoryList";
            this.eventHistoryList.Size = new System.Drawing.Size(372, 640);
            this.eventHistoryList.TabIndex = 17;
            this.eventHistoryList.UseCompatibleStateImageBehavior = false;
            this.eventHistoryList.View = System.Windows.Forms.View.Details;
            // 
            // timeDate
            // 
            this.timeDate.Text = "Time & Date";
            this.timeDate.Width = 149;
            // 
            // eventDescription
            // 
            this.eventDescription.Text = "Events";
            this.eventDescription.Width = 221;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(315, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 717);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(533, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 717);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(344, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Control Panel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Events History List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animateDown
            // 
            this.animateDown.Interval = 1;
            this.animateDown.Tick += new System.EventHandler(this.animateDown_Tick);
            // 
            // animateUp
            // 
            this.animateUp.Interval = 1;
            this.animateUp.Tick += new System.EventHandler(this.animateUp_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(247, 515);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 38);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(250, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 38);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Location = new System.Drawing.Point(12, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(216, 318);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(216, 318);
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            // 
            // groundFloorDoors
            // 
            this.groundFloorDoors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groundFloorDoors.BackColor = System.Drawing.Color.DarkGray;
            this.groundFloorDoors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloorDoors.Location = new System.Drawing.Point(15, 459);
            this.groundFloorDoors.Name = "groundFloorDoors";
            this.groundFloorDoors.Size = new System.Drawing.Size(210, 268);
            this.groundFloorDoors.TabIndex = 36;
            // 
            // firstFloorDoors
            // 
            this.firstFloorDoors.BackColor = System.Drawing.Color.DarkGray;
            this.firstFloorDoors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloorDoors.Location = new System.Drawing.Point(15, 59);
            this.firstFloorDoors.Name = "firstFloorDoors";
            this.firstFloorDoors.Size = new System.Drawing.Size(210, 268);
            this.firstFloorDoors.TabIndex = 35;
            // 
            // elevatorControlPanel
            // 
            this.elevatorControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.elevatorControlPanel.ArrowDirection = ElevatorProject.Lib.CustomControls.ControlPanel.arrDir.Stopped;
            this.elevatorControlPanel.BackColor = System.Drawing.Color.Gray;
            this.elevatorControlPanel.floorNumberDisplay = "1";
            this.elevatorControlPanel.Location = new System.Drawing.Point(344, 215);
            this.elevatorControlPanel.MaximumSize = new System.Drawing.Size(160, 342);
            this.elevatorControlPanel.MinimumSize = new System.Drawing.Size(160, 342);
            this.elevatorControlPanel.Name = "elevatorControlPanel";
            this.elevatorControlPanel.Size = new System.Drawing.Size(160, 342);
            this.elevatorControlPanel.TabIndex = 14;
            this.elevatorControlPanel.UpClicked += new System.EventHandler(this.elevatorControlPanel_UpClicked);
            this.elevatorControlPanel.DownClicked += new System.EventHandler(this.elevatorControlPanel_DownClicked);
            // 
            // callBtn_FloorG
            // 
            this.callBtn_FloorG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.callBtn_FloorG.BackColor = System.Drawing.Color.Transparent;
            this.callBtn_FloorG.isCalling = false;
            this.callBtn_FloorG.Location = new System.Drawing.Point(234, 559);
            this.callBtn_FloorG.MaximumSize = new System.Drawing.Size(64, 68);
            this.callBtn_FloorG.MinimumSize = new System.Drawing.Size(64, 68);
            this.callBtn_FloorG.Name = "callBtn_FloorG";
            this.callBtn_FloorG.Size = new System.Drawing.Size(64, 68);
            this.callBtn_FloorG.TabIndex = 13;
            this.callBtn_FloorG.CallClicked += new System.EventHandler(this.callBtn_FloorG_CallClicked);
            // 
            // callBtn_Floor1
            // 
            this.callBtn_Floor1.BackColor = System.Drawing.Color.Transparent;
            this.callBtn_Floor1.isCalling = false;
            this.callBtn_Floor1.Location = new System.Drawing.Point(234, 159);
            this.callBtn_Floor1.MaximumSize = new System.Drawing.Size(64, 68);
            this.callBtn_Floor1.MinimumSize = new System.Drawing.Size(64, 68);
            this.callBtn_Floor1.Name = "callBtn_Floor1";
            this.callBtn_Floor1.Size = new System.Drawing.Size(64, 68);
            this.callBtn_Floor1.TabIndex = 12;
            this.callBtn_Floor1.CallClicked += new System.EventHandler(this.callBtn_Floor1_CallClicked);
            // 
            // firstDisplay
            // 
            this.firstDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.firstDisplay.FloorDisplay = ElevatorProject.Lib.CustomControls.DisplayArea.floorStat.First;
            this.firstDisplay.Location = new System.Drawing.Point(85, 19);
            this.firstDisplay.MaximumSize = new System.Drawing.Size(70, 34);
            this.firstDisplay.MinimumSize = new System.Drawing.Size(70, 34);
            this.firstDisplay.Name = "firstDisplay";
            this.firstDisplay.Size = new System.Drawing.Size(70, 34);
            this.firstDisplay.TabIndex = 5;
            // 
            // groundDisplay
            // 
            this.groundDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groundDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.groundDisplay.FloorDisplay = ElevatorProject.Lib.CustomControls.DisplayArea.floorStat.First;
            this.groundDisplay.Location = new System.Drawing.Point(85, 419);
            this.groundDisplay.MaximumSize = new System.Drawing.Size(70, 34);
            this.groundDisplay.MinimumSize = new System.Drawing.Size(70, 34);
            this.groundDisplay.Name = "groundDisplay";
            this.groundDisplay.Size = new System.Drawing.Size(70, 34);
            this.groundDisplay.TabIndex = 4;
            // 
            // elevatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 742);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groundFloorDoors);
            this.Controls.Add(this.firstFloorDoors);
            this.Controls.Add(this.clearEvents);
            this.Controls.Add(this.saveEvents);
            this.Controls.Add(this.loadEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elevatorControlPanel);
            this.Controls.Add(this.callBtn_FloorG);
            this.Controls.Add(this.callBtn_Floor1);
            this.Controls.Add(this.firstDisplay);
            this.Controls.Add(this.groundDisplay);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.mainElevator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "elevatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Project";
            this.Load += new System.EventHandler(this.elevatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Lib.CustomControls.DisplayArea groundDisplay;
        private Lib.CustomControls.DisplayArea firstDisplay;
        private Lib.CustomControls.CallButton callBtn_Floor1;
        private Lib.CustomControls.CallButton callBtn_FloorG;
        private Lib.CustomControls.ControlPanel elevatorControlPanel;
        private System.Windows.Forms.PictureBox mainElevator;
        private System.Windows.Forms.Button clearEvents;
        private System.Windows.Forms.Button saveEvents;
        private System.Windows.Forms.Button loadEvents;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView eventHistoryList;
        private System.Windows.Forms.ColumnHeader timeDate;
        private System.Windows.Forms.ColumnHeader eventDescription;
        private Lib.CustomControls.Doors firstFloorDoors;
        private Lib.CustomControls.Doors groundFloorDoors;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer animateDown;
        private System.Windows.Forms.Timer animateUp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}