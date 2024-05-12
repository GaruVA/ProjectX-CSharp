namespace ProjectX.UserControls
{
    partial class CustomerProfilesTableRow
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
            this.pnlTableRow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTableRowEmail = new System.Windows.Forms.Panel();
            this.lblTableRowEmail = new System.Windows.Forms.Label();
            this.pnlTableRowLastName = new System.Windows.Forms.Panel();
            this.lblTableRowLastName = new System.Windows.Forms.Label();
            this.pnlTableRowFirstName = new System.Windows.Forms.Panel();
            this.lblTableRowFirstName = new System.Windows.Forms.Label();
            this.pnlTableRowCustomerID = new System.Windows.Forms.Panel();
            this.lblTableRowCustomerID = new System.Windows.Forms.Label();
            this.pnlTableRowPhone = new System.Windows.Forms.Panel();
            this.lblTableRowPhone = new System.Windows.Forms.Label();
            this.pnlTableRow.SuspendLayout();
            this.pnlTableRowEmail.SuspendLayout();
            this.pnlTableRowLastName.SuspendLayout();
            this.pnlTableRowFirstName.SuspendLayout();
            this.pnlTableRowCustomerID.SuspendLayout();
            this.pnlTableRowPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableRow
            // 
            this.pnlTableRow.Controls.Add(this.label1);
            this.pnlTableRow.Controls.Add(this.pnlTableRowEmail);
            this.pnlTableRow.Controls.Add(this.pnlTableRowLastName);
            this.pnlTableRow.Controls.Add(this.pnlTableRowFirstName);
            this.pnlTableRow.Controls.Add(this.pnlTableRowCustomerID);
            this.pnlTableRow.Controls.Add(this.pnlTableRowPhone);
            this.pnlTableRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRow.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRow.Name = "pnlTableRow";
            this.pnlTableRow.Size = new System.Drawing.Size(870, 60);
            this.pnlTableRow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(-11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 10);
            this.label1.TabIndex = 6;
            // 
            // pnlTableRowEmail
            // 
            this.pnlTableRowEmail.Controls.Add(this.lblTableRowEmail);
            this.pnlTableRowEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRowEmail.Location = new System.Drawing.Point(334, 0);
            this.pnlTableRowEmail.Name = "pnlTableRowEmail";
            this.pnlTableRowEmail.Size = new System.Drawing.Size(412, 60);
            this.pnlTableRowEmail.TabIndex = 4;
            // 
            // lblTableRowEmail
            // 
            this.lblTableRowEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowEmail.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowEmail.Name = "lblTableRowEmail";
            this.lblTableRowEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowEmail.Size = new System.Drawing.Size(412, 60);
            this.lblTableRowEmail.TabIndex = 1;
            this.lblTableRowEmail.Text = "Email";
            this.lblTableRowEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowEmail.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowEmail.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowEmail.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowLastName
            // 
            this.pnlTableRowLastName.Controls.Add(this.lblTableRowLastName);
            this.pnlTableRowLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowLastName.Location = new System.Drawing.Point(214, 0);
            this.pnlTableRowLastName.Name = "pnlTableRowLastName";
            this.pnlTableRowLastName.Size = new System.Drawing.Size(120, 60);
            this.pnlTableRowLastName.TabIndex = 3;
            // 
            // lblTableRowLastName
            // 
            this.lblTableRowLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowLastName.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowLastName.Name = "lblTableRowLastName";
            this.lblTableRowLastName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowLastName.Size = new System.Drawing.Size(120, 60);
            this.lblTableRowLastName.TabIndex = 1;
            this.lblTableRowLastName.Text = "Last Name";
            this.lblTableRowLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowLastName.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowLastName.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowLastName.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowFirstName
            // 
            this.pnlTableRowFirstName.Controls.Add(this.lblTableRowFirstName);
            this.pnlTableRowFirstName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowFirstName.Location = new System.Drawing.Point(94, 0);
            this.pnlTableRowFirstName.Name = "pnlTableRowFirstName";
            this.pnlTableRowFirstName.Size = new System.Drawing.Size(120, 60);
            this.pnlTableRowFirstName.TabIndex = 2;
            // 
            // lblTableRowFirstName
            // 
            this.lblTableRowFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowFirstName.Name = "lblTableRowFirstName";
            this.lblTableRowFirstName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowFirstName.Size = new System.Drawing.Size(120, 60);
            this.lblTableRowFirstName.TabIndex = 1;
            this.lblTableRowFirstName.Text = "First Name";
            this.lblTableRowFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowFirstName.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowFirstName.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowFirstName.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowCustomerID
            // 
            this.pnlTableRowCustomerID.Controls.Add(this.lblTableRowCustomerID);
            this.pnlTableRowCustomerID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowCustomerID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRowCustomerID.Name = "pnlTableRowCustomerID";
            this.pnlTableRowCustomerID.Size = new System.Drawing.Size(94, 60);
            this.pnlTableRowCustomerID.TabIndex = 0;
            // 
            // lblTableRowCustomerID
            // 
            this.lblTableRowCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowCustomerID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowCustomerID.Name = "lblTableRowCustomerID";
            this.lblTableRowCustomerID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowCustomerID.Size = new System.Drawing.Size(94, 60);
            this.lblTableRowCustomerID.TabIndex = 0;
            this.lblTableRowCustomerID.Text = "CustomerID";
            this.lblTableRowCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowCustomerID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowCustomerID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowCustomerID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowPhone
            // 
            this.pnlTableRowPhone.Controls.Add(this.lblTableRowPhone);
            this.pnlTableRowPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableRowPhone.Location = new System.Drawing.Point(746, 0);
            this.pnlTableRowPhone.Name = "pnlTableRowPhone";
            this.pnlTableRowPhone.Size = new System.Drawing.Size(124, 60);
            this.pnlTableRowPhone.TabIndex = 5;
            // 
            // lblTableRowPhone
            // 
            this.lblTableRowPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowPhone.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowPhone.Name = "lblTableRowPhone";
            this.lblTableRowPhone.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowPhone.Size = new System.Drawing.Size(124, 60);
            this.lblTableRowPhone.TabIndex = 1;
            this.lblTableRowPhone.Text = "Phone Number";
            this.lblTableRowPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowPhone.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowPhone.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowPhone.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // CustomerProfilesTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTableRow);
            this.Name = "CustomerProfilesTableRow";
            this.Size = new System.Drawing.Size(870, 60);
            this.Load += new System.EventHandler(this.CustomerProfilesTableRow_Load);
            this.pnlTableRow.ResumeLayout(false);
            this.pnlTableRowEmail.ResumeLayout(false);
            this.pnlTableRowLastName.ResumeLayout(false);
            this.pnlTableRowFirstName.ResumeLayout(false);
            this.pnlTableRowCustomerID.ResumeLayout(false);
            this.pnlTableRowPhone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableRow;
        private System.Windows.Forms.Panel pnlTableRowEmail;
        private System.Windows.Forms.Label lblTableRowEmail;
        private System.Windows.Forms.Panel pnlTableRowLastName;
        private System.Windows.Forms.Label lblTableRowLastName;
        private System.Windows.Forms.Panel pnlTableRowFirstName;
        private System.Windows.Forms.Label lblTableRowFirstName;
        private System.Windows.Forms.Panel pnlTableRowCustomerID;
        private System.Windows.Forms.Label lblTableRowCustomerID;
        private System.Windows.Forms.Panel pnlTableRowPhone;
        private System.Windows.Forms.Label lblTableRowPhone;
        private System.Windows.Forms.Label label1;
    }
}
