namespace ProjectX.Forms
{
    partial class Accommodations
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
            this.pnlTableHeaderCategory = new System.Windows.Forms.Panel();
            this.lblTableHeaderCategory = new System.Windows.Forms.Label();
            this.pnlTableHeaderAddress = new System.Windows.Forms.Panel();
            this.lblTableHeaderAddress = new System.Windows.Forms.Label();
            this.pnlTableHeaderImage = new System.Windows.Forms.Panel();
            this.lblTableHeaderImage = new System.Windows.Forms.Label();
            this.pnlTableHeaderName = new System.Windows.Forms.Panel();
            this.lblTableHeaderName = new System.Windows.Forms.Label();
            this.pnlTableHeaderAccommdationID = new System.Windows.Forms.Panel();
            this.lblTableHeaderAccommdationID = new System.Windows.Forms.Label();
            this.pnlTableContent = new System.Windows.Forms.Panel();
            this.pnlTableHeader.SuspendLayout();
            this.pnlTableHeaderCategory.SuspendLayout();
            this.pnlTableHeaderAddress.SuspendLayout();
            this.pnlTableHeaderImage.SuspendLayout();
            this.pnlTableHeaderName.SuspendLayout();
            this.pnlTableHeaderAccommdationID.SuspendLayout();
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
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "+ CREATE NEW ACCOMMDATION";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderCategory);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderAddress);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderImage);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderAccommdationID);
            this.pnlTableHeader.Location = new System.Drawing.Point(78, 49);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(872, 45);
            this.pnlTableHeader.TabIndex = 6;
            // 
            // pnlTableHeaderCategory
            // 
            this.pnlTableHeaderCategory.Controls.Add(this.lblTableHeaderCategory);
            this.pnlTableHeaderCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderCategory.Location = new System.Drawing.Point(739, 0);
            this.pnlTableHeaderCategory.Name = "pnlTableHeaderCategory";
            this.pnlTableHeaderCategory.Size = new System.Drawing.Size(130, 43);
            this.pnlTableHeaderCategory.TabIndex = 3;
            // 
            // lblTableHeaderCategory
            // 
            this.lblTableHeaderCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderCategory.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderCategory.Name = "lblTableHeaderCategory";
            this.lblTableHeaderCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderCategory.Size = new System.Drawing.Size(130, 43);
            this.lblTableHeaderCategory.TabIndex = 1;
            this.lblTableHeaderCategory.Text = "Category";
            this.lblTableHeaderCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderAddress
            // 
            this.pnlTableHeaderAddress.Controls.Add(this.lblTableHeaderAddress);
            this.pnlTableHeaderAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderAddress.Location = new System.Drawing.Point(469, 0);
            this.pnlTableHeaderAddress.Name = "pnlTableHeaderAddress";
            this.pnlTableHeaderAddress.Size = new System.Drawing.Size(270, 43);
            this.pnlTableHeaderAddress.TabIndex = 5;
            // 
            // lblTableHeaderAddress
            // 
            this.lblTableHeaderAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderAddress.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderAddress.Name = "lblTableHeaderAddress";
            this.lblTableHeaderAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderAddress.Size = new System.Drawing.Size(270, 43);
            this.lblTableHeaderAddress.TabIndex = 0;
            this.lblTableHeaderAddress.Text = "Address";
            this.lblTableHeaderAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderImage
            // 
            this.pnlTableHeaderImage.Controls.Add(this.lblTableHeaderImage);
            this.pnlTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderImage.Location = new System.Drawing.Point(325, 0);
            this.pnlTableHeaderImage.Name = "pnlTableHeaderImage";
            this.pnlTableHeaderImage.Size = new System.Drawing.Size(144, 43);
            this.pnlTableHeaderImage.TabIndex = 2;
            // 
            // lblTableHeaderImage
            // 
            this.lblTableHeaderImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderImage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderImage.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderImage.Name = "lblTableHeaderImage";
            this.lblTableHeaderImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderImage.Size = new System.Drawing.Size(144, 43);
            this.lblTableHeaderImage.TabIndex = 1;
            this.lblTableHeaderImage.Text = "Image";
            this.lblTableHeaderImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pnlTableHeaderAccommdationID
            // 
            this.pnlTableHeaderAccommdationID.Controls.Add(this.lblTableHeaderAccommdationID);
            this.pnlTableHeaderAccommdationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderAccommdationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableHeaderAccommdationID.Name = "pnlTableHeaderAccommdationID";
            this.pnlTableHeaderAccommdationID.Size = new System.Drawing.Size(125, 43);
            this.pnlTableHeaderAccommdationID.TabIndex = 0;
            // 
            // lblTableHeaderAccommdationID
            // 
            this.lblTableHeaderAccommdationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderAccommdationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderAccommdationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderAccommdationID.Name = "lblTableHeaderAccommdationID";
            this.lblTableHeaderAccommdationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderAccommdationID.Size = new System.Drawing.Size(125, 43);
            this.lblTableHeaderAccommdationID.TabIndex = 0;
            this.lblTableHeaderAccommdationID.Text = "AccommdationID";
            this.lblTableHeaderAccommdationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableContent
            // 
            this.pnlTableContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableContent.AutoScroll = true;
            this.pnlTableContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableContent.Location = new System.Drawing.Point(78, 93);
            this.pnlTableContent.Name = "pnlTableContent";
            this.pnlTableContent.Size = new System.Drawing.Size(872, 496);
            this.pnlTableContent.TabIndex = 7;
            // 
            // Accommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlTableContent);
            this.Name = "Accommodations";
            this.Text = "ACCOMMODATIONS";
            this.Load += new System.EventHandler(this.Accommodations_Load);
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeaderCategory.ResumeLayout(false);
            this.pnlTableHeaderAddress.ResumeLayout(false);
            this.pnlTableHeaderImage.ResumeLayout(false);
            this.pnlTableHeaderName.ResumeLayout(false);
            this.pnlTableHeaderAccommdationID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlTableHeader;
        private System.Windows.Forms.Panel pnlTableHeaderCategory;
        private System.Windows.Forms.Label lblTableHeaderCategory;
        private System.Windows.Forms.Panel pnlTableHeaderImage;
        private System.Windows.Forms.Label lblTableHeaderImage;
        private System.Windows.Forms.Panel pnlTableHeaderName;
        private System.Windows.Forms.Label lblTableHeaderName;
        private System.Windows.Forms.Panel pnlTableHeaderAccommdationID;
        private System.Windows.Forms.Label lblTableHeaderAccommdationID;
        private System.Windows.Forms.Panel pnlTableContent;
        private System.Windows.Forms.Panel pnlTableHeaderAddress;
        private System.Windows.Forms.Label lblTableHeaderAddress;
    }
}