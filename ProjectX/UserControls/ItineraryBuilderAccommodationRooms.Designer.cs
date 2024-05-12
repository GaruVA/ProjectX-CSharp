namespace ProjectX.UserControls
{
    partial class ItineraryBuilderAccommodationRooms
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
            this.pnlRow = new System.Windows.Forms.Panel();
            this.pnlRowDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.cmbSelectAmount = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlRow.SuspendLayout();
            this.pnlRowDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRow
            // 
            this.pnlRow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRow.BackColor = System.Drawing.Color.White;
            this.pnlRow.Controls.Add(this.pnlRowDetails);
            this.pnlRow.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRow.Location = new System.Drawing.Point(9, 0);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(600, 135);
            this.pnlRow.TabIndex = 4;
            // 
            // pnlRowDetails
            // 
            this.pnlRowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlRowDetails.Controls.Add(this.label1);
            this.pnlRowDetails.Controls.Add(this.lblSelectAmount);
            this.pnlRowDetails.Controls.Add(this.cmbSelectAmount);
            this.pnlRowDetails.Controls.Add(this.lblPrice);
            this.pnlRowDetails.Controls.Add(this.lblCapacity);
            this.pnlRowDetails.Controls.Add(this.lblDescription);
            this.pnlRowDetails.Controls.Add(this.lblName);
            this.pnlRowDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlRowDetails.Name = "pnlRowDetails";
            this.pnlRowDetails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlRowDetails.Size = new System.Drawing.Size(594, 129);
            this.pnlRowDetails.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 16;
            this.label1.Visible = false;
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAmount.Location = new System.Drawing.Point(428, 13);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(101, 16);
            this.lblSelectAmount.TabIndex = 15;
            this.lblSelectAmount.Text = "Select Amount:";
            // 
            // cmbSelectAmount
            // 
            this.cmbSelectAmount.FormattingEnabled = true;
            this.cmbSelectAmount.Location = new System.Drawing.Point(535, 10);
            this.cmbSelectAmount.Name = "cmbSelectAmount";
            this.cmbSelectAmount.Size = new System.Drawing.Size(41, 21);
            this.cmbSelectAmount.TabIndex = 14;
            this.cmbSelectAmount.SelectedIndexChanged += new System.EventHandler(this.cmbSelectAmount_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price: ";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(7, 76);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(121, 16);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "Number of Guest: ";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 40);
            this.lblDescription.MaximumSize = new System.Drawing.Size(580, 35);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(574, 35);
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
            // ItineraryBuilderAccommodationRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRow);
            this.Name = "ItineraryBuilderAccommodationRooms";
            this.Size = new System.Drawing.Size(619, 138);
            this.Load += new System.EventHandler(this.ItineraryBuilderAccommodationRooms_Load);
            this.pnlRow.ResumeLayout(false);
            this.pnlRowDetails.ResumeLayout(false);
            this.pnlRowDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRow;
        private System.Windows.Forms.Panel pnlRowDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.ComboBox cmbSelectAmount;
        private System.Windows.Forms.Label label1;
    }
}
