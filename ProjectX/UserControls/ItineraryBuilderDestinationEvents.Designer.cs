namespace ProjectX.UserControls
{
    partial class ItineraryBuilderDestinationEvents
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
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
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
            this.pnlRow.Location = new System.Drawing.Point(9, 1);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(600, 156);
            this.pnlRow.TabIndex = 5;
            // 
            // pnlRowDetails
            // 
            this.pnlRowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlRowDetails.Controls.Add(this.chkAdd);
            this.pnlRowDetails.Controls.Add(this.lblEndDate);
            this.pnlRowDetails.Controls.Add(this.label1);
            this.pnlRowDetails.Controls.Add(this.lblPrice);
            this.pnlRowDetails.Controls.Add(this.lblStartDate);
            this.pnlRowDetails.Controls.Add(this.lblDescription);
            this.pnlRowDetails.Controls.Add(this.lblName);
            this.pnlRowDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlRowDetails.Name = "pnlRowDetails";
            this.pnlRowDetails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlRowDetails.Size = new System.Drawing.Size(594, 150);
            this.pnlRowDetails.TabIndex = 10;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(566, 11);
            this.chkAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(15, 14);
            this.chkAdd.TabIndex = 18;
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.chkAdd_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(7, 99);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(574, 23);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "End Date: ";
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price: ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(7, 76);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(574, 23);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date: ";
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
            // ItineraryBuilderDestinationEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRow);
            this.Name = "ItineraryBuilderDestinationEvents";
            this.Size = new System.Drawing.Size(619, 161);
            this.Load += new System.EventHandler(this.ItineraryBuilderDestinationEvents_Load);
            this.pnlRow.ResumeLayout(false);
            this.pnlRowDetails.ResumeLayout(false);
            this.pnlRowDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRow;
        private System.Windows.Forms.Panel pnlRowDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox chkAdd;
    }
}
