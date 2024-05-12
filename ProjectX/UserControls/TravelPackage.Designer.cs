namespace ProjectX.UserControls
{
    partial class TravelPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelPackage));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblItineraryID = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconPictureBox();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.picBar = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnBookNow = new ProjectX.RoundButton();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(335, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(337, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(495, 35);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlContent.Controls.Add(this.btnEdit);
            this.pnlContent.Controls.Add(this.lblNumPeople);
            this.pnlContent.Controls.Add(this.lblNumDays);
            this.pnlContent.Controls.Add(this.btnBookNow);
            this.pnlContent.Controls.Add(this.lblDescription);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.picBar);
            this.pnlContent.Controls.Add(this.picImage);
            this.pnlContent.Controls.Add(this.lblItineraryID);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 15);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(870, 180);
            this.pnlContent.TabIndex = 0;
            // 
            // lblItineraryID
            // 
            this.lblItineraryID.AutoSize = true;
            this.lblItineraryID.Location = new System.Drawing.Point(747, 138);
            this.lblItineraryID.Name = "lblItineraryID";
            this.lblItineraryID.Size = new System.Drawing.Size(55, 13);
            this.lblItineraryID.TabIndex = 21;
            this.lblItineraryID.Text = "ItineraryID";
            this.lblItineraryID.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 18;
            this.btnEdit.Location = new System.Drawing.Point(838, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(18, 20);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.ForeColor = System.Drawing.Color.White;
            this.lblNumPeople.Location = new System.Drawing.Point(337, 138);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(127, 16);
            this.lblNumPeople.TabIndex = 19;
            this.lblNumPeople.Text = "Number of Attendees: ";
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDays.ForeColor = System.Drawing.Color.White;
            this.lblNumDays.Location = new System.Drawing.Point(337, 122);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(99, 16);
            this.lblNumDays.TabIndex = 18;
            this.lblNumDays.Text = "Number of Days: ";
            // 
            // picBar
            // 
            this.picBar.BackColor = System.Drawing.Color.White;
            this.picBar.Image = ((System.Drawing.Image)(resources.GetObject("picBar.Image")));
            this.picBar.Location = new System.Drawing.Point(292, 0);
            this.picBar.Name = "picBar";
            this.picBar.Size = new System.Drawing.Size(27, 180);
            this.picBar.TabIndex = 1;
            this.picBar.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(319, 180);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnBookNow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnBookNow.BorderColor = System.Drawing.Color.Black;
            this.btnBookNow.BorderRadius = 20;
            this.btnBookNow.BorderSize = 1;
            this.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookNow.ForeColor = System.Drawing.Color.Black;
            this.btnBookNow.Location = new System.Drawing.Point(697, 125);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(159, 40);
            this.btnBookNow.TabIndex = 17;
            this.btnBookNow.Text = "B O O K   N O W";
            this.btnBookNow.TextColor = System.Drawing.Color.Black;
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // TravelPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Name = "TravelPackage";
            this.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.Size = new System.Drawing.Size(870, 210);
            this.Load += new System.EventHandler(this.TravelPackage_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblNumPeople;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.PictureBox picBar;
        private System.Windows.Forms.PictureBox picImage;
        private FontAwesome.Sharp.IconPictureBox btnEdit;
        private System.Windows.Forms.Label lblItineraryID;
        private RoundButton btnBookNow;
    }
}
