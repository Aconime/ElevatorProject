namespace ElevatorProject.Lib.CustomControls
{
    partial class CallButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallButton));
            this.callDefault = new System.Windows.Forms.PictureBox();
            this.callActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.callDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callActive)).BeginInit();
            this.SuspendLayout();
            // 
            // callDefault
            // 
            this.callDefault.Image = ((System.Drawing.Image)(resources.GetObject("callDefault.Image")));
            this.callDefault.Location = new System.Drawing.Point(3, 3);
            this.callDefault.Name = "callDefault";
            this.callDefault.Size = new System.Drawing.Size(59, 63);
            this.callDefault.TabIndex = 0;
            this.callDefault.TabStop = false;
            this.callDefault.Click += new System.EventHandler(this.callDefault_Click);
            // 
            // callActive
            // 
            this.callActive.Image = ((System.Drawing.Image)(resources.GetObject("callActive.Image")));
            this.callActive.Location = new System.Drawing.Point(3, 3);
            this.callActive.Name = "callActive";
            this.callActive.Size = new System.Drawing.Size(59, 63);
            this.callActive.TabIndex = 1;
            this.callActive.TabStop = false;
            this.callActive.Visible = false;
            // 
            // elevatorCalller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.callDefault);
            this.Controls.Add(this.callActive);
            this.MaximumSize = new System.Drawing.Size(64, 68);
            this.MinimumSize = new System.Drawing.Size(64, 68);
            this.Name = "elevatorCalller";
            this.Size = new System.Drawing.Size(64, 68);
            ((System.ComponentModel.ISupportInitialize)(this.callDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox callDefault;
        private System.Windows.Forms.PictureBox callActive;
    }
}
