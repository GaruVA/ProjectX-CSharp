namespace ProjectX.Forms
{
    partial class Destinations
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlTableHeader = new System.Windows.Forms.Panel();
            this.pnlTableHeaderCity = new System.Windows.Forms.Panel();
            this.lblTableHeaderCity = new System.Windows.Forms.Label();
            this.pnlTableHeaderDistrict = new System.Windows.Forms.Panel();
            this.lblTableHeaderDistrict = new System.Windows.Forms.Label();
            this.pnlTableHeaderImage = new System.Windows.Forms.Panel();
            this.lblTableHeaderImage = new System.Windows.Forms.Label();
            this.pnlTableHeaderName = new System.Windows.Forms.Panel();
            this.lblTableHeaderName = new System.Windows.Forms.Label();
            this.pnlTableHeaderDestinationID = new System.Windows.Forms.Panel();
            this.lblTableHeaderDestinationID = new System.Windows.Forms.Label();
            this.pnlTableContent = new System.Windows.Forms.Panel();
            this.pnlTableHeader.SuspendLayout();
            this.pnlTableHeaderCity.SuspendLayout();
            this.pnlTableHeaderDistrict.SuspendLayout();
            this.pnlTableHeaderImage.SuspendLayout();
            this.pnlTableHeaderName.SuspendLayout();
            this.pnlTableHeaderDestinationID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(78, 588);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(872, 45);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "+ CREATE NEW DESTINATION";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderCity);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderDistrict);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderImage);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderDestinationID);
            this.pnlTableHeader.Location = new System.Drawing.Point(78, 49);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(872, 45);
            this.pnlTableHeader.TabIndex = 3;
            // 
            // pnlTableHeaderCity
            // 
            this.pnlTableHeaderCity.Controls.Add(this.lblTableHeaderCity);
            this.pnlTableHeaderCity.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderCity.Location = new System.Drawing.Point(704, 0);
            this.pnlTableHeaderCity.Name = "pnlTableHeaderCity";
            this.pnlTableHeaderCity.Size = new System.Drawing.Size(167, 43);
            this.pnlTableHeaderCity.TabIndex = 4;
            // 
            // lblTableHeaderCity
            // 
            this.lblTableHeaderCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderCity.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderCity.Name = "lblTableHeaderCity";
            this.lblTableHeaderCity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderCity.Size = new System.Drawing.Size(167, 43);
            this.lblTableHeaderCity.TabIndex = 1;
            this.lblTableHeaderCity.Text = "City";
            this.lblTableHeaderCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderDistrict
            // 
            this.pnlTableHeaderDistrict.Controls.Add(this.lblTableHeaderDistrict);
            this.pnlTableHeaderDistrict.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderDistrict.Location = new System.Drawing.Point(537, 0);
            this.pnlTableHeaderDistrict.Name = "pnlTableHeaderDistrict";
            this.pnlTableHeaderDistrict.Size = new System.Drawing.Size(167, 43);
            this.pnlTableHeaderDistrict.TabIndex = 3;
            // 
            // lblTableHeaderDistrict
            // 
            this.lblTableHeaderDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderDistrict.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderDistrict.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderDistrict.Name = "lblTableHeaderDistrict";
            this.lblTableHeaderDistrict.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderDistrict.Size = new System.Drawing.Size(167, 43);
            this.lblTableHeaderDistrict.TabIndex = 1;
            this.lblTableHeaderDistrict.Text = "District";
            this.lblTableHeaderDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderImage
            // 
            this.pnlTableHeaderImage.Controls.Add(this.lblTableHeaderImage);
            this.pnlTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderImage.Location = new System.Drawing.Point(357, 0);
            this.pnlTableHeaderImage.Name = "pnlTableHeaderImage";
            this.pnlTableHeaderImage.Size = new System.Drawing.Size(180, 43);
            this.pnlTableHeaderImage.TabIndex = 2;
            // 
            // lblTableHeaderImage
            // 
            this.lblTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderImage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderImage.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderImage.Name = "lblTableHeaderImage";
            this.lblTableHeaderImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderImage.Size = new System.Drawing.Size(180, 43);
            this.lblTableHeaderImage.TabIndex = 1;
            this.lblTableHeaderImage.Text = "Image";
            this.lblTableHeaderImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderName
            // 
            this.pnlTableHeaderName.Controls.Add(this.lblTableHeaderName);
            this.pnlTableHeaderName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderName.Location = new System.Drawing.Point(117, 0);
            this.pnlTableHeaderName.Name = "pnlTableHeaderName";
            this.pnlTableHeaderName.Size = new System.Drawing.Size(240, 43);
            this.pnlTableHeaderName.TabIndex = 1;
            // 
            // lblTableHeaderName
            // 
            this.lblTableHeaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderName.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderName.Name = "lblTableHeaderName";
            this.lblTableHeaderName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderName.Size = new System.Drawing.Size(240, 43);
            this.lblTableHeaderName.TabIndex = 0;
            this.lblTableHeaderName.Text = "Name";
            this.lblTableHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderDestinationID
            // 
            this.pnlTableHeaderDestinationID.Controls.Add(this.lblTableHeaderDestinationID);
            this.pnlTableHeaderDestinationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderDestinationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableHeaderDestinationID.Name = "pnlTableHeaderDestinationID";
            this.pnlTableHeaderDestinationID.Size = new System.Drawing.Size(117, 43);
            this.pnlTableHeaderDestinationID.TabIndex = 0;
            // 
            // lblTableHeaderDestinationID
            // 
            this.lblTableHeaderDestinationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderDestinationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderDestinationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderDestinationID.Name = "lblTableHeaderDestinationID";
            this.lblTableHeaderDestinationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderDestinationID.Size = new System.Drawing.Size(117, 43);
            this.lblTableHeaderDestinationID.TabIndex = 0;
            this.lblTableHeaderDestinationID.Text = "DestinationID";
            this.lblTableHeaderDestinationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableContent
            // 
            this.pnlTableContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableContent.AutoScroll = true;
            this.pnlTableContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableContent.Location = new System.Drawing.Point(78, 93);
            this.pnlTableContent.Name = "pnlTableContent";
            this.pnlTableContent.Size = new System.Drawing.Size(872, 496);
            this.pnlTableContent.TabIndex = 4;
            // 
            // Destinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlTableContent);
            this.Name = "Destinations";
            this.Text = "DESTINATIONS";
            this.Load += new System.EventHandler(this.Destinations_Load);
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeaderCity.ResumeLayout(false);
            this.pnlTableHeaderDistrict.ResumeLayout(false);
            this.pnlTableHeaderImage.ResumeLayout(false);
            this.pnlTableHeaderName.ResumeLayout(false);
            this.pnlTableHeaderDestinationID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlTableHeader;
        private System.Windows.Forms.Panel pnlTableHeaderCity;
        private System.Windows.Forms.Label lblTableHeaderCity;
        private System.Windows.Forms.Panel pnlTableHeaderDistrict;
        private System.Windows.Forms.Label lblTableHeaderDistrict;
        private System.Windows.Forms.Panel pnlTableHeaderImage;
        private System.Windows.Forms.Panel pnlTableHeaderName;
        private System.Windows.Forms.Label lblTableHeaderName;
        private System.Windows.Forms.Panel pnlTableHeaderDestinationID;
        private System.Windows.Forms.Label lblTableHeaderDestinationID;
        private System.Windows.Forms.Panel pnlTableContent;
        private System.Windows.Forms.Label lblTableHeaderImage;
    }
}