namespace ProjectX.Forms
{
    partial class TransportationInfo
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnDelete = new ProjectX.RoundButton();
            this.btnUpdate = new ProjectX.RoundButton();
            this.txtTransportationID = new System.Windows.Forms.Label();
            this.lblTransportationID = new System.Windows.Forms.Label();
            this.txtPricePerKM = new ProjectX.StyledTextBox();
            this.lblPricePerKM = new System.Windows.Forms.Label();
            this.cmbType = new ProjectX.Classes.CustomComboBox();
            this.txtBasePrice = new ProjectX.StyledTextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtDescription = new ProjectX.StyledTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTransportationInfo = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.txtCapacity = new ProjectX.StyledTextBox();
            this.txtName = new ProjectX.StyledTextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContent.Controls.Add(this.btnDelete);
            this.pnlContent.Controls.Add(this.btnUpdate);
            this.pnlContent.Controls.Add(this.txtTransportationID);
            this.pnlContent.Controls.Add(this.lblTransportationID);
            this.pnlContent.Controls.Add(this.txtPricePerKM);
            this.pnlContent.Controls.Add(this.lblPricePerKM);
            this.pnlContent.Controls.Add(this.cmbType);
            this.pnlContent.Controls.Add(this.txtBasePrice);
            this.pnlContent.Controls.Add(this.lblBasePrice);
            this.pnlContent.Controls.Add(this.lblType);
            this.pnlContent.Controls.Add(this.lblImage);
            this.pnlContent.Controls.Add(this.btnImage);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.lblDescription);
            this.pnlContent.Controls.Add(this.lblTransportationInfo);
            this.pnlContent.Controls.Add(this.btnBack);
            this.pnlContent.Controls.Add(this.txtCapacity);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.lblCapacity);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.txtImage);
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(78, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(872, 584);
            this.pnlContent.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(379, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 40);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "DELETE TRANSPORTATION";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(585, 472);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "UPDATE TRANSPORTATION";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTransportationID
            // 
            this.txtTransportationID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTransportationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransportationID.Location = new System.Drawing.Point(87, 67);
            this.txtTransportationID.Name = "txtTransportationID";
            this.txtTransportationID.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtTransportationID.Size = new System.Drawing.Size(183, 31);
            this.txtTransportationID.TabIndex = 33;
            this.txtTransportationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransportationID
            // 
            this.lblTransportationID.AutoSize = true;
            this.lblTransportationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationID.Location = new System.Drawing.Point(86, 47);
            this.lblTransportationID.Name = "lblTransportationID";
            this.lblTransportationID.Size = new System.Drawing.Size(105, 16);
            this.lblTransportationID.TabIndex = 32;
            this.lblTransportationID.Text = "TransportationID";
            // 
            // txtPricePerKM
            // 
            this.txtPricePerKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtPricePerKM.BorderColor = System.Drawing.Color.Black;
            this.txtPricePerKM.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPricePerKM.BorderFocusSize = 1;
            this.txtPricePerKM.BorderSize = 1;
            this.txtPricePerKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerKM.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerKM.Location = new System.Drawing.Point(446, 296);
            this.txtPricePerKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePerKM.Multiline = false;
            this.txtPricePerKM.Name = "txtPricePerKM";
            this.txtPricePerKM.Padding = new System.Windows.Forms.Padding(7);
            this.txtPricePerKM.PasswordChar = '\0';
            this.txtPricePerKM.Placeholder = "";
            this.txtPricePerKM.Size = new System.Drawing.Size(339, 31);
            this.txtPricePerKM.TabIndex = 31;
            this.txtPricePerKM.Texts = "";
            this.txtPricePerKM.UnderlinedStyle = false;
            // 
            // lblPricePerKM
            // 
            this.lblPricePerKM.AutoSize = true;
            this.lblPricePerKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerKM.Location = new System.Drawing.Point(443, 276);
            this.lblPricePerKM.Name = "lblPricePerKM";
            this.lblPricePerKM.Size = new System.Drawing.Size(74, 16);
            this.lblPricePerKM.TabIndex = 30;
            this.lblPricePerKM.Text = "PricePerKM";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.White;
            this.cmbType.BorderColor = System.Drawing.Color.Black;
            this.cmbType.BorderSize = 1;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.IconColor = System.Drawing.Color.Black;
            this.cmbType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbType.ListTextColor = System.Drawing.Color.Black;
            this.cmbType.Location = new System.Drawing.Point(87, 132);
            this.cmbType.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Padding = new System.Windows.Forms.Padding(1);
            this.cmbType.Size = new System.Drawing.Size(698, 31);
            this.cmbType.TabIndex = 29;
            this.cmbType.Texts = "";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtBasePrice.BorderColor = System.Drawing.Color.Black;
            this.txtBasePrice.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBasePrice.BorderFocusSize = 1;
            this.txtBasePrice.BorderSize = 1;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.ForeColor = System.Drawing.Color.Black;
            this.txtBasePrice.Location = new System.Drawing.Point(87, 360);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasePrice.Multiline = false;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Padding = new System.Windows.Forms.Padding(7);
            this.txtBasePrice.PasswordChar = '\0';
            this.txtBasePrice.Placeholder = "";
            this.txtBasePrice.Size = new System.Drawing.Size(698, 31);
            this.txtBasePrice.TabIndex = 28;
            this.txtBasePrice.Texts = "";
            this.txtBasePrice.UnderlinedStyle = false;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(84, 340);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(62, 16);
            this.lblBasePrice.TabIndex = 27;
            this.lblBasePrice.Text = "BasePrice";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(85, 113);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 16);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(84, 405);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(43, 16);
            this.lblImage.TabIndex = 23;
            this.lblImage.Text = "Image";
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(678, 425);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(107, 31);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Choose File";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusSize = 1;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(87, 202);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Placeholder = "";
            this.txtDescription.Size = new System.Drawing.Size(698, 59);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(84, 182);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 16);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // lblTransportationInfo
            // 
            this.lblTransportationInfo.AutoSize = true;
            this.lblTransportationInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationInfo.Location = new System.Drawing.Point(82, 1);
            this.lblTransportationInfo.Name = "lblTransportationInfo";
            this.lblTransportationInfo.Size = new System.Drawing.Size(261, 27);
            this.lblTransportationInfo.TabIndex = 19;
            this.lblTransportationInfo.Text = "TRANSPORTATION INFO";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 20;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(81, 481);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "   BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCapacity.BorderColor = System.Drawing.Color.Black;
            this.txtCapacity.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCapacity.BorderFocusSize = 1;
            this.txtCapacity.BorderSize = 1;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.ForeColor = System.Drawing.Color.Black;
            this.txtCapacity.Location = new System.Drawing.Point(87, 296);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Multiline = false;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Padding = new System.Windows.Forms.Padding(7);
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.Placeholder = "";
            this.txtCapacity.Size = new System.Drawing.Size(339, 31);
            this.txtCapacity.TabIndex = 12;
            this.txtCapacity.Texts = "";
            this.txtCapacity.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusSize = 1;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(290, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = '\0';
            this.txtName.Placeholder = "";
            this.txtName.Size = new System.Drawing.Size(495, 31);
            this.txtName.TabIndex = 9;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(86, 276);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(56, 16);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(287, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImage.Location = new System.Drawing.Point(87, 425);
            this.txtImage.Name = "txtImage";
            this.txtImage.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtImage.Size = new System.Drawing.Size(698, 31);
            this.txtImage.TabIndex = 24;
            this.txtImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransportationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Name = "TransportationInfo";
            this.Text = "TRANSPORTATION";
            this.Load += new System.EventHandler(this.TransportationInfo_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private StyledTextBox txtPricePerKM;
        private System.Windows.Forms.Label lblPricePerKM;
        private Classes.CustomComboBox cmbType;
        private StyledTextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnImage;
        private StyledTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTransportationInfo;
        private FontAwesome.Sharp.IconButton btnBack;
        private StyledTextBox txtCapacity;
        private StyledTextBox txtName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtImage;
        private System.Windows.Forms.Label lblTransportationID;
        private System.Windows.Forms.Label txtTransportationID;
        private RoundButton btnDelete;
        private RoundButton btnUpdate;
    }
}