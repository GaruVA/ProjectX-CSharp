namespace ProjectX.Forms
{
    partial class BookingsCreate
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
            this.dgvCostSummary = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCustomer = new ProjectX.Classes.CustomComboBox();
            this.txtEndDate = new ProjectX.StyledTextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new ProjectX.StyledTextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbStatus = new ProjectX.Classes.CustomComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTotalCost = new ProjectX.StyledTextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtBookingID = new ProjectX.StyledTextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new ProjectX.Classes.CustomComboBox();
            this.txtItineraryID = new ProjectX.StyledTextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblItineraryID = new System.Windows.Forms.Label();
            this.btnCreate = new ProjectX.RoundButton();
            this.lblCreateNewBooking = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContent.Controls.Add(this.dgvCostSummary);
            this.pnlContent.Controls.Add(this.cmbCustomer);
            this.pnlContent.Controls.Add(this.txtEndDate);
            this.pnlContent.Controls.Add(this.lblEndDate);
            this.pnlContent.Controls.Add(this.txtStartDate);
            this.pnlContent.Controls.Add(this.lblStartDate);
            this.pnlContent.Controls.Add(this.cmbStatus);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Controls.Add(this.txtTotalCost);
            this.pnlContent.Controls.Add(this.lblTotalCost);
            this.pnlContent.Controls.Add(this.txtBookingID);
            this.pnlContent.Controls.Add(this.lblBookingID);
            this.pnlContent.Controls.Add(this.cmbPaymentMethod);
            this.pnlContent.Controls.Add(this.txtItineraryID);
            this.pnlContent.Controls.Add(this.lblPaymentMethod);
            this.pnlContent.Controls.Add(this.lblCustomer);
            this.pnlContent.Controls.Add(this.lblItineraryID);
            this.pnlContent.Controls.Add(this.btnCreate);
            this.pnlContent.Controls.Add(this.lblCreateNewBooking);
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(78, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(872, 581);
            this.pnlContent.TabIndex = 5;
            // 
            // dgvCostSummary
            // 
            this.dgvCostSummary.AllowUserToAddRows = false;
            this.dgvCostSummary.AllowUserToDeleteRows = false;
            this.dgvCostSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCostSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Price});
            this.dgvCostSummary.Location = new System.Drawing.Point(87, 305);
            this.dgvCostSummary.Name = "dgvCostSummary";
            this.dgvCostSummary.ReadOnly = true;
            this.dgvCostSummary.RowHeadersVisible = false;
            this.dgvCostSummary.Size = new System.Drawing.Size(698, 103);
            this.dgvCostSummary.TabIndex = 61;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.White;
            this.cmbCustomer.BorderColor = System.Drawing.Color.Black;
            this.cmbCustomer.BorderSize = 1;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.ForeColor = System.Drawing.Color.Black;
            this.cmbCustomer.IconColor = System.Drawing.Color.Black;
            this.cmbCustomer.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCustomer.ListTextColor = System.Drawing.Color.Black;
            this.cmbCustomer.Location = new System.Drawing.Point(87, 135);
            this.cmbCustomer.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCustomer.Size = new System.Drawing.Size(698, 31);
            this.cmbCustomer.TabIndex = 60;
            this.cmbCustomer.Texts = "";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndDate.BorderColor = System.Drawing.Color.Black;
            this.txtEndDate.BorderFocusColor = System.Drawing.Color.Black;
            this.txtEndDate.BorderFocusSize = 1;
            this.txtEndDate.BorderSize = 1;
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.Color.Black;
            this.txtEndDate.Location = new System.Drawing.Point(447, 259);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Multiline = false;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Padding = new System.Windows.Forms.Padding(7);
            this.txtEndDate.PasswordChar = '\0';
            this.txtEndDate.Placeholder = "";
            this.txtEndDate.Size = new System.Drawing.Size(338, 31);
            this.txtEndDate.TabIndex = 59;
            this.txtEndDate.Texts = "";
            this.txtEndDate.UnderlinedStyle = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(444, 239);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(60, 16);
            this.lblEndDate.TabIndex = 58;
            this.lblEndDate.Text = "End Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.White;
            this.txtStartDate.BorderColor = System.Drawing.Color.Black;
            this.txtStartDate.BorderFocusColor = System.Drawing.Color.Black;
            this.txtStartDate.BorderFocusSize = 1;
            this.txtStartDate.BorderSize = 1;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.txtStartDate.Location = new System.Drawing.Point(87, 259);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Multiline = false;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Padding = new System.Windows.Forms.Padding(7);
            this.txtStartDate.PasswordChar = '\0';
            this.txtStartDate.Placeholder = "yyyy-MM-dd";
            this.txtStartDate.Size = new System.Drawing.Size(338, 31);
            this.txtStartDate.TabIndex = 57;
            this.txtStartDate.Texts = "yyyy-MM-dd";
            this.txtStartDate.UnderlinedStyle = false;
            this.txtStartDate._TextChanged += new System.EventHandler(this.txtStartDate__TextChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(84, 239);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 16);
            this.lblStartDate.TabIndex = 56;
            this.lblStartDate.Text = "Start Date";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.BorderColor = System.Drawing.Color.Black;
            this.cmbStatus.BorderSize = 1;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.IconColor = System.Drawing.Color.Black;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Canceled"});
            this.cmbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbStatus.ListTextColor = System.Drawing.Color.Black;
            this.cmbStatus.Location = new System.Drawing.Point(447, 496);
            this.cmbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cmbStatus.Size = new System.Drawing.Size(338, 31);
            this.cmbStatus.TabIndex = 55;
            this.cmbStatus.Texts = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(444, 477);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 16);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalCost.BorderColor = System.Drawing.Color.Black;
            this.txtTotalCost.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTotalCost.BorderFocusSize = 1;
            this.txtTotalCost.BorderSize = 1;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCost.Location = new System.Drawing.Point(87, 436);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.Multiline = false;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotalCost.PasswordChar = '\0';
            this.txtTotalCost.Placeholder = "";
            this.txtTotalCost.Size = new System.Drawing.Size(698, 31);
            this.txtTotalCost.TabIndex = 53;
            this.txtTotalCost.Texts = "";
            this.txtTotalCost.UnderlinedStyle = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(84, 416);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(66, 16);
            this.lblTotalCost.TabIndex = 52;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtBookingID
            // 
            this.txtBookingID.BackColor = System.Drawing.Color.White;
            this.txtBookingID.BorderColor = System.Drawing.Color.Black;
            this.txtBookingID.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBookingID.BorderFocusSize = 1;
            this.txtBookingID.BorderSize = 1;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.ForeColor = System.Drawing.Color.Black;
            this.txtBookingID.Location = new System.Drawing.Point(87, 74);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Multiline = false;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Padding = new System.Windows.Forms.Padding(7);
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.Placeholder = "";
            this.txtBookingID.Size = new System.Drawing.Size(698, 31);
            this.txtBookingID.TabIndex = 51;
            this.txtBookingID.Texts = "";
            this.txtBookingID.UnderlinedStyle = false;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(84, 54);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(66, 16);
            this.lblBookingID.TabIndex = 50;
            this.lblBookingID.Text = "BookingID";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.White;
            this.cmbPaymentMethod.BorderColor = System.Drawing.Color.Black;
            this.cmbPaymentMethod.BorderSize = 1;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cmbPaymentMethod.IconColor = System.Drawing.Color.Black;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Cash"});
            this.cmbPaymentMethod.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPaymentMethod.ListTextColor = System.Drawing.Color.Black;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(87, 496);
            this.cmbPaymentMethod.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPaymentMethod.Size = new System.Drawing.Size(338, 31);
            this.cmbPaymentMethod.TabIndex = 49;
            this.cmbPaymentMethod.Texts = "";
            // 
            // txtItineraryID
            // 
            this.txtItineraryID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtItineraryID.BorderColor = System.Drawing.Color.Black;
            this.txtItineraryID.BorderFocusColor = System.Drawing.Color.Black;
            this.txtItineraryID.BorderFocusSize = 1;
            this.txtItineraryID.BorderSize = 1;
            this.txtItineraryID.Enabled = false;
            this.txtItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryID.ForeColor = System.Drawing.Color.Black;
            this.txtItineraryID.Location = new System.Drawing.Point(87, 196);
            this.txtItineraryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItineraryID.Multiline = false;
            this.txtItineraryID.Name = "txtItineraryID";
            this.txtItineraryID.Padding = new System.Windows.Forms.Padding(7);
            this.txtItineraryID.PasswordChar = '\0';
            this.txtItineraryID.Placeholder = "";
            this.txtItineraryID.Size = new System.Drawing.Size(698, 31);
            this.txtItineraryID.TabIndex = 47;
            this.txtItineraryID.Texts = "";
            this.txtItineraryID.UnderlinedStyle = false;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(84, 477);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(106, 16);
            this.lblPaymentMethod.TabIndex = 46;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(84, 115);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 16);
            this.lblCustomer.TabIndex = 45;
            this.lblCustomer.Text = "Customer";
            // 
            // lblItineraryID
            // 
            this.lblItineraryID.AutoSize = true;
            this.lblItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItineraryID.Location = new System.Drawing.Point(84, 176);
            this.lblItineraryID.Name = "lblItineraryID";
            this.lblItineraryID.Size = new System.Drawing.Size(66, 16);
            this.lblItineraryID.TabIndex = 44;
            this.lblItineraryID.Text = "ItineraryID";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCreate.BorderRadius = 20;
            this.btnCreate.BorderSize = 1;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(635, 540);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 39;
            this.btnCreate.Text = "CREATE BOOKING";
            this.btnCreate.TextColor = System.Drawing.Color.Black;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreateNewBooking
            // 
            this.lblCreateNewBooking.AutoSize = true;
            this.lblCreateNewBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewBooking.Location = new System.Drawing.Point(82, 0);
            this.lblCreateNewBooking.Name = "lblCreateNewBooking";
            this.lblCreateNewBooking.Size = new System.Drawing.Size(247, 27);
            this.lblCreateNewBooking.TabIndex = 20;
            this.lblCreateNewBooking.Text = "CREATE NEW BOOKING";
            // 
            // BookingsCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Name = "BookingsCreate";
            this.Text = "BOOKINGS";
            this.Load += new System.EventHandler(this.BookingsCreate_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvCostSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private Classes.CustomComboBox cmbCustomer;
        private StyledTextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private StyledTextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private Classes.CustomComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private StyledTextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private StyledTextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private Classes.CustomComboBox cmbPaymentMethod;
        private StyledTextBox txtItineraryID;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblItineraryID;
        private RoundButton btnCreate;
        private System.Windows.Forms.Label lblCreateNewBooking;
    }
}