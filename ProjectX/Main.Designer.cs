namespace ProjectX
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTravelPackages = new ProjectX.RoundButton();
            this.btnItineraryBuilder = new ProjectX.RoundButton();
            this.btnSignOut = new ProjectX.RoundButton();
            this.btnReportsAnalytics = new ProjectX.RoundButton();
            this.btnBookings = new ProjectX.RoundButton();
            this.btnTransportation = new ProjectX.RoundButton();
            this.btnAccommodations = new ProjectX.RoundButton();
            this.btnDestinations = new ProjectX.RoundButton();
            this.btnCustomerProfiles = new ProjectX.RoundButton();
            this.btnUserManagement = new ProjectX.RoundButton();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlSidebar.Controls.Add(this.btnTravelPackages);
            this.pnlSidebar.Controls.Add(this.btnItineraryBuilder);
            this.pnlSidebar.Controls.Add(this.btnSignOut);
            this.pnlSidebar.Controls.Add(this.btnReportsAnalytics);
            this.pnlSidebar.Controls.Add(this.btnBookings);
            this.pnlSidebar.Controls.Add(this.btnTransportation);
            this.pnlSidebar.Controls.Add(this.btnAccommodations);
            this.pnlSidebar.Controls.Add(this.btnDestinations);
            this.pnlSidebar.Controls.Add(this.btnCustomerProfiles);
            this.pnlSidebar.Controls.Add(this.btnUserManagement);
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 761);
            this.pnlSidebar.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(20, -11);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblHr);
            this.pnlTopBar.Controls.Add(this.lblWelcomeUser);
            this.pnlTopBar.Controls.Add(this.lblTopBar);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(240, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1024, 80);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblHr
            // 
            this.lblHr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHr.Location = new System.Drawing.Point(-14, 79);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(1054, 10);
            this.lblHr.TabIndex = 2;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(505, 0);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Padding = new System.Windows.Forms.Padding(10);
            this.lblWelcomeUser.Size = new System.Drawing.Size(519, 80);
            this.lblWelcomeUser.TabIndex = 1;
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTopBar
            // 
            this.lblTopBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTopBar.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.Location = new System.Drawing.Point(0, 0);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTopBar.Size = new System.Drawing.Size(499, 80);
            this.lblTopBar.TabIndex = 0;
            this.lblTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(240, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 681);
            this.pnlMain.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTravelPackages
            // 
            this.btnTravelPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnTravelPackages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnTravelPackages.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnTravelPackages.BorderRadius = 0;
            this.btnTravelPackages.BorderSize = 0;
            this.btnTravelPackages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravelPackages.FlatAppearance.BorderSize = 0;
            this.btnTravelPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravelPackages.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravelPackages.ForeColor = System.Drawing.Color.White;
            this.btnTravelPackages.Location = new System.Drawing.Point(0, 381);
            this.btnTravelPackages.Name = "btnTravelPackages";
            this.btnTravelPackages.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTravelPackages.Size = new System.Drawing.Size(240, 40);
            this.btnTravelPackages.TabIndex = 19;
            this.btnTravelPackages.Text = "TRAVEL PACKAGES";
            this.btnTravelPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravelPackages.TextColor = System.Drawing.Color.White;
            this.btnTravelPackages.UseVisualStyleBackColor = false;
            this.btnTravelPackages.Click += new System.EventHandler(this.btnTravelPackages_Click);
            // 
            // btnItineraryBuilder
            // 
            this.btnItineraryBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnItineraryBuilder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnItineraryBuilder.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnItineraryBuilder.BorderRadius = 0;
            this.btnItineraryBuilder.BorderSize = 0;
            this.btnItineraryBuilder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItineraryBuilder.FlatAppearance.BorderSize = 0;
            this.btnItineraryBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItineraryBuilder.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItineraryBuilder.ForeColor = System.Drawing.Color.White;
            this.btnItineraryBuilder.Location = new System.Drawing.Point(0, 427);
            this.btnItineraryBuilder.Name = "btnItineraryBuilder";
            this.btnItineraryBuilder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnItineraryBuilder.Size = new System.Drawing.Size(240, 40);
            this.btnItineraryBuilder.TabIndex = 18;
            this.btnItineraryBuilder.Text = "ITINERARY BUILDER";
            this.btnItineraryBuilder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItineraryBuilder.TextColor = System.Drawing.Color.White;
            this.btnItineraryBuilder.UseVisualStyleBackColor = false;
            this.btnItineraryBuilder.Click += new System.EventHandler(this.btnItineraryBuilder_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnSignOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnSignOut.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSignOut.BorderRadius = 22;
            this.btnSignOut.BorderSize = 0;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(20, 688);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(200, 44);
            this.btnSignOut.TabIndex = 16;
            this.btnSignOut.Text = "S I G N  O U T";
            this.btnSignOut.TextColor = System.Drawing.Color.Black;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnReportsAnalytics
            // 
            this.btnReportsAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnReportsAnalytics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnReportsAnalytics.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnReportsAnalytics.BorderRadius = 0;
            this.btnReportsAnalytics.BorderSize = 0;
            this.btnReportsAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportsAnalytics.FlatAppearance.BorderSize = 0;
            this.btnReportsAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsAnalytics.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnReportsAnalytics.Location = new System.Drawing.Point(0, 519);
            this.btnReportsAnalytics.Name = "btnReportsAnalytics";
            this.btnReportsAnalytics.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReportsAnalytics.Size = new System.Drawing.Size(240, 40);
            this.btnReportsAnalytics.TabIndex = 15;
            this.btnReportsAnalytics.Text = "REPORTS / ANALYTICS";
            this.btnReportsAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportsAnalytics.TextColor = System.Drawing.Color.White;
            this.btnReportsAnalytics.UseVisualStyleBackColor = false;
            this.btnReportsAnalytics.Click += new System.EventHandler(this.btnReportsAnalytics_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnBookings.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBookings.BorderRadius = 0;
            this.btnBookings.BorderSize = 0;
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Location = new System.Drawing.Point(0, 473);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBookings.Size = new System.Drawing.Size(240, 40);
            this.btnBookings.TabIndex = 14;
            this.btnBookings.Text = "BOOKINGS";
            this.btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.TextColor = System.Drawing.Color.White;
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnTransportation
            // 
            this.btnTransportation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnTransportation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnTransportation.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransportation.BorderRadius = 0;
            this.btnTransportation.BorderSize = 0;
            this.btnTransportation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransportation.FlatAppearance.BorderSize = 0;
            this.btnTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransportation.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportation.ForeColor = System.Drawing.Color.White;
            this.btnTransportation.Location = new System.Drawing.Point(0, 335);
            this.btnTransportation.Name = "btnTransportation";
            this.btnTransportation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransportation.Size = new System.Drawing.Size(240, 40);
            this.btnTransportation.TabIndex = 12;
            this.btnTransportation.Text = "TRANSPORTATION";
            this.btnTransportation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransportation.TextColor = System.Drawing.Color.White;
            this.btnTransportation.UseVisualStyleBackColor = false;
            this.btnTransportation.Click += new System.EventHandler(this.btnTransportation_Click);
            // 
            // btnAccommodations
            // 
            this.btnAccommodations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAccommodations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAccommodations.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccommodations.BorderRadius = 0;
            this.btnAccommodations.BorderSize = 0;
            this.btnAccommodations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccommodations.FlatAppearance.BorderSize = 0;
            this.btnAccommodations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccommodations.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccommodations.ForeColor = System.Drawing.Color.White;
            this.btnAccommodations.Location = new System.Drawing.Point(0, 289);
            this.btnAccommodations.Name = "btnAccommodations";
            this.btnAccommodations.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAccommodations.Size = new System.Drawing.Size(240, 40);
            this.btnAccommodations.TabIndex = 11;
            this.btnAccommodations.Text = "ACCOMMODATIONS";
            this.btnAccommodations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccommodations.TextColor = System.Drawing.Color.White;
            this.btnAccommodations.UseVisualStyleBackColor = false;
            this.btnAccommodations.Click += new System.EventHandler(this.btnAccommodations_Click);
            // 
            // btnDestinations
            // 
            this.btnDestinations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnDestinations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnDestinations.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnDestinations.BorderRadius = 0;
            this.btnDestinations.BorderSize = 0;
            this.btnDestinations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestinations.FlatAppearance.BorderSize = 0;
            this.btnDestinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinations.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinations.ForeColor = System.Drawing.Color.White;
            this.btnDestinations.Location = new System.Drawing.Point(0, 243);
            this.btnDestinations.Name = "btnDestinations";
            this.btnDestinations.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDestinations.Size = new System.Drawing.Size(240, 40);
            this.btnDestinations.TabIndex = 9;
            this.btnDestinations.Text = "DESTINATIONS";
            this.btnDestinations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestinations.TextColor = System.Drawing.Color.White;
            this.btnDestinations.UseVisualStyleBackColor = false;
            this.btnDestinations.Click += new System.EventHandler(this.btnDestinations_Click);
            // 
            // btnCustomerProfiles
            // 
            this.btnCustomerProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCustomerProfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCustomerProfiles.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCustomerProfiles.BorderRadius = 0;
            this.btnCustomerProfiles.BorderSize = 0;
            this.btnCustomerProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerProfiles.FlatAppearance.BorderSize = 0;
            this.btnCustomerProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerProfiles.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerProfiles.ForeColor = System.Drawing.Color.White;
            this.btnCustomerProfiles.Location = new System.Drawing.Point(0, 197);
            this.btnCustomerProfiles.Name = "btnCustomerProfiles";
            this.btnCustomerProfiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCustomerProfiles.Size = new System.Drawing.Size(240, 40);
            this.btnCustomerProfiles.TabIndex = 8;
            this.btnCustomerProfiles.Text = "CUSTOMER PROFILES";
            this.btnCustomerProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerProfiles.TextColor = System.Drawing.Color.White;
            this.btnCustomerProfiles.UseVisualStyleBackColor = false;
            this.btnCustomerProfiles.Click += new System.EventHandler(this.btnCustomerProfiles_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUserManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUserManagement.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserManagement.BorderRadius = 0;
            this.btnUserManagement.BorderSize = 0;
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 151);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(240, 40);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.Text = "USER MANAGEMENT";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.TextColor = System.Drawing.Color.White;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "WANDER WORLD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picLogo;
        private RoundButton btnTransportation;
        private RoundButton btnAccommodations;
        private RoundButton btnDestinations;
        private RoundButton btnCustomerProfiles;
        private RoundButton btnUserManagement;
        private RoundButton btnReportsAnalytics;
        private RoundButton btnBookings;
        private System.Windows.Forms.Label lblHr;
        private RoundButton btnSignOut;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblWelcomeUser;
        private RoundButton btnItineraryBuilder;
        private System.Windows.Forms.Panel pnlMain;
        private RoundButton btnTravelPackages;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}