namespace ProjectX.Forms
{
    partial class UserManagement
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
            this.pnlTableContent = new System.Windows.Forms.Panel();
            this.pnlTableHeader = new System.Windows.Forms.Panel();
            this.pnlTableHeaderEmail = new System.Windows.Forms.Panel();
            this.lblTableHeaderEmail = new System.Windows.Forms.Label();
            this.pnlTableHeaderLastName = new System.Windows.Forms.Panel();
            this.lblTableHeaderLastName = new System.Windows.Forms.Label();
            this.pnlTableHeaderFirstName = new System.Windows.Forms.Panel();
            this.lblTableHeaderFirstName = new System.Windows.Forms.Label();
            this.pnlTableHeaderUsername = new System.Windows.Forms.Panel();
            this.lblTableHeaderUsername = new System.Windows.Forms.Label();
            this.pnlTableHeaderUserID = new System.Windows.Forms.Panel();
            this.lblTableHeaderUserID = new System.Windows.Forms.Label();
            this.pnlTableHeaderRole = new System.Windows.Forms.Panel();
            this.lblTableHeaderRole = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlTableHeader.SuspendLayout();
            this.pnlTableHeaderEmail.SuspendLayout();
            this.pnlTableHeaderLastName.SuspendLayout();
            this.pnlTableHeaderFirstName.SuspendLayout();
            this.pnlTableHeaderUsername.SuspendLayout();
            this.pnlTableHeaderUserID.SuspendLayout();
            this.pnlTableHeaderRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableContent
            // 
            this.pnlTableContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableContent.AutoScroll = true;
            this.pnlTableContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableContent.Location = new System.Drawing.Point(78, 93);
            this.pnlTableContent.Name = "pnlTableContent";
            this.pnlTableContent.Size = new System.Drawing.Size(872, 496);
            this.pnlTableContent.TabIndex = 1;
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderEmail);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderLastName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderFirstName);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderUsername);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderUserID);
            this.pnlTableHeader.Controls.Add(this.pnlTableHeaderRole);
            this.pnlTableHeader.Location = new System.Drawing.Point(78, 49);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(872, 45);
            this.pnlTableHeader.TabIndex = 1;
            // 
            // pnlTableHeaderEmail
            // 
            this.pnlTableHeaderEmail.Controls.Add(this.lblTableHeaderEmail);
            this.pnlTableHeaderEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableHeaderEmail.Location = new System.Drawing.Point(431, 0);
            this.pnlTableHeaderEmail.Name = "pnlTableHeaderEmail";
            this.pnlTableHeaderEmail.Size = new System.Drawing.Size(315, 43);
            this.pnlTableHeaderEmail.TabIndex = 4;
            // 
            // lblTableHeaderEmail
            // 
            this.lblTableHeaderEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderEmail.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderEmail.Name = "lblTableHeaderEmail";
            this.lblTableHeaderEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderEmail.Size = new System.Drawing.Size(315, 43);
            this.lblTableHeaderEmail.TabIndex = 1;
            this.lblTableHeaderEmail.Text = "Email";
            this.lblTableHeaderEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderLastName
            // 
            this.pnlTableHeaderLastName.Controls.Add(this.lblTableHeaderLastName);
            this.pnlTableHeaderLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderLastName.Location = new System.Drawing.Point(311, 0);
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
            this.pnlTableHeaderFirstName.Location = new System.Drawing.Point(191, 0);
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
            // pnlTableHeaderUsername
            // 
            this.pnlTableHeaderUsername.Controls.Add(this.lblTableHeaderUsername);
            this.pnlTableHeaderUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderUsername.Location = new System.Drawing.Point(71, 0);
            this.pnlTableHeaderUsername.Name = "pnlTableHeaderUsername";
            this.pnlTableHeaderUsername.Size = new System.Drawing.Size(120, 43);
            this.pnlTableHeaderUsername.TabIndex = 1;
            // 
            // lblTableHeaderUsername
            // 
            this.lblTableHeaderUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderUsername.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderUsername.Name = "lblTableHeaderUsername";
            this.lblTableHeaderUsername.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderUsername.Size = new System.Drawing.Size(120, 43);
            this.lblTableHeaderUsername.TabIndex = 0;
            this.lblTableHeaderUsername.Text = "Username";
            this.lblTableHeaderUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderUserID
            // 
            this.pnlTableHeaderUserID.Controls.Add(this.lblTableHeaderUserID);
            this.pnlTableHeaderUserID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableHeaderUserID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableHeaderUserID.Name = "pnlTableHeaderUserID";
            this.pnlTableHeaderUserID.Size = new System.Drawing.Size(71, 43);
            this.pnlTableHeaderUserID.TabIndex = 0;
            // 
            // lblTableHeaderUserID
            // 
            this.lblTableHeaderUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderUserID.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderUserID.Name = "lblTableHeaderUserID";
            this.lblTableHeaderUserID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderUserID.Size = new System.Drawing.Size(71, 43);
            this.lblTableHeaderUserID.TabIndex = 0;
            this.lblTableHeaderUserID.Text = "UserID";
            this.lblTableHeaderUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTableHeaderRole
            // 
            this.pnlTableHeaderRole.Controls.Add(this.lblTableHeaderRole);
            this.pnlTableHeaderRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableHeaderRole.Location = new System.Drawing.Point(746, 0);
            this.pnlTableHeaderRole.Name = "pnlTableHeaderRole";
            this.pnlTableHeaderRole.Size = new System.Drawing.Size(124, 43);
            this.pnlTableHeaderRole.TabIndex = 5;
            // 
            // lblTableHeaderRole
            // 
            this.lblTableHeaderRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableHeaderRole.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeaderRole.Location = new System.Drawing.Point(0, 0);
            this.lblTableHeaderRole.Name = "lblTableHeaderRole";
            this.lblTableHeaderRole.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableHeaderRole.Size = new System.Drawing.Size(124, 43);
            this.lblTableHeaderRole.TabIndex = 1;
            this.lblTableHeaderRole.Text = "Role";
            this.lblTableHeaderRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "+ CREATE NEW USER";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlTableContent);
            this.Name = "UserManagement";
            this.Text = "USER MANAGEMENT";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeaderEmail.ResumeLayout(false);
            this.pnlTableHeaderLastName.ResumeLayout(false);
            this.pnlTableHeaderFirstName.ResumeLayout(false);
            this.pnlTableHeaderUsername.ResumeLayout(false);
            this.pnlTableHeaderUserID.ResumeLayout(false);
            this.pnlTableHeaderRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTableContent;
        private System.Windows.Forms.Panel pnlTableHeader;
        private System.Windows.Forms.Panel pnlTableHeaderEmail;
        private System.Windows.Forms.Panel pnlTableHeaderLastName;
        private System.Windows.Forms.Panel pnlTableHeaderFirstName;
        private System.Windows.Forms.Panel pnlTableHeaderUsername;
        private System.Windows.Forms.Panel pnlTableHeaderUserID;
        private System.Windows.Forms.Panel pnlTableHeaderRole;
        private System.Windows.Forms.Label lblTableHeaderUsername;
        private System.Windows.Forms.Label lblTableHeaderUserID;
        private System.Windows.Forms.Label lblTableHeaderLastName;
        private System.Windows.Forms.Label lblTableHeaderFirstName;
        private System.Windows.Forms.Label lblTableHeaderEmail;
        private System.Windows.Forms.Label lblTableHeaderRole;
        private System.Windows.Forms.Button btnCreate;
    }
}