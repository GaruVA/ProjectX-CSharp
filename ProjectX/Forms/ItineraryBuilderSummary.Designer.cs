namespace ProjectX.Forms
{
    partial class ItineraryBuilderSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItineraryBuilderSummary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new ProjectX.RoundButton();
            this.lblHr = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.txtName = new ProjectX.StyledTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new ProjectX.RoundButton();
            this.txtTotalCost = new ProjectX.StyledTextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.dgvCostSummary = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new ProjectX.RoundButton();
            this.txtNumDays = new ProjectX.StyledTextBox();
            this.txtItineraryID = new ProjectX.StyledTextBox();
            this.lblItineraryID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new ProjectX.StyledTextBox();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.txtNumPeople = new ProjectX.StyledTextBox();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblHr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 64);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Itinerary Summary";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnBack.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.BorderRadius = 18;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(258, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextColor = System.Drawing.Color.Black;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHr
            // 
            this.lblHr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHr.Location = new System.Drawing.Point(-349, 63);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(1427, 10);
            this.lblHr.TabIndex = 3;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblNumPeople);
            this.pnlContent.Controls.Add(this.txtNumPeople);
            this.pnlContent.Controls.Add(this.lblDescription);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.lblNumDays);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.txtTotalCost);
            this.pnlContent.Controls.Add(this.lblTotalCost);
            this.pnlContent.Controls.Add(this.dgvCostSummary);
            this.pnlContent.Controls.Add(this.btnCreate);
            this.pnlContent.Controls.Add(this.txtNumDays);
            this.pnlContent.Controls.Add(this.txtItineraryID);
            this.pnlContent.Controls.Add(this.lblItineraryID);
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(78, 84);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(872, 536);
            this.pnlContent.TabIndex = 4;
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDays.Location = new System.Drawing.Point(84, 174);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(109, 16);
            this.lblNumDays.TabIndex = 41;
            this.lblNumDays.Text = "Number Of Days ";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusSize = 1;
            this.txtName.BorderSize = 1;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(447, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = '\0';
            this.txtName.Placeholder = "";
            this.txtName.Size = new System.Drawing.Size(338, 31);
            this.txtName.TabIndex = 40;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(444, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(556, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 40);
            this.btnSave.TabIndex = 38;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtTotalCost.Location = new System.Drawing.Point(87, 378);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.Multiline = false;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotalCost.PasswordChar = '\0';
            this.txtTotalCost.Placeholder = "";
            this.txtTotalCost.Size = new System.Drawing.Size(698, 31);
            this.txtTotalCost.TabIndex = 35;
            this.txtTotalCost.Texts = "";
            this.txtTotalCost.UnderlinedStyle = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(84, 358);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(66, 16);
            this.lblTotalCost.TabIndex = 34;
            this.lblTotalCost.Text = "Total Cost";
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
            this.dgvCostSummary.Location = new System.Drawing.Point(87, 243);
            this.dgvCostSummary.Name = "dgvCostSummary";
            this.dgvCostSummary.ReadOnly = true;
            this.dgvCostSummary.RowHeadersVisible = false;
            this.dgvCostSummary.Size = new System.Drawing.Size(698, 103);
            this.dgvCostSummary.TabIndex = 31;
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
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnCreate.BorderColor = System.Drawing.Color.Black;
            this.btnCreate.BorderRadius = 20;
            this.btnCreate.BorderSize = 1;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(604, 425);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(181, 40);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "PROCEED TO BOOKING";
            this.btnCreate.TextColor = System.Drawing.Color.Black;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNumDays
            // 
            this.txtNumDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumDays.BorderColor = System.Drawing.Color.Black;
            this.txtNumDays.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNumDays.BorderFocusSize = 1;
            this.txtNumDays.BorderSize = 1;
            this.txtNumDays.Enabled = false;
            this.txtNumDays.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDays.ForeColor = System.Drawing.Color.Black;
            this.txtNumDays.Location = new System.Drawing.Point(87, 194);
            this.txtNumDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDays.Multiline = false;
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumDays.PasswordChar = '\0';
            this.txtNumDays.Placeholder = "";
            this.txtNumDays.Size = new System.Drawing.Size(343, 31);
            this.txtNumDays.TabIndex = 9;
            this.txtNumDays.Texts = "";
            this.txtNumDays.UnderlinedStyle = false;
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
            this.txtItineraryID.Location = new System.Drawing.Point(87, 54);
            this.txtItineraryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItineraryID.Multiline = false;
            this.txtItineraryID.Name = "txtItineraryID";
            this.txtItineraryID.Padding = new System.Windows.Forms.Padding(7);
            this.txtItineraryID.PasswordChar = '\0';
            this.txtItineraryID.Placeholder = "";
            this.txtItineraryID.Size = new System.Drawing.Size(343, 31);
            this.txtItineraryID.TabIndex = 7;
            this.txtItineraryID.Texts = "";
            this.txtItineraryID.UnderlinedStyle = false;
            // 
            // lblItineraryID
            // 
            this.lblItineraryID.AutoSize = true;
            this.lblItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItineraryID.Location = new System.Drawing.Point(84, 34);
            this.lblItineraryID.Name = "lblItineraryID";
            this.lblItineraryID.Size = new System.Drawing.Size(66, 16);
            this.lblItineraryID.TabIndex = 0;
            this.lblItineraryID.Text = "ItineraryID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(84, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 16);
            this.lblDescription.TabIndex = 43;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusSize = 1;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(87, 117);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Placeholder = "";
            this.txtDescription.Size = new System.Drawing.Size(698, 47);
            this.txtDescription.TabIndex = 42;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.Location = new System.Drawing.Point(444, 174);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(135, 16);
            this.lblNumPeople.TabIndex = 45;
            this.lblNumPeople.Text = "Number Of Attendees";
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumPeople.BorderColor = System.Drawing.Color.Black;
            this.txtNumPeople.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNumPeople.BorderFocusSize = 1;
            this.txtNumPeople.BorderSize = 1;
            this.txtNumPeople.Enabled = false;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumPeople.Location = new System.Drawing.Point(447, 194);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPeople.Multiline = false;
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumPeople.PasswordChar = '\0';
            this.txtNumPeople.Placeholder = "";
            this.txtNumPeople.Size = new System.Drawing.Size(338, 31);
            this.txtNumPeople.TabIndex = 44;
            this.txtNumPeople.Texts = "";
            this.txtNumPeople.UnderlinedStyle = false;
            // 
            // ItineraryBuilderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "ItineraryBuilderSummary";
            this.Text = "ITINERARY BUILDER";
            this.Load += new System.EventHandler(this.ItineraryBuilderSummary_Load);
            this.panel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private RoundButton btnBack;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Panel pnlContent;
        private RoundButton btnSave;
        private StyledTextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.DataGridView dgvCostSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private RoundButton btnCreate;
        private StyledTextBox txtNumDays;
        private StyledTextBox txtItineraryID;
        private System.Windows.Forms.Label lblItineraryID;
        private System.Windows.Forms.Label lblNumDays;
        private StyledTextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumPeople;
        private StyledTextBox txtNumPeople;
        private System.Windows.Forms.Label lblDescription;
        private StyledTextBox txtDescription;
    }
}