namespace Battle
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxShip = new PictureBox();
            pictureBoxCanon = new PictureBox();
            pictureBoxCanonBall = new PictureBox();
            timerShip = new System.Windows.Forms.Timer(components);
            timerCanonBall = new System.Windows.Forms.Timer(components);
            pictureBoxBoom = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanonBall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoom).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxShip
            // 
            pictureBoxShip.Image = (Image)resources.GetObject("pictureBoxShip.Image");
            pictureBoxShip.Location = new Point(732, 2);
            pictureBoxShip.Name = "pictureBoxShip";
            pictureBoxShip.Size = new Size(123, 83);
            pictureBoxShip.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShip.TabIndex = 0;
            pictureBoxShip.TabStop = false;
            // 
            // pictureBoxCanon
            // 
            pictureBoxCanon.Image = (Image)resources.GetObject("pictureBoxCanon.Image");
            pictureBoxCanon.Location = new Point(388, 542);
            pictureBoxCanon.Name = "pictureBoxCanon";
            pictureBoxCanon.Size = new Size(63, 113);
            pictureBoxCanon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCanon.TabIndex = 1;
            pictureBoxCanon.TabStop = false;
            // 
            // pictureBoxCanonBall
            // 
            pictureBoxCanonBall.Image = (Image)resources.GetObject("pictureBoxCanonBall.Image");
            pictureBoxCanonBall.Location = new Point(425, 522);
            pictureBoxCanonBall.Name = "pictureBoxCanonBall";
            pictureBoxCanonBall.Size = new Size(18, 21);
            pictureBoxCanonBall.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCanonBall.TabIndex = 2;
            pictureBoxCanonBall.TabStop = false;
            pictureBoxCanonBall.Visible = false;
            // 
            // timerShip
            // 
            timerShip.Enabled = true;
            timerShip.Interval = 2;
            timerShip.Tick += timerShip_Tick;
            // 
            // timerCanonBall
            // 
            timerCanonBall.Interval = 10;
            timerCanonBall.Tick += timerCanonBall_Tick;
            // 
            // pictureBoxBoom
            // 
            pictureBoxBoom.Image = (Image)resources.GetObject("pictureBoxBoom.Image");
            pictureBoxBoom.Location = new Point(550, 258);
            pictureBoxBoom.Name = "pictureBoxBoom";
            pictureBoxBoom.Size = new Size(159, 157);
            pictureBoxBoom.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBoom.TabIndex = 3;
            pictureBoxBoom.TabStop = false;
            pictureBoxBoom.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 657);
            Controls.Add(pictureBoxBoom);
            Controls.Add(pictureBoxCanonBall);
            Controls.Add(pictureBoxCanon);
            Controls.Add(pictureBoxShip);
            Name = "FormMain";
            Text = "Битва морская";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            KeyUp += FormMain_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanonBall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxShip;
        private PictureBox pictureBoxCanon;
        private PictureBox pictureBoxCanonBall;
        private System.Windows.Forms.Timer timerShip;
        private System.Windows.Forms.Timer timerCanonBall;
        private PictureBox pictureBoxBoom;
    }
}
