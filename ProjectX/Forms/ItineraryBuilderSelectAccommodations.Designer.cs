namespace ProjectX.Forms
{
    partial class ItineraryBuilderSelectAccommodations
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
            this.btnBack = new ProjectX.RoundButton();
            this.btnNext = new ProjectX.RoundButton();
            this.lblHr = new System.Windows.Forms.Label();
            this.pnlDay = new System.Windows.Forms.Panel();
            this.btnDayDefault = new ProjectX.RoundButton();
            this.pnlItinerarySidebar = new System.Windows.Forms.Panel();
            this.pnlSelectorContent = new System.Windows.Forms.Panel();
            this.pnlSelectorHeader = new System.Windows.Forms.Panel();
            this.txtSelector = new ProjectX.StyledTextBox();
            this.pnlItineraryBuilder = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlDay.SuspendLayout();
            this.pnlItinerarySidebar.SuspendLayout();
            this.pnlSelectorHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblHr);
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
            this.lblTitle.Location = new System.Drawing.Point(299, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Select Accommodations";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // lblHr
            // 
            this.lblHr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHr.Location = new System.Drawing.Point(-349, 63);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(1054, 10);
            this.lblHr.TabIndex = 3;
            // 
            // pnlDay
            // 
            this.pnlDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlDay.Controls.Add(this.btnDayDefault);
            this.pnlDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDay.Location = new System.Drawing.Point(0, 64);
            this.pnlDay.Name = "pnlDay";
            this.pnlDay.Size = new System.Drawing.Size(88, 616);
            this.pnlDay.TabIndex = 5;
            // 
            // btnDayDefault
            // 
            this.btnDayDefault.BackColor = System.Drawing.Color.White;
            this.btnDayDefault.BackgroundColor = System.Drawing.Color.White;
            this.btnDayDefault.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnDayDefault.BorderRadius = 0;
            this.btnDayDefault.BorderSize = 0;
            this.btnDayDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDayDefault.Enabled = false;
            this.btnDayDefault.FlatAppearance.BorderSize = 0;
            this.btnDayDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayDefault.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayDefault.ForeColor = System.Drawing.Color.Black;
            this.btnDayDefault.Location = new System.Drawing.Point(0, 0);
            this.btnDayDefault.Name = "btnDayDefault";
            this.btnDayDefault.Size = new System.Drawing.Size(88, 40);
            this.btnDayDefault.TabIndex = 0;
            this.btnDayDefault.Text = "NIGHT 1";
            this.btnDayDefault.TextColor = System.Drawing.Color.Black;
            this.btnDayDefault.UseVisualStyleBackColor = false;
            this.btnDayDefault.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // pnlItinerarySidebar
            // 
            this.pnlItinerarySidebar.BackColor = System.Drawing.Color.White;
            this.pnlItinerarySidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItinerarySidebar.Controls.Add(this.pnlSelectorContent);
            this.pnlItinerarySidebar.Controls.Add(this.pnlSelectorHeader);
            this.pnlItinerarySidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItinerarySidebar.Location = new System.Drawing.Point(704, 64);
            this.pnlItinerarySidebar.Name = "pnlItinerarySidebar";
            this.pnlItinerarySidebar.Size = new System.Drawing.Size(320, 616);
            this.pnlItinerarySidebar.TabIndex = 6;
            // 
            // pnlSelectorContent
            // 
            this.pnlSelectorContent.AutoScroll = true;
            this.pnlSelectorContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectorContent.Location = new System.Drawing.Point(0, 64);
            this.pnlSelectorContent.Name = "pnlSelectorContent";
            this.pnlSelectorContent.Size = new System.Drawing.Size(318, 550);
            this.pnlSelectorContent.TabIndex = 6;
            // 
            // pnlSelectorHeader
            // 
            this.pnlSelectorHeader.BackColor = System.Drawing.Color.White;
            this.pnlSelectorHeader.Controls.Add(this.txtSelector);
            this.pnlSelectorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectorHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectorHeader.Name = "pnlSelectorHeader";
            this.pnlSelectorHeader.Size = new System.Drawing.Size(318, 64);
            this.pnlSelectorHeader.TabIndex = 5;
            // 
            // txtSelector
            // 
            this.txtSelector.BackColor = System.Drawing.SystemColors.Window;
            this.txtSelector.BorderColor = System.Drawing.Color.Black;
            this.txtSelector.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSelector.BorderFocusSize = 1;
            this.txtSelector.BorderSize = 1;
            this.txtSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelector.ForeColor = System.Drawing.Color.DimGray;
            this.txtSelector.Location = new System.Drawing.Point(10, 16);
            this.txtSelector.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelector.Multiline = false;
            this.txtSelector.Name = "txtSelector";
            this.txtSelector.Padding = new System.Windows.Forms.Padding(7);
            this.txtSelector.PasswordChar = '\0';
            this.txtSelector.Placeholder = "Search by name";
            this.txtSelector.Size = new System.Drawing.Size(300, 31);
            this.txtSelector.TabIndex = 12;
            this.txtSelector.Texts = "Search by name";
            this.txtSelector.UnderlinedStyle = false;
            this.txtSelector._TextChanged += new System.EventHandler(this.txtSelector__TextChanged);
            // 
            // pnlItineraryBuilder
            // 
            this.pnlItineraryBuilder.AllowDrop = true;
            this.pnlItineraryBuilder.AutoScroll = true;
            this.pnlItineraryBuilder.BackColor = System.Drawing.Color.White;
            this.pnlItineraryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItineraryBuilder.Location = new System.Drawing.Point(88, 64);
            this.pnlItineraryBuilder.Name = "pnlItineraryBuilder";
            this.pnlItineraryBuilder.Size = new System.Drawing.Size(616, 616);
            this.pnlItineraryBuilder.TabIndex = 7;
            // 
            // ItineraryBuilderSelectAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlItineraryBuilder);
            this.Controls.Add(this.pnlItinerarySidebar);
            this.Controls.Add(this.pnlDay);
            this.Controls.Add(this.panel1);
            this.Name = "ItineraryBuilderSelectAccommodations";
            this.Text = "ITINERARY BUILDER";
            this.Load += new System.EventHandler(this.ItineraryBuilderSelectAccommodations_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDay.ResumeLayout(false);
            this.pnlItinerarySidebar.ResumeLayout(false);
            this.pnlSelectorHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private RoundButton btnBack;
        private RoundButton btnNext;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Panel pnlDay;
        private RoundButton btnDayDefault;
        private System.Windows.Forms.Panel pnlItinerarySidebar;
        private System.Windows.Forms.Panel pnlSelectorContent;
        private System.Windows.Forms.Panel pnlSelectorHeader;
        private StyledTextBox txtSelector;
        private System.Windows.Forms.Panel pnlItineraryBuilder;
    }
}