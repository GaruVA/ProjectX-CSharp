namespace ProjectX.Forms
{
    partial class CustomerProfiles
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
            this.pnlTableHeaderEmail = new System.Windows.Forms.Panel();
            this.lblTableHeaderEmail = new System.Windows.Forms.Label();
            this.pnlTableHeaderLastName = new System.Windows.Forms.Panel();
            this.lblTableHeaderLastName = new System.Windows.Forms.Label();
            this.pnlTableHeaderFirstName = new System.Windows.Forms.Panel();
            this.lblTableHeaderFirstName = new System.Windows.Forms.Label();
            this.pnlTableHeaderCustomerID = new System.Windows.Forms.Panel();
            this.lblTableHeaderCustomerID = new System.Windows.Forms.Label();
            this.pnlTableHeaderPhone = new System.Windows.Forms.Panel();
            this.lblTableHeaderPhone = new System.Windows.Forms.Label();
            this.pnlTableContent = new System.Windows.Forms.Panel();
            this.pnlTableHeader.SuspendLayout();
            this.pnlTableHeaderEmail.SuspendLayout();
            this.pnlTableHeaderLastName.SuspendLayout();
            this.pnlTableHeaderFirstName.SuspendLayout();
            this.pnlTableHeaderCustomerID.SuspendLayout();
            this.pnlTableHeaderPhone.SuspendLayout();
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
            this.btnCreate.Text = "+ CREATE NEW CUSTOMER PROFILE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderEmail);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderLastName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderFirstName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderCustomerID);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderPhone);
            this.pnlTableHeader.Location = new System.Drawing.Point(78, 49);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(872, 45);
            this.pnlTableHeader.TabIndex = 3;
            // 
            // pnlTableHeaderEmail
            // 
            this.pnlTableHeaderEmail.Controls.Add(this.lblTableHeaderEmail);
            this.pnlTableHeaderEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableHeaderEmail.Location = new System.Drawing.Point(334, 0);
            this.pnlTableHeaderEmail.Name = "pnlTableHeaderEmail";
            this.pnlTableHeaderEmail.Size = new System.Drawing.Size(412, 43);
            this.pnlTableHeaderEmail.TabIndex = 4;
            // 
            // lblTableHeaderEmail
            // 
            this.lblTableHeaderEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderEmail.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderEmail.Name = "lblTableHeaderEmail";
            this.lblTableHeaderEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderEmail.Size = new System.Drawing.Size(412, 43);
            this.lblTableHeaderEmail.TabIndex = 1;
            this.lblTableHeaderEmail.Text = "Email";
            this.lblTableHeaderEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderLastName
            // 
            this.pnlTableHeaderLastName.Controls.Add(this.lblTableHeaderLastName);
            this.pnlTableHeaderLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderLastName.Location = new System.Drawing.Point(214, 0);
            this.pnlTableHeaderLastName.Name = "pnlTableHeaderLastName";
            this.pnlTableHeaderLastName.Size = new System.Drawing.Size(120, 43);
            this.pnlTableHeaderLastName.TabIndex = 3;
            // 
            // lblTableHeaderLastName
            // 
            this.lblTableHeaderLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderLastName.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderLastName.Name = "lblTableHeaderLastName";
            this.lblTableHeaderLastName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderLastName.Size = new System.Drawing.Size(120, 43);
            this.lblTableHeaderLastName.TabIndex = 1;
            this.lblTableHeaderLastName.Text = "Last Name";
            this.lblTableHeaderLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderFirstName
            // 
            this.pnlTableHeaderFirstName.Controls.Add(this.lblTableHeaderFirstName);
            this.pnlTableHeaderFirstName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderFirstName.Location = new System.Drawing.Point(94, 0);
            this.pnlTableHeaderFirstName.Name = "pnlTableHeaderFirstName";
            this.pnlTableHeaderFirstName.Size = new System.Drawing.Size(120, 43);
            this.pnlTableHeaderFirstName.TabIndex = 2;
            // 
            // lblTableHeaderFirstName
            // 
            this.lblTableHeaderFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderFirstName.Name = "lblTableHeaderFirstName";
            this.lblTableHeaderFirstName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderFirstName.Size = new System.Drawing.Size(120, 43);
            this.lblTableHeaderFirstName.TabIndex = 1;
            this.lblTableHeaderFirstName.Text = "First Name";
            this.lblTableHeaderFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderCustomerID
            // 
            this.pnlTableHeaderCustomerID.Controls.Add(this.lblTableHeaderCustomerID);
            this.pnlTableHeaderCustomerID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderCustomerID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableHeaderCustomerID.Name = "pnlTableHeaderCustomerID";
            this.pnlTableHeaderCustomerID.Size = new System.Drawing.Size(94, 43);
            this.pnlTableHeaderCustomerID.TabIndex = 0;
            // 
            // lblTableHeaderCustomerID
            // 
            this.lblTableHeaderCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderCustomerID.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderCustomerID.Name = "lblTableHeaderCustomerID";
            this.lblTableHeaderCustomerID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderCustomerID.Size = new System.Drawing.Size(94, 43);
            this.lblTableHeaderCustomerID.TabIndex = 0;
            this.lblTableHeaderCustomerID.Text = "CustomerID";
            this.lblTableHeaderCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderPhone
            // 
            this.pnlTableHeaderPhone.Controls.Add(this.lblTableHeaderPhone);
            this.pnlTableHeaderPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableHeaderPhone.Location = new System.Drawing.Point(746, 0);
            this.pnlTableHeaderPhone.Name = "pnlTableHeaderPhone";
            this.pnlTableHeaderPhone.Size = new System.Drawing.Size(124, 43);
            this.pnlTableHeaderPhone.TabIndex = 5;
            // 
            // lblTableHeaderPhone
            // 
            this.lblTableHeaderPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderPhone.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderPhone.Name = "lblTableHeaderPhone";
            this.lblTableHeaderPhone.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderPhone.Size = new System.Drawing.Size(124, 43);
            this.lblTableHeaderPhone.TabIndex = 1;
            this.lblTableHeaderPhone.Text = "Phone Number";
            this.lblTableHeaderPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // CustomerProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlTableContent);
            this.Name = "CustomerProfiles";
            this.Text = "CUSTOMER PROFILES";
            this.Load += new System.EventHandler(this.CustomerProfiles_Load);
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeaderEmail.ResumeLayout(false);
            this.pnlTableHeaderLastName.ResumeLayout(false);
            this.pnlTableHeaderFirstName.ResumeLayout(false);
            this.pnlTableHeaderCustomerID.ResumeLayout(false);
            this.pnlTableHeaderPhone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlTableHeader;
        private System.Windows.Forms.Panel pnlTableHeaderEmail;
        private System.Windows.Forms.Label lblTableHeaderEmail;
        private System.Windows.Forms.Panel pnlTableHeaderLastName;
        private System.Windows.Forms.Label lblTableHeaderLastName;
        private System.Windows.Forms.Panel pnlTableHeaderFirstName;
        private System.Windows.Forms.Label lblTableHeaderFirstName;
        private System.Windows.Forms.Panel pnlTableHeaderCustomerID;
        private System.Windows.Forms.Label lblTableHeaderCustomerID;
        private System.Windows.Forms.Panel pnlTableHeaderPhone;
        private System.Windows.Forms.Label lblTableHeaderPhone;
        private System.Windows.Forms.Panel pnlTableContent;
    }
}