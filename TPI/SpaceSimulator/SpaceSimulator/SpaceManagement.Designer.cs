namespace SpaceSimulator
{
    partial class SpaceManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceManagement));
            this.tbxStarId = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxRay = new System.Windows.Forms.TextBox();
            this.tbxPeriod = new System.Windows.Forms.TextBox();
            this.tbxDistanceToOrbit = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRay = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDistanceToOrbit = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxStarId
            // 
            this.tbxStarId.Location = new System.Drawing.Point(178, 15);
            this.tbxStarId.Name = "tbxStarId";
            this.tbxStarId.Size = new System.Drawing.Size(100, 20);
            this.tbxStarId.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(178, 41);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxRay
            // 
            this.tbxRay.Location = new System.Drawing.Point(178, 67);
            this.tbxRay.Name = "tbxRay";
            this.tbxRay.Size = new System.Drawing.Size(100, 20);
            this.tbxRay.TabIndex = 2;
            // 
            // tbxPeriod
            // 
            this.tbxPeriod.Location = new System.Drawing.Point(178, 93);
            this.tbxPeriod.Name = "tbxPeriod";
            this.tbxPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbxPeriod.TabIndex = 3;
            // 
            // tbxDistanceToOrbit
            // 
            this.tbxDistanceToOrbit.Location = new System.Drawing.Point(178, 119);
            this.tbxDistanceToOrbit.Name = "tbxDistanceToOrbit";
            this.tbxDistanceToOrbit.Size = new System.Drawing.Size(100, 20);
            this.tbxDistanceToOrbit.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(157, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(139, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "name";
            // 
            // lblRay
            // 
            this.lblRay.AutoSize = true;
            this.lblRay.Location = new System.Drawing.Point(125, 70);
            this.lblRay.Name = "lblRay";
            this.lblRay.Size = new System.Drawing.Size(49, 13);
            this.lblRay.TabIndex = 7;
            this.lblRay.Text = "Ray (km)";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(111, 96);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(63, 13);
            this.lblPeriod.TabIndex = 8;
            this.lblPeriod.Text = "Period (day)";
            // 
            // lblDistanceToOrbit
            // 
            this.lblDistanceToOrbit.AutoSize = true;
            this.lblDistanceToOrbit.Location = new System.Drawing.Point(69, 122);
            this.lblDistanceToOrbit.Name = "lblDistanceToOrbit";
            this.lblDistanceToOrbit.Size = new System.Drawing.Size(105, 13);
            this.lblDistanceToOrbit.TabIndex = 9;
            this.lblDistanceToOrbit.Text = "distance to orbit (gm)";
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::SpaceSimulator.Properties.Resources.Vue2DSolarSystem;
            this.pbxImage.Location = new System.Drawing.Point(7, 9);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(100, 100);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 10;
            this.pbxImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Parcourir";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 119);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(35, 13);
            this.lblImage.TabIndex = 13;
            this.lblImage.Text = "image";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // SpaceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblDistanceToOrbit);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblRay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxDistanceToOrbit);
            this.Controls.Add(this.tbxPeriod);
            this.Controls.Add(this.tbxRay);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxStarId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 225);
            this.MinimumSize = new System.Drawing.Size(300, 225);
            this.Name = "SpaceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Space Management";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStarId;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxRay;
        private System.Windows.Forms.TextBox tbxPeriod;
        private System.Windows.Forms.TextBox tbxDistanceToOrbit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRay;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDistanceToOrbit;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}