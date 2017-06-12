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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxRay = new System.Windows.Forms.TextBox();
            this.tbxPeriod = new System.Windows.Forms.TextBox();
            this.tbxDistanceToOrbit = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRay = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDistanceToOrbit = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.cbxOrbitCenter = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Location = new System.Drawing.Point(116, 76);
            this.tbxName.MaxLength = 20;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(151, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxRay
            // 
            this.tbxRay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRay.Location = new System.Drawing.Point(116, 115);
            this.tbxRay.Name = "tbxRay";
            this.tbxRay.Size = new System.Drawing.Size(151, 20);
            this.tbxRay.TabIndex = 2;
            this.tbxRay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRay_KeyPress);
            // 
            // tbxPeriod
            // 
            this.tbxPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPeriod.Location = new System.Drawing.Point(116, 154);
            this.tbxPeriod.Name = "tbxPeriod";
            this.tbxPeriod.Size = new System.Drawing.Size(151, 20);
            this.tbxPeriod.TabIndex = 3;
            this.tbxPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPeriod_KeyPress);
            // 
            // tbxDistanceToOrbit
            // 
            this.tbxDistanceToOrbit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDistanceToOrbit.Location = new System.Drawing.Point(116, 193);
            this.tbxDistanceToOrbit.Name = "tbxDistanceToOrbit";
            this.tbxDistanceToOrbit.Size = new System.Drawing.Size(151, 20);
            this.tbxDistanceToOrbit.TabIndex = 4;
            this.tbxDistanceToOrbit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDistanceToOrbit_KeyPress);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nom";
            // 
            // lblRay
            // 
            this.lblRay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRay.AutoSize = true;
            this.lblRay.Location = new System.Drawing.Point(113, 99);
            this.lblRay.Name = "lblRay";
            this.lblRay.Size = new System.Drawing.Size(109, 13);
            this.lblRay.TabIndex = 7;
            this.lblRay.Text = "Rayon (en kilomètres)";
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(113, 138);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(160, 13);
            this.lblPeriod.TabIndex = 8;
            this.lblPeriod.Text = "Durée d\'une révolution (en jours)";
            // 
            // lblDistanceToOrbit
            // 
            this.lblDistanceToOrbit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistanceToOrbit.AutoSize = true;
            this.lblDistanceToOrbit.Location = new System.Drawing.Point(73, 177);
            this.lblDistanceToOrbit.Name = "lblDistanceToOrbit";
            this.lblDistanceToOrbit.Size = new System.Drawing.Size(200, 13);
            this.lblDistanceToOrbit.TabIndex = 9;
            this.lblDistanceToOrbit.Text = "Distance du centre orbital (en gigamètres";
            // 
            // pbxImage
            // 
            this.pbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImage.Image = global::SpaceSimulator.Properties.Resources.Vue2DSolarSystem;
            this.pbxImage.Location = new System.Drawing.Point(7, 25);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(100, 100);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 10;
            this.pbxImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(15, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(7, 138);
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
            this.lblImage.Location = new System.Drawing.Point(12, 9);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(35, 13);
            this.lblImage.TabIndex = 13;
            this.lblImage.Text = "image";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // cbxOrbitCenter
            // 
            this.cbxOrbitCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrbitCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrbitCenter.FormattingEnabled = true;
            this.cbxOrbitCenter.Location = new System.Drawing.Point(116, 25);
            this.cbxOrbitCenter.Name = "cbxOrbitCenter";
            this.cbxOrbitCenter.Size = new System.Drawing.Size(150, 21);
            this.cbxOrbitCenter.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(114, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Centre de l\'orbite";
            // 
            // SpaceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbxOrbitCenter);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblDistanceToOrbit);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblRay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxDistanceToOrbit);
            this.Controls.Add(this.tbxPeriod);
            this.Controls.Add(this.tbxRay);
            this.Controls.Add(this.tbxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SpaceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Space Management";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxRay;
        private System.Windows.Forms.TextBox tbxPeriod;
        private System.Windows.Forms.TextBox tbxDistanceToOrbit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRay;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDistanceToOrbit;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.ComboBox cbxOrbitCenter;
        private System.Windows.Forms.Label lblId;
    }
}