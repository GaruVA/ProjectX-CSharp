namespace ProjectX.UserControls
{
    partial class ItineraryBuilderTransportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItineraryBuilderTransportation));
            this.pnlRow = new System.Windows.Forms.Panel();
            this.pnlRowDetails = new System.Windows.Forms.Panel();
            this.lblPricePerKM = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlRow.SuspendLayout();
            this.pnlRowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRow
            // 
            this.pnlRow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRow.BackColor = System.Drawing.Color.White;
            this.pnlRow.Controls.Add(this.pnlRowDetails);
            this.pnlRow.Controls.Add(this.picImage);
            this.pnlRow.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRow.Location = new System.Drawing.Point(58, 18);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(594, 446);
            this.pnlRow.TabIndex = 3;
            // 
            // pnlRowDetails
            // 
            this.pnlRowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlRowDetails.Controls.Add(this.lblPricePerKM);
            this.pnlRowDetails.Controls.Add(this.lblCapacity);
            this.pnlRowDetails.Controls.Add(this.lblBasePrice);
            this.pnlRowDetails.Controls.Add(this.lblType);
            this.pnlRowDetails.Controls.Add(this.lblDescription);
            this.pnlRowDetails.Controls.Add(this.btnDelete);
            this.pnlRowDetails.Controls.Add(this.lblName);
            this.pnlRowDetails.Location = new System.Drawing.Point(0, 258);
            this.pnlRowDetails.Name = "pnlRowDetails";
            this.pnlRowDetails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlRowDetails.Size = new System.Drawing.Size(594, 186);
            this.pnlRowDetails.TabIndex = 9;
            // 
            // lblPricePerKM
            // 
            this.lblPricePerKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPricePerKM.AutoSize = true;
            this.lblPricePerKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerKM.Location = new System.Drawing.Point(7, 133);
            this.lblPricePerKM.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblPricePerKM.Name = "lblPricePerKM";
            this.lblPricePerKM.Size = new System.Drawing.Size(97, 16);
            this.lblPricePerKM.TabIndex = 20;
            this.lblPricePerKM.Text = "Price Per KM:  ";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(7, 105);
            this.lblCapacity.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(188, 16);
            this.lblCapacity.TabIndex = 19;
            this.lblCapacity.Text = "Max. Number of Passengers: ";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(7, 160);
            this.lblBasePrice.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(81, 16);
            this.lblBasePrice.TabIndex = 18;
            this.lblBasePrice.Text = "Base Price:  ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(7, 31);
            this.lblType.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(30, 14);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 57);
            this.lblDescription.MaximumSize = new System.Drawing.Size(580, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(580, 36);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
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
            this.btnDelete.Location = new System.Drawing.Point(563, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(18, 20);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(0, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(594, 249);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // ItineraryBuilderTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRow);
            this.Name = "ItineraryBuilderTransportation";
            this.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.Size = new System.Drawing.Size(704, 482);
            this.Load += new System.EventHandler(this.ItineraryBuilderTransportation_Load);
            this.pnlRow.ResumeLayout(false);
            this.pnlRowDetails.ResumeLayout(false);
            this.pnlRowDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRow;
        private System.Windows.Forms.Panel pnlRowDetails;
        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblPricePerKM;
        private System.Windows.Forms.Label lblCapacity;
    }
}
