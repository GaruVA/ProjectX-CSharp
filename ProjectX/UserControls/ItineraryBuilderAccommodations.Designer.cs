namespace ProjectX.UserControls
{
    partial class ItineraryBuilderAccommodations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItineraryBuilderAccommodations));
            this.pnlRow = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlRowDetails = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlRowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRow
            // 
            this.pnlRow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRow.AutoSize = true;
            this.pnlRow.BackColor = System.Drawing.Color.White;
            this.pnlRow.Controls.Add(this.picImage);
            this.pnlRow.Controls.Add(this.pnlRowDetails);
            this.pnlRow.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRow.Location = new System.Drawing.Point(11, 20);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(597, 373);
            this.pnlRow.TabIndex = 3;
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(594, 249);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 11;
            this.picImage.TabStop = false;
            // 
            // pnlRowDetails
            // 
            this.pnlRowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlRowDetails.Controls.Add(this.lblCategory);
            this.pnlRowDetails.Controls.Add(this.lblAdress);
            this.pnlRowDetails.Controls.Add(this.btnDelete);
            this.pnlRowDetails.Controls.Add(this.lblDescription);
            this.pnlRowDetails.Controls.Add(this.lblName);
            this.pnlRowDetails.Location = new System.Drawing.Point(0, 255);
            this.pnlRowDetails.Name = "pnlRowDetails";
            this.pnlRowDetails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlRowDetails.Size = new System.Drawing.Size(594, 115);
            this.pnlRowDetails.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(7, 27);
            this.lblCategory.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(53, 14);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category";
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(4, 89);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(56, 16);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "Address";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 18;
            this.btnDelete.Location = new System.Drawing.Point(564, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(18, 20);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(6, 53);
            this.lblDescription.MaximumSize = new System.Drawing.Size(582, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(582, 32);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // ItineraryBuilderAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRow);
            this.Name = "ItineraryBuilderAccommodations";
            this.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.Size = new System.Drawing.Size(619, 396);
            this.Load += new System.EventHandler(this.ItineraryBuilderAccommodations_Load);
            this.pnlRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlRowDetails.ResumeLayout(false);
            this.pnlRowDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRow;
        private System.Windows.Forms.Panel pnlRowDetails;
        private System.Windows.Forms.Label lblAdress;
        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox picImage;
    }
}
