namespace ProjectX.Forms
{
    partial class ItineraryBuilderSetInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNext = new ProjectX.RoundButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new ProjectX.StyledTextBox();
            this.txtNumPeople = new ProjectX.StyledTextBox();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.txtName = new ProjectX.StyledTextBox();
            this.txtNumDays = new ProjectX.StyledTextBox();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtItineraryID = new ProjectX.StyledTextBox();
            this.lblItineraryID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 64);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 23);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Set Itinerary Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNext.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.BorderRadius = 18;
            this.btnNext.BorderSize = 0;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(719, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContent.Controls.Add(this.lblDescription);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.txtNumPeople);
            this.pnlContent.Controls.Add(this.lblNumPeople);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.txtNumDays);
            this.pnlContent.Controls.Add(this.lblNumDays);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.txtItineraryID);
            this.pnlContent.Controls.Add(this.lblItineraryID);
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(76, 97);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(872, 535);
            this.pnlContent.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(84, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 16);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusSize = 1;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(87, 204);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Placeholder = "";
            this.txtDescription.Size = new System.Drawing.Size(702, 47);
            this.txtDescription.TabIndex = 44;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumPeople.BorderColor = System.Drawing.Color.Black;
            this.txtNumPeople.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNumPeople.BorderFocusSize = 1;
            this.txtNumPeople.BorderSize = 1;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumPeople.Location = new System.Drawing.Point(87, 350);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPeople.Multiline = false;
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumPeople.PasswordChar = '\0';
            this.txtNumPeople.Placeholder = "";
            this.txtNumPeople.Size = new System.Drawing.Size(702, 31);
            this.txtNumPeople.TabIndex = 20;
            this.txtNumPeople.Texts = "";
            this.txtNumPeople.UnderlinedStyle = false;
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.Location = new System.Drawing.Point(84, 330);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(133, 16);
            this.lblNumPeople.TabIndex = 19;
            this.lblNumPeople.Text = "Number of Attendees";
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
            this.txtName.Location = new System.Drawing.Point(87, 140);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = '\0';
            this.txtName.Placeholder = "";
            this.txtName.Size = new System.Drawing.Size(702, 31);
            this.txtName.TabIndex = 18;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtNumDays
            // 
            this.txtNumDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumDays.BorderColor = System.Drawing.Color.Black;
            this.txtNumDays.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNumDays.BorderFocusSize = 1;
            this.txtNumDays.BorderSize = 1;
            this.txtNumDays.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDays.ForeColor = System.Drawing.Color.Black;
            this.txtNumDays.Location = new System.Drawing.Point(87, 284);
            this.txtNumDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDays.Multiline = false;
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumDays.PasswordChar = '\0';
            this.txtNumDays.Placeholder = "";
            this.txtNumDays.Size = new System.Drawing.Size(702, 31);
            this.txtNumDays.TabIndex = 17;
            this.txtNumDays.Texts = "";
            this.txtNumDays.UnderlinedStyle = false;
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDays.Location = new System.Drawing.Point(84, 264);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(103, 16);
            this.lblNumDays.TabIndex = 16;
            this.lblNumDays.Text = "Number of Days";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(84, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtItineraryID
            // 
            this.txtItineraryID.BackColor = System.Drawing.SystemColors.Window;
            this.txtItineraryID.BorderColor = System.Drawing.Color.Black;
            this.txtItineraryID.BorderFocusColor = System.Drawing.Color.Black;
            this.txtItineraryID.BorderFocusSize = 1;
            this.txtItineraryID.BorderSize = 1;
            this.txtItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryID.ForeColor = System.Drawing.Color.Black;
            this.txtItineraryID.Location = new System.Drawing.Point(87, 67);
            this.txtItineraryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItineraryID.Multiline = false;
            this.txtItineraryID.Name = "txtItineraryID";
            this.txtItineraryID.Padding = new System.Windows.Forms.Padding(7);
            this.txtItineraryID.PasswordChar = '\0';
            this.txtItineraryID.Placeholder = "";
            this.txtItineraryID.Size = new System.Drawing.Size(702, 31);
            this.txtItineraryID.TabIndex = 7;
            this.txtItineraryID.Texts = "";
            this.txtItineraryID.UnderlinedStyle = false;
            // 
            // lblItineraryID
            // 
            this.lblItineraryID.AutoSize = true;
            this.lblItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItineraryID.Location = new System.Drawing.Point(84, 47);
            this.lblItineraryID.Name = "lblItineraryID";
            this.lblItineraryID.Size = new System.Drawing.Size(66, 16);
            this.lblItineraryID.TabIndex = 0;
            this.lblItineraryID.Text = "ItineraryID";
            // 
            // ItineraryBuilderSetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "ItineraryBuilderSetInfo";
            this.Text = "ITINERARY BUILDER";
            this.Load += new System.EventHandler(this.ItineraryBuilderSetInfo_Load);
            this.panel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton btnNext;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblName;
        private StyledTextBox txtItineraryID;
        private System.Windows.Forms.Label lblItineraryID;
        private StyledTextBox txtNumDays;
        private System.Windows.Forms.Label lblNumDays;
        private StyledTextBox txtName;
        private StyledTextBox txtNumPeople;
        private System.Windows.Forms.Label lblNumPeople;
        private System.Windows.Forms.Label lblDescription;
        private StyledTextBox txtDescription;
    }
}