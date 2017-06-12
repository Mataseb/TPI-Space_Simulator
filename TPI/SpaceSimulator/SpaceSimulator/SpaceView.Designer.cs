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
            this.SpaceMenu = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dbEditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlanetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.followTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEllisesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideEllipsesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblInfoAge = new System.Windows.Forms.Label();
            this.lblInfoZoom = new System.Windows.Forms.Label();
            this.lblInfoSpeed = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPlayBackwards = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.SpaceMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.SpaceMenu.AutoSize = false;
            this.SpaceMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.SpaceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.dbEditTSMI,
            this.viewTSMI,
            this.supportTSMI});
            this.SpaceMenu.Location = new System.Drawing.Point(0, 0);
            this.SpaceMenu.Name = "Menu";
            this.SpaceMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SpaceMenu.Size = new System.Drawing.Size(280, 24);
            this.SpaceMenu.Stretch = false;
            this.SpaceMenu.TabIndex = 0;
            this.SpaceMenu.Text = "menu";
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
            this.quitTSMI.Click += new System.EventHandler(this.quitTSMI_Click);
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
            this.addTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlanetTSMI,
            this.addMoonTSMI});
            this.addTSMI.Name = "addTSMI";
            this.addTSMI.Size = new System.Drawing.Size(129, 22);
            this.addTSMI.Text = "Ajouter";
            // 
            // addPlanetTSMI
            // 
            this.addPlanetTSMI.Name = "addPlanetTSMI";
            this.addPlanetTSMI.Size = new System.Drawing.Size(113, 22);
            this.addPlanetTSMI.Text = "Planète";
            this.addPlanetTSMI.Click += new System.EventHandler(this.addPlanetTSMI_Click);
            // 
            // addMoonTSMI
            // 
            this.addMoonTSMI.Name = "addMoonTSMI";
            this.addMoonTSMI.Size = new System.Drawing.Size(113, 22);
            this.addMoonTSMI.Text = "Lune";
            this.addMoonTSMI.Click += new System.EventHandler(this.addMoonTSMI_Click);
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
            this.followTSMI,
            this.ellipsesToolStripMenuItem,
            this.showTSMI,
            this.hideTSMI});
            this.viewTSMI.Name = "viewTSMI";
            this.viewTSMI.Size = new System.Drawing.Size(39, 20);
            this.viewTSMI.Text = "Vue";
            // 
            // followTSMI
            // 
            this.followTSMI.Name = "followTSMI";
            this.followTSMI.Size = new System.Drawing.Size(117, 22);
            this.followTSMI.Text = "Suivre";
            // 
            // ellipsesToolStripMenuItem
            // 
            this.ellipsesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEllisesTSMI,
            this.hideEllipsesTSMI});
            this.ellipsesToolStripMenuItem.Name = "ellipsesToolStripMenuItem";
            this.ellipsesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ellipsesToolStripMenuItem.Text = "Ellipses";
            // 
            // showEllisesTSMI
            // 
            this.showEllisesTSMI.Name = "showEllisesTSMI";
            this.showEllisesTSMI.Size = new System.Drawing.Size(117, 22);
            this.showEllisesTSMI.Text = "Montrer";
            this.showEllisesTSMI.Click += new System.EventHandler(this.showEllisesTSMI_Click);
            // 
            // hideEllipsesTSMI
            // 
            this.hideEllipsesTSMI.Name = "hideEllipsesTSMI";
            this.hideEllipsesTSMI.Size = new System.Drawing.Size(117, 22);
            this.hideEllipsesTSMI.Text = "Cacher";
            this.hideEllipsesTSMI.Click += new System.EventHandler(this.hideEllipsesTSMI_Click);
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
            // supportTSMI
            // 
            this.supportTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTSMI,
            this.aboutTSMI});
            this.supportTSMI.Name = "supportTSMI";
            this.supportTSMI.Size = new System.Drawing.Size(24, 20);
            this.supportTSMI.Text = "?";
            // 
            // helpTSMI
            // 
            this.helpTSMI.Name = "helpTSMI";
            this.helpTSMI.Size = new System.Drawing.Size(107, 22);
            this.helpTSMI.Text = "Aide";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(107, 22);
            this.aboutTSMI.Text = "About";
            this.aboutTSMI.Click += new System.EventHandler(this.aboutTSMI_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoom.Location = new System.Drawing.Point(451, 18);
            this.tbZoom.Maximum = 200;
            this.tbZoom.Minimum = 5;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbZoom.Size = new System.Drawing.Size(45, 399);
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
            this.tbSpeed.Location = new System.Drawing.Point(-1, 423);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(437, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.TickFrequency = 10;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPicker.Location = new System.Drawing.Point(252, 33);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(182, 20);
            this.dtPicker.TabIndex = 4;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            this.dtPicker.Enter += new System.EventHandler(this.dtPicker_Enter);
            // 
            // lblInfoAge
            // 
            this.lblInfoAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoAge.Location = new System.Drawing.Point(292, 17);
            this.lblInfoAge.Name = "lblInfoAge";
            this.lblInfoAge.Size = new System.Drawing.Size(103, 13);
            this.lblInfoAge.TabIndex = 9;
            this.lblInfoAge.Text = "Age de l\'univers";
            this.lblInfoAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoAge.Visible = false;
            // 
            // lblInfoZoom
            // 
            this.lblInfoZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoZoom.AutoSize = true;
            this.lblInfoZoom.Location = new System.Drawing.Point(413, 9);
            this.lblInfoZoom.Name = "lblInfoZoom";
            this.lblInfoZoom.Size = new System.Drawing.Size(34, 13);
            this.lblInfoZoom.TabIndex = 10;
            this.lblInfoZoom.Text = "Zoom";
            // 
            // lblInfoSpeed
            // 
            this.lblInfoSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfoSpeed.AutoSize = true;
            this.lblInfoSpeed.Location = new System.Drawing.Point(0, 411);
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
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Fichier PNG (*.png) | *.png";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(7, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(27, 15);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // btnPlayBackwards
            // 
            this.btnPlayBackwards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayBackwards.BackgroundImage = global::SpaceSimulator.Properties.Resources.PlayBackwards;
            this.btnPlayBackwards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayBackwards.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPlayBackwards.FlatAppearance.BorderSize = 0;
            this.btnPlayBackwards.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlayBackwards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlayBackwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayBackwards.Location = new System.Drawing.Point(252, 59);
            this.btnPlayBackwards.Name = "btnPlayBackwards";
            this.btnPlayBackwards.Size = new System.Drawing.Size(60, 60);
            this.btnPlayBackwards.TabIndex = 7;
            this.btnPlayBackwards.UseVisualStyleBackColor = true;
            this.btnPlayBackwards.Click += new System.EventHandler(this.btnPlayBackwards_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(374, 59);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(313, 59);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.BackgroundImage = global::SpaceSimulator.Properties.Resources.Save;
            this.btnSaveImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveImage.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Location = new System.Drawing.Point(440, 418);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(40, 40);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // SpaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblInfoSpeed);
            this.Controls.Add(this.lblInfoZoom);
            this.Controls.Add(this.lblInfoAge);
            this.Controls.Add(this.btnPlayBackwards);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.SpaceMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SpaceMenu;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SpaceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpaceView_FormClosing);
            this.Load += new System.EventHandler(this.SpaceView_Load);
            this.Resize += new System.EventHandler(this.SpaceView_Resize);
            this.SpaceMenu.ResumeLayout(false);
            this.SpaceMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SpaceMenu;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem dbEditTSMI;
        private System.Windows.Forms.ToolStripMenuItem viewTSMI;
        private System.Windows.Forms.ToolStripMenuItem supportTSMI;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlayBackwards;
        private System.Windows.Forms.Label lblInfoAge;
        private System.Windows.Forms.Label lblInfoZoom;
        private System.Windows.Forms.Label lblInfoSpeed;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ToolStripMenuItem helpTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStripMenuItem showTSMI;
        private System.Windows.Forms.ToolStripMenuItem hideTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem quitTSMI;
        private System.Windows.Forms.ToolStripMenuItem followTSMI;
        private System.Windows.Forms.ToolStripMenuItem addTSMI;
        private System.Windows.Forms.ToolStripMenuItem addPlanetTSMI;
        private System.Windows.Forms.ToolStripMenuItem addMoonTSMI;
        private System.Windows.Forms.ToolStripMenuItem updateTSMI;
        private System.Windows.Forms.ToolStripMenuItem deleteTSMI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripMenuItem ellipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEllisesTSMI;
        private System.Windows.Forms.ToolStripMenuItem hideEllipsesTSMI;
    }
}

