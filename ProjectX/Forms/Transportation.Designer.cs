namespace ProjectX.Forms
{
    partial class Transportation
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
            this.pnlTableHeaderBasePrice = new System.Windows.Forms.Panel();
            this.lblTableHeaderBasePrice = new System.Windows.Forms.Label();
            this.pnlTableHeaderPricePerKM = new System.Windows.Forms.Panel();
            this.lblTableHeaderPricePerKM = new System.Windows.Forms.Label();
            this.pnlTableHeaderImage = new System.Windows.Forms.Panel();
            this.lblTableHeaderImage = new System.Windows.Forms.Label();
            this.pnlTableHeaderType = new System.Windows.Forms.Panel();
            this.lblTableHeaderType = new System.Windows.Forms.Label();
            this.pnlTableHeaderName = new System.Windows.Forms.Panel();
            this.lblTableHeaderName = new System.Windows.Forms.Label();
            this.pnlTableHeaderTransportationID = new System.Windows.Forms.Panel();
            this.lblTableHeaderTransportationID = new System.Windows.Forms.Label();
            this.pnlTableContent = new System.Windows.Forms.Panel();
            this.pnlTableHeader.SuspendLayout();
            this.pnlTableHeaderBasePrice.SuspendLayout();
            this.pnlTableHeaderPricePerKM.SuspendLayout();
            this.pnlTableHeaderImage.SuspendLayout();
            this.pnlTableHeaderType.SuspendLayout();
            this.pnlTableHeaderName.SuspendLayout();
            this.pnlTableHeaderTransportationID.SuspendLayout();
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
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "+ CREATE NEW TRANSPORTATION";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderBasePrice);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderPricePerKM);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderImage);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderType);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderTransportationID);
            this.pnlTableHeader.Location = new System.Drawing.Point(78, 49);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(872, 45);
            this.pnlTableHeader.TabIndex = 9;
            // 
            // pnlTableHeaderBasePrice
            // 
            this.pnlTableHeaderBasePrice.Controls.Add(this.lblTableHeaderBasePrice);
            this.pnlTableHeaderBasePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableHeaderBasePrice.Location = new System.Drawing.Point(761, 0);
            this.pnlTableHeaderBasePrice.Name = "pnlTableHeaderBasePrice";
            this.pnlTableHeaderBasePrice.Size = new System.Drawing.Size(109, 43);
            this.pnlTableHeaderBasePrice.TabIndex = 4;
            // 
            // lblTableHeaderBasePrice
            // 
            this.lblTableHeaderBasePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderBasePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderBasePrice.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderBasePrice.Name = "lblTableHeaderBasePrice";
            this.lblTableHeaderBasePrice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderBasePrice.Size = new System.Drawing.Size(109, 43);
            this.lblTableHeaderBasePrice.TabIndex = 1;
            this.lblTableHeaderBasePrice.Text = "BasePrice";
            this.lblTableHeaderBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderPricePerKM
            // 
            this.pnlTableHeaderPricePerKM.Controls.Add(this.lblTableHeaderPricePerKM);
            this.pnlTableHeaderPricePerKM.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderPricePerKM.Location = new System.Drawing.Point(645, 0);
            this.pnlTableHeaderPricePerKM.Name = "pnlTableHeaderPricePerKM";
            this.pnlTableHeaderPricePerKM.Size = new System.Drawing.Size(116, 43);
            this.pnlTableHeaderPricePerKM.TabIndex = 3;
            // 
            // lblTableHeaderPricePerKM
            // 
            this.lblTableHeaderPricePerKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderPricePerKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderPricePerKM.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderPricePerKM.Name = "lblTableHeaderPricePerKM";
            this.lblTableHeaderPricePerKM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderPricePerKM.Size = new System.Drawing.Size(116, 43);
            this.lblTableHeaderPricePerKM.TabIndex = 1;
            this.lblTableHeaderPricePerKM.Text = "PricePerKM";
            this.lblTableHeaderPricePerKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderImage
            // 
            this.pnlTableHeaderImage.Controls.Add(this.lblTableHeaderImage);
            this.pnlTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderImage.Location = new System.Drawing.Point(525, 0);
            this.pnlTableHeaderImage.Name = "pnlTableHeaderImage";
            this.pnlTableHeaderImage.Size = new System.Drawing.Size(120, 43);
            this.pnlTableHeaderImage.TabIndex = 2;
            // 
            // lblTableHeaderImage
            // 
            this.lblTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderImage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderImage.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderImage.Name = "lblTableHeaderImage";
            this.lblTableHeaderImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderImage.Size = new System.Drawing.Size(120, 43);
            this.lblTableHeaderImage.TabIndex = 1;
            this.lblTableHeaderImage.Text = "Image";
            this.lblTableHeaderImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderType
            // 
            this.pnlTableHeaderType.Controls.Add(this.lblTableHeaderType);
            this.pnlTableHeaderType.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderType.Location = new System.Drawing.Point(325, 0);
            this.pnlTableHeaderType.Name = "pnlTableHeaderType";
            this.pnlTableHeaderType.Size = new System.Drawing.Size(200, 43);
            this.pnlTableHeaderType.TabIndex = 5;
            // 
            // lblTableHeaderType
            // 
            this.lblTableHeaderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderType.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderType.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderType.Name = "lblTableHeaderType";
            this.lblTableHeaderType.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderType.Size = new System.Drawing.Size(200, 43);
            this.lblTableHeaderType.TabIndex = 0;
            this.lblTableHeaderType.Text = "Type";
            this.lblTableHeaderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderName
            // 
            this.pnlTableHeaderName.Controls.Add(this.lblTableHeaderName);
            this.pnlTableHeaderName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderName.Location = new System.Drawing.Point(125, 0);
            this.pnlTableHeaderName.Name = "pnlTableHeaderName";
            this.pnlTableHeaderName.Size = new System.Drawing.Size(200, 43);
            this.pnlTableHeaderName.TabIndex = 1;
            // 
            // lblTableHeaderName
            // 
            this.lblTableHeaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderName.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderName.Name = "lblTableHeaderName";
            this.lblTableHeaderName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderName.Size = new System.Drawing.Size(200, 43);
            this.lblTableHeaderName.TabIndex = 0;
            this.lblTableHeaderName.Text = "Name";
            this.lblTableHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderTransportationID
            // 
            this.pnlTableHeaderTransportationID.Controls.Add(this.lblTableHeaderTransportationID);
            this.pnlTableHeaderTransportationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderTransportationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableHeaderTransportationID.Name = "pnlTableHeaderTransportationID";
            this.pnlTableHeaderTransportationID.Size = new System.Drawing.Size(125, 43);
            this.pnlTableHeaderTransportationID.TabIndex = 0;
            // 
            // lblTableHeaderTransportationID
            // 
            this.lblTableHeaderTransportationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderTransportationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderTransportationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderTransportationID.Name = "lblTableHeaderTransportationID";
            this.lblTableHeaderTransportationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderTransportationID.Size = new System.Drawing.Size(125, 43);
            this.lblTableHeaderTransportationID.TabIndex = 0;
            this.lblTableHeaderTransportationID.Text = "TransportationID";
            this.lblTableHeaderTransportationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableContent
            // 
            this.pnlTableContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableContent.AutoScroll = true;
            this.pnlTableContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableContent.Location = new System.Drawing.Point(78, 93);
            this.pnlTableContent.Name = "pnlTableContent";
            this.pnlTableContent.Size = new System.Drawing.Size(872, 496);
            this.pnlTableContent.TabIndex = 10;
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlTableContent);
            this.Name = "Transportation";
            this.Text = "TRANSPORTATION";
            this.Load += new System.EventHandler(this.Transportation_Load);
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeaderBasePrice.ResumeLayout(false);
            this.pnlTableHeaderPricePerKM.ResumeLayout(false);
            this.pnlTableHeaderImage.ResumeLayout(false);
            this.pnlTableHeaderType.ResumeLayout(false);
            this.pnlTableHeaderName.ResumeLayout(false);
            this.pnlTableHeaderTransportationID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlTableHeader;
        private System.Windows.Forms.Panel pnlTableHeaderBasePrice;
        private System.Windows.Forms.Label lblTableHeaderBasePrice;
        private System.Windows.Forms.Panel pnlTableHeaderPricePerKM;
        private System.Windows.Forms.Label lblTableHeaderPricePerKM;
        private System.Windows.Forms.Panel pnlTableHeaderType;
        private System.Windows.Forms.Label lblTableHeaderType;
        private System.Windows.Forms.Panel pnlTableHeaderImage;
        private System.Windows.Forms.Label lblTableHeaderImage;
        private System.Windows.Forms.Panel pnlTableHeaderName;
        private System.Windows.Forms.Label lblTableHeaderName;
        private System.Windows.Forms.Panel pnlTableHeaderTransportationID;
        private System.Windows.Forms.Label lblTableHeaderTransportationID;
        private System.Windows.Forms.Panel pnlTableContent;
    }
}