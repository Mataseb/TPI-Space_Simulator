namespace SpaceSimulator
{
    partial class SpaceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceView));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dbEditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlayBackwards = new System.Windows.Forms.Button();
            this.grbxMove = new System.Windows.Forms.GroupBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblInfoAge = new System.Windows.Forms.Label();
            this.lblInfoZoom = new System.Windows.Forms.Label();
            this.lblInfoSpeed = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.grbxMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.dbEditTSMI,
            this.viewTSMI,
            this.helpTSMI});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(280, 24);
            this.Menu.Stretch = false;
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menu";
            // 
            // fileTSMI
            // 
            this.fileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveViewTSMI,
            this.quitTSMI});
            this.fileTSMI.Name = "fileTSMI";
            this.fileTSMI.Size = new System.Drawing.Size(54, 20);
            this.fileTSMI.Text = "Fichier";
            // 
            // saveViewTSMI
            // 
            this.saveViewTSMI.Name = "saveViewTSMI";
            this.saveViewTSMI.Size = new System.Drawing.Size(161, 22);
            this.saveViewTSMI.Text = "Sauvegarder vue";
            this.saveViewTSMI.Click += new System.EventHandler(this.saveViewTSMI_Click);
            // 
            // quitTSMI
            // 
            this.quitTSMI.Name = "quitTSMI";
            this.quitTSMI.Size = new System.Drawing.Size(161, 22);
            this.quitTSMI.Text = "Quitter";
            // 
            // dbEditTSMI
            // 
            this.dbEditTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSMI,
            this.updateTSMI,
            this.deleteTSMI});
            this.dbEditTSMI.Name = "dbEditTSMI";
            this.dbEditTSMI.Size = new System.Drawing.Size(152, 20);
            this.dbEditTSMI.Text = "Éditer la base de données";
            // 
            // addTSMI
            // 
            this.addTSMI.Name = "addTSMI";
            this.addTSMI.Size = new System.Drawing.Size(129, 22);
            this.addTSMI.Text = "Ajouter";
            this.addTSMI.Click += new System.EventHandler(this.addTSMI_Click);
            // 
            // updateTSMI
            // 
            this.updateTSMI.Name = "updateTSMI";
            this.updateTSMI.Size = new System.Drawing.Size(129, 22);
            this.updateTSMI.Text = "Modifier";
            // 
            // deleteTSMI
            // 
            this.deleteTSMI.Name = "deleteTSMI";
            this.deleteTSMI.Size = new System.Drawing.Size(129, 22);
            this.deleteTSMI.Text = "Supprimer";
            // 
            // viewTSMI
            // 
            this.viewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTSMI,
            this.hideTSMI});
            this.viewTSMI.Name = "viewTSMI";
            this.viewTSMI.Size = new System.Drawing.Size(39, 20);
            this.viewTSMI.Text = "Vue";
            // 
            // showTSMI
            // 
            this.showTSMI.Name = "showTSMI";
            this.showTSMI.Size = new System.Drawing.Size(117, 22);
            this.showTSMI.Text = "Montrer";
            // 
            // hideTSMI
            // 
            this.hideTSMI.Name = "hideTSMI";
            this.hideTSMI.Size = new System.Drawing.Size(117, 22);
            this.hideTSMI.Text = "Cacher";
            // 
            // helpTSMI
            // 
            this.helpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTSMI,
            this.aboutTSMI});
            this.helpTSMI.Name = "helpTSMI";
            this.helpTSMI.Size = new System.Drawing.Size(24, 20);
            this.helpTSMI.Text = "?";
            // 
            // supportTSMI
            // 
            this.supportTSMI.Name = "supportTSMI";
            this.supportTSMI.Size = new System.Drawing.Size(107, 22);
            this.supportTSMI.Text = "Aide";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(107, 22);
            this.aboutTSMI.Text = "About";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveImage.Location = new System.Drawing.Point(7, 423);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(76, 32);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Sauvegarder";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZoom.Location = new System.Drawing.Point(-9, 36);
            this.tbZoom.Maximum = 200;
            this.tbZoom.Minimum = 5;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbZoom.Size = new System.Drawing.Size(45, 386);
            this.tbZoom.TabIndex = 2;
            this.tbZoom.TickFrequency = 10;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbZoom.Value = 10;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.Location = new System.Drawing.Point(82, 431);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(402, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.TickFrequency = 10;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPicker.Location = new System.Drawing.Point(268, 29);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 4;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(331, 55);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(68, 47);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(405, 55);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 47);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlayBackwards
            // 
            this.btnPlayBackwards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayBackwards.Location = new System.Drawing.Point(257, 55);
            this.btnPlayBackwards.Name = "btnPlayBackwards";
            this.btnPlayBackwards.Size = new System.Drawing.Size(68, 47);
            this.btnPlayBackwards.TabIndex = 7;
            this.btnPlayBackwards.Text = "Play Backwards";
            this.btnPlayBackwards.UseVisualStyleBackColor = true;
            this.btnPlayBackwards.Click += new System.EventHandler(this.btnPlayBackwards_Click);
            // 
            // grbxMove
            // 
            this.grbxMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxMove.Controls.Add(this.btnLeft);
            this.grbxMove.Controls.Add(this.btnDown);
            this.grbxMove.Controls.Add(this.btnRight);
            this.grbxMove.Controls.Add(this.btnUp);
            this.grbxMove.Location = new System.Drawing.Point(384, 312);
            this.grbxMove.Name = "grbxMove";
            this.grbxMove.Size = new System.Drawing.Size(88, 95);
            this.grbxMove.TabIndex = 8;
            this.grbxMove.TabStop = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(7, 37);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 25);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(32, 62);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(57, 37);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 25);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(32, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblInfoAge
            // 
            this.lblInfoAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoAge.AutoSize = true;
            this.lblInfoAge.Location = new System.Drawing.Point(27, 407);
            this.lblInfoAge.Name = "lblInfoAge";
            this.lblInfoAge.Size = new System.Drawing.Size(82, 13);
            this.lblInfoAge.TabIndex = 9;
            this.lblInfoAge.Text = "Age de l\'univers";
            // 
            // lblInfoZoom
            // 
            this.lblInfoZoom.AutoSize = true;
            this.lblInfoZoom.Location = new System.Drawing.Point(-1, 27);
            this.lblInfoZoom.Name = "lblInfoZoom";
            this.lblInfoZoom.Size = new System.Drawing.Size(34, 13);
            this.lblInfoZoom.TabIndex = 10;
            this.lblInfoZoom.Text = "Zoom";
            // 
            // lblInfoSpeed
            // 
            this.lblInfoSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoSpeed.AutoSize = true;
            this.lblInfoSpeed.Location = new System.Drawing.Point(358, 415);
            this.lblInfoSpeed.Name = "lblInfoSpeed";
            this.lblInfoSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblInfoSpeed.TabIndex = 11;
            this.lblInfoSpeed.Text = "Vitesse";
            // 
            // Time
            // 
            this.Time.Interval = 10;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // SpaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.lblInfoSpeed);
            this.Controls.Add(this.lblInfoZoom);
            this.Controls.Add(this.lblInfoAge);
            this.Controls.Add(this.grbxMove);
            this.Controls.Add(this.btnPlayBackwards);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SpaceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Simulator";
            this.Load += new System.EventHandler(this.SpaceView_Load);
            this.Resize += new System.EventHandler(this.SpaceView_Resize);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.grbxMove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem dbEditTSMI;
        private System.Windows.Forms.ToolStripMenuItem viewTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpTSMI;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlayBackwards;
        private System.Windows.Forms.GroupBox grbxMove;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblInfoAge;
        private System.Windows.Forms.Label lblInfoZoom;
        private System.Windows.Forms.Label lblInfoSpeed;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ToolStripMenuItem supportTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStripMenuItem showTSMI;
        private System.Windows.Forms.ToolStripMenuItem hideTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem quitTSMI;
        private System.Windows.Forms.ToolStripMenuItem addTSMI;
        private System.Windows.Forms.ToolStripMenuItem updateTSMI;
        private System.Windows.Forms.ToolStripMenuItem deleteTSMI;
    }
}

