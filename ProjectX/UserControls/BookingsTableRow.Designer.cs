namespace ProjectX.UserControls
{
    partial class BookingsTableRow
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
            this.pnlTableRowStatus = new System.Windows.Forms.Panel();
            this.lblTableRowStatus = new System.Windows.Forms.Label();
            this.pnlTableRowEndDate = new System.Windows.Forms.Panel();
            this.lblTableRowEndDate = new System.Windows.Forms.Label();
            this.pnlTableRowStartDate = new System.Windows.Forms.Panel();
            this.lblTableRowStartDate = new System.Windows.Forms.Label();
            this.pnlTableRowCustomer = new System.Windows.Forms.Panel();
            this.lblTableRowCustomer = new System.Windows.Forms.Label();
            this.pnlTableRowItineraryID = new System.Windows.Forms.Panel();
            this.lblTableRowItineraryID = new System.Windows.Forms.Label();
            this.pnlTableRowBookingID = new System.Windows.Forms.Panel();
            this.lblTableRowBookingID = new System.Windows.Forms.Label();
            this.pnlTableRow.SuspendLayout();
            this.pnlTableRowStatus.SuspendLayout();
            this.pnlTableRowEndDate.SuspendLayout();
            this.pnlTableRowStartDate.SuspendLayout();
            this.pnlTableRowCustomer.SuspendLayout();
            this.pnlTableRowItineraryID.SuspendLayout();
            this.pnlTableRowBookingID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableRow
            // 
            this.pnlTableRow.Controls.Add(this.label1);
            this.pnlTableRow.Controls.Add(this.pnlTableRowStatus);
            this.pnlTableRow.Controls.Add(this.pnlTableRowEndDate);
            this.pnlTableRow.Controls.Add(this.pnlTableRowStartDate);
            this.pnlTableRow.Controls.Add(this.pnlTableRowCustomer);
            this.pnlTableRow.Controls.Add(this.pnlTableRowItineraryID);
            this.pnlTableRow.Controls.Add(this.pnlTableRowBookingID);
            this.pnlTableRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRow.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRow.Name = "pnlTableRow";
            this.pnlTableRow.Size = new System.Drawing.Size(870, 60);
            this.pnlTableRow.TabIndex = 5;
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
            // pnlTableRowStatus
            // 
            this.pnlTableRowStatus.Controls.Add(this.lblTableRowStatus);
            this.pnlTableRowStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowStatus.Location = new System.Drawing.Point(737, 0);
            this.pnlTableRowStatus.Name = "pnlTableRowStatus";
            this.pnlTableRowStatus.Size = new System.Drawing.Size(133, 60);
            this.pnlTableRowStatus.TabIndex = 5;
            // 
            // lblTableRowStatus
            // 
            this.lblTableRowStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowStatus.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowStatus.Name = "lblTableRowStatus";
            this.lblTableRowStatus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowStatus.Size = new System.Drawing.Size(133, 60);
            this.lblTableRowStatus.TabIndex = 1;
            this.lblTableRowStatus.Text = "Status";
            this.lblTableRowStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowStatus.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowStatus.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowStatus.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowEndDate
            // 
            this.pnlTableRowEndDate.Controls.Add(this.lblTableRowEndDate);
            this.pnlTableRowEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowEndDate.Location = new System.Drawing.Point(611, 0);
            this.pnlTableRowEndDate.Name = "pnlTableRowEndDate";
            this.pnlTableRowEndDate.Size = new System.Drawing.Size(126, 60);
            this.pnlTableRowEndDate.TabIndex = 7;
            // 
            // lblTableRowEndDate
            // 
            this.lblTableRowEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowEndDate.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowEndDate.Name = "lblTableRowEndDate";
            this.lblTableRowEndDate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowEndDate.Size = new System.Drawing.Size(126, 60);
            this.lblTableRowEndDate.TabIndex = 1;
            this.lblTableRowEndDate.Text = "End Date";
            this.lblTableRowEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowEndDate.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowEndDate.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowEndDate.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowStartDate
            // 
            this.pnlTableRowStartDate.Controls.Add(this.lblTableRowStartDate);
            this.pnlTableRowStartDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowStartDate.Location = new System.Drawing.Point(485, 0);
            this.pnlTableRowStartDate.Name = "pnlTableRowStartDate";
            this.pnlTableRowStartDate.Size = new System.Drawing.Size(126, 60);
            this.pnlTableRowStartDate.TabIndex = 4;
            // 
            // lblTableRowStartDate
            // 
            this.lblTableRowStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowStartDate.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowStartDate.Name = "lblTableRowStartDate";
            this.lblTableRowStartDate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowStartDate.Size = new System.Drawing.Size(126, 60);
            this.lblTableRowStartDate.TabIndex = 1;
            this.lblTableRowStartDate.Text = "Start Date";
            this.lblTableRowStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowStartDate.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowStartDate.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowStartDate.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowCustomer
            // 
            this.pnlTableRowCustomer.Controls.Add(this.lblTableRowCustomer);
            this.pnlTableRowCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowCustomer.Location = new System.Drawing.Point(245, 0);
            this.pnlTableRowCustomer.Name = "pnlTableRowCustomer";
            this.pnlTableRowCustomer.Size = new System.Drawing.Size(240, 60);
            this.pnlTableRowCustomer.TabIndex = 3;
            // 
            // lblTableRowCustomer
            // 
            this.lblTableRowCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowCustomer.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowCustomer.Name = "lblTableRowCustomer";
            this.lblTableRowCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowCustomer.Size = new System.Drawing.Size(240, 60);
            this.lblTableRowCustomer.TabIndex = 1;
            this.lblTableRowCustomer.Text = "Customer";
            this.lblTableRowCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowCustomer.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowCustomer.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowCustomer.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowItineraryID
            // 
            this.pnlTableRowItineraryID.Controls.Add(this.lblTableRowItineraryID);
            this.pnlTableRowItineraryID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowItineraryID.Location = new System.Drawing.Point(125, 0);
            this.pnlTableRowItineraryID.Name = "pnlTableRowItineraryID";
            this.pnlTableRowItineraryID.Size = new System.Drawing.Size(120, 60);
            this.pnlTableRowItineraryID.TabIndex = 2;
            // 
            // lblTableRowItineraryID
            // 
            this.lblTableRowItineraryID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowItineraryID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowItineraryID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowItineraryID.Name = "lblTableRowItineraryID";
            this.lblTableRowItineraryID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowItineraryID.Size = new System.Drawing.Size(120, 60);
            this.lblTableRowItineraryID.TabIndex = 1;
            this.lblTableRowItineraryID.Text = "ItineraryID";
            this.lblTableRowItineraryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowItineraryID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowItineraryID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowItineraryID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowBookingID
            // 
            this.pnlTableRowBookingID.Controls.Add(this.lblTableRowBookingID);
            this.pnlTableRowBookingID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowBookingID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRowBookingID.Name = "pnlTableRowBookingID";
            this.pnlTableRowBookingID.Size = new System.Drawing.Size(125, 60);
            this.pnlTableRowBookingID.TabIndex = 0;
            // 
            // lblTableRowBookingID
            // 
            this.lblTableRowBookingID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowBookingID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowBookingID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowBookingID.Name = "lblTableRowBookingID";
            this.lblTableRowBookingID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowBookingID.Size = new System.Drawing.Size(125, 60);
            this.lblTableRowBookingID.TabIndex = 0;
            this.lblTableRowBookingID.Text = "BookingID";
            this.lblTableRowBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowBookingID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowBookingID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowBookingID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // BookingsTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTableRow);
            this.Name = "BookingsTableRow";
            this.Size = new System.Drawing.Size(870, 60);
            this.Load += new System.EventHandler(this.BookingsTableRow_Load);
            this.pnlTableRow.ResumeLayout(false);
            this.pnlTableRowStatus.ResumeLayout(false);
            this.pnlTableRowEndDate.ResumeLayout(false);
            this.pnlTableRowStartDate.ResumeLayout(false);
            this.pnlTableRowCustomer.ResumeLayout(false);
            this.pnlTableRowItineraryID.ResumeLayout(false);
            this.pnlTableRowBookingID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTableRowStartDate;
        private System.Windows.Forms.Label lblTableRowStartDate;
        private System.Windows.Forms.Panel pnlTableRowCustomer;
        private System.Windows.Forms.Label lblTableRowCustomer;
        private System.Windows.Forms.Panel pnlTableRowItineraryID;
        private System.Windows.Forms.Label lblTableRowItineraryID;
        private System.Windows.Forms.Panel pnlTableRowBookingID;
        private System.Windows.Forms.Label lblTableRowBookingID;
        private System.Windows.Forms.Panel pnlTableRowStatus;
        private System.Windows.Forms.Label lblTableRowStatus;
        private System.Windows.Forms.Panel pnlTableRowEndDate;
        private System.Windows.Forms.Label lblTableRowEndDate;
    }
}
