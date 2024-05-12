namespace ProjectX.Forms
{
    partial class DestinationsInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnDelete = new ProjectX.RoundButton();
            this.btnUpdate = new ProjectX.RoundButton();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDestinationID = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtDescription = new ProjectX.StyledTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDestinationInfo = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.txtCity = new ProjectX.StyledTextBox();
            this.txtDistrict = new ProjectX.StyledTextBox();
            this.txtName = new ProjectX.StyledTextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDestinationID = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContent.Controls.Add(this.lblEvents);
            this.pnlContent.Controls.Add(this.btnDelete);
            this.pnlContent.Controls.Add(this.btnUpdate);
            this.pnlContent.Controls.Add(this.dgvEvents);
            this.pnlContent.Controls.Add(this.txtDestinationID);
            this.pnlContent.Controls.Add(this.lblImage);
            this.pnlContent.Controls.Add(this.btnImage);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.lblDescription);
            this.pnlContent.Controls.Add(this.lblDestinationInfo);
            this.pnlContent.Controls.Add(this.btnBack);
            this.pnlContent.Controls.Add(this.txtCity);
            this.pnlContent.Controls.Add(this.txtDistrict);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.lblCity);
            this.pnlContent.Controls.Add(this.lblDistrict);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.lblDestinationID);
            this.pnlContent.Controls.Add(this.txtImage);
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(78, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(872, 584);
            this.pnlContent.TabIndex = 2;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(84, 358);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(44, 16);
            this.lblEvents.TabIndex = 37;
            this.lblEvents.Text = "Events";
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
            this.btnDelete.Location = new System.Drawing.Point(429, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "DELETE DESTINATION";
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
            this.btnUpdate.Location = new System.Drawing.Point(610, 519);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 40);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE DESTINATION";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventName,
            this.Description,
            this.StartDate,
            this.EndDate,
            this.PricePerPerson});
            this.dgvEvents.Location = new System.Drawing.Point(87, 377);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.Size = new System.Drawing.Size(698, 118);
            this.dgvEvents.TabIndex = 36;
            // 
            // EventID
            // 
            this.EventID.HeaderText = "EventID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Name";
            this.EventName.Name = "EventName";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            // 
            // PricePerPerson
            // 
            this.PricePerPerson.HeaderText = "Price Per Person";
            this.PricePerPerson.Name = "PricePerPerson";
            // 
            // txtDestinationID
            // 
            this.txtDestinationID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDestinationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinationID.Location = new System.Drawing.Point(87, 74);
            this.txtDestinationID.Name = "txtDestinationID";
            this.txtDestinationID.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtDestinationID.Size = new System.Drawing.Size(160, 31);
            this.txtDestinationID.TabIndex = 25;
            this.txtDestinationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(84, 290);
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
            this.btnImage.Location = new System.Drawing.Point(678, 310);
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
            this.txtDescription.Location = new System.Drawing.Point(87, 138);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Placeholder = "";
            this.txtDescription.Size = new System.Drawing.Size(698, 78);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(84, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 16);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // lblDestinationInfo
            // 
            this.lblDestinationInfo.AutoSize = true;
            this.lblDestinationInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationInfo.Location = new System.Drawing.Point(82, 1);
            this.lblDestinationInfo.Name = "lblDestinationInfo";
            this.lblDestinationInfo.Size = new System.Drawing.Size(210, 27);
            this.lblDestinationInfo.TabIndex = 19;
            this.lblDestinationInfo.Text = "DESTINATION INFO";
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
            this.btnBack.Location = new System.Drawing.Point(81, 528);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "   BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.BorderColor = System.Drawing.Color.Black;
            this.txtCity.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCity.BorderFocusSize = 1;
            this.txtCity.BorderSize = 1;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(446, 248);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(7);
            this.txtCity.PasswordChar = '\0';
            this.txtCity.Placeholder = "";
            this.txtCity.Size = new System.Drawing.Size(339, 31);
            this.txtCity.TabIndex = 12;
            this.txtCity.Texts = "";
            this.txtCity.UnderlinedStyle = false;
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistrict.BorderColor = System.Drawing.Color.Black;
            this.txtDistrict.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDistrict.BorderFocusSize = 1;
            this.txtDistrict.BorderSize = 1;
            this.txtDistrict.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtDistrict.Location = new System.Drawing.Point(87, 248);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrict.Multiline = false;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Padding = new System.Windows.Forms.Padding(7);
            this.txtDistrict.PasswordChar = '\0';
            this.txtDistrict.Placeholder = "";
            this.txtDistrict.Size = new System.Drawing.Size(337, 31);
            this.txtDistrict.TabIndex = 11;
            this.txtDistrict.Texts = "";
            this.txtDistrict.UnderlinedStyle = false;
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
            this.txtName.Location = new System.Drawing.Point(271, 74);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = '\0';
            this.txtName.Placeholder = "";
            this.txtName.Size = new System.Drawing.Size(514, 31);
            this.txtName.TabIndex = 9;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(443, 228);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(84, 228);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(47, 16);
            this.lblDistrict.TabIndex = 3;
            this.lblDistrict.Text = "District";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(268, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDestinationID
            // 
            this.lblDestinationID.AutoSize = true;
            this.lblDestinationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationID.Location = new System.Drawing.Point(84, 54);
            this.lblDestinationID.Name = "lblDestinationID";
            this.lblDestinationID.Size = new System.Drawing.Size(84, 16);
            this.lblDestinationID.TabIndex = 0;
            this.lblDestinationID.Text = "DestinationID";
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImage.Location = new System.Drawing.Point(87, 310);
            this.txtImage.Name = "txtImage";
            this.txtImage.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtImage.Size = new System.Drawing.Size(698, 31);
            this.txtImage.TabIndex = 24;
            this.txtImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DestinationsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Name = "DestinationsInfo";
            this.Text = "DESTINATIONS";
            this.Load += new System.EventHandler(this.DestinationsInfo_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnImage;
        private StyledTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDestinationInfo;
        private FontAwesome.Sharp.IconButton btnBack;
        private StyledTextBox txtCity;
        private StyledTextBox txtDistrict;
        private StyledTextBox txtName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDestinationID;
        private System.Windows.Forms.Label txtImage;
        private System.Windows.Forms.Label txtDestinationID;
        private RoundButton btnDelete;
        private RoundButton btnUpdate;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerPerson;
    }
}