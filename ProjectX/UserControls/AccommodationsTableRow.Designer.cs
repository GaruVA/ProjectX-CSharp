namespace ProjectX.UserControls
{
    partial class AccommodationsTableRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccommodationsTableRow));
            this.pnlTableRow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTableRowCategory = new System.Windows.Forms.Panel();
            this.lblTableRowCategory = new System.Windows.Forms.Label();
            this.pnlTableRowAddress = new System.Windows.Forms.Panel();
            this.lblTableRowAddress = new System.Windows.Forms.Label();
            this.pnlTableRowImage = new System.Windows.Forms.Panel();
            this.picTableRowImage = new System.Windows.Forms.PictureBox();
            this.pnlTableRowName = new System.Windows.Forms.Panel();
            this.lblTableRowName = new System.Windows.Forms.Label();
            this.pnlTableRowAccommodationID = new System.Windows.Forms.Panel();
            this.lblTableRowAccommodationID = new System.Windows.Forms.Label();
            this.pnlTableRow.SuspendLayout();
            this.pnlTableRowCategory.SuspendLayout();
            this.pnlTableRowAddress.SuspendLayout();
            this.pnlTableRowImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).BeginInit();
            this.pnlTableRowName.SuspendLayout();
            this.pnlTableRowAccommodationID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableRow
            // 
            this.pnlTableRow.Controls.Add(this.label1);
            this.pnlTableRow.Controls.Add(this.pnlTableRowCategory);
            this.pnlTableRow.Controls.Add(this.pnlTableRowAddress);
            this.pnlTableRow.Controls.Add(this.pnlTableRowImage);
            this.pnlTableRow.Controls.Add(this.pnlTableRowName);
            this.pnlTableRow.Controls.Add(this.pnlTableRowAccommodationID);
            this.pnlTableRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRow.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRow.Name = "pnlTableRow";
            this.pnlTableRow.Size = new System.Drawing.Size(870, 70);
            this.pnlTableRow.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(-11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 10);
            this.label1.TabIndex = 6;
            // 
            // pnlTableRowCategory
            // 
            this.pnlTableRowCategory.Controls.Add(this.lblTableRowCategory);
            this.pnlTableRowCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowCategory.Location = new System.Drawing.Point(739, 0);
            this.pnlTableRowCategory.Name = "pnlTableRowCategory";
            this.pnlTableRowCategory.Size = new System.Drawing.Size(130, 70);
            this.pnlTableRowCategory.TabIndex = 5;
            // 
            // lblTableRowCategory
            // 
            this.lblTableRowCategory.BackColor = System.Drawing.Color.White;
            this.lblTableRowCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowCategory.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowCategory.Name = "lblTableRowCategory";
            this.lblTableRowCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowCategory.Size = new System.Drawing.Size(130, 70);
            this.lblTableRowCategory.TabIndex = 1;
            this.lblTableRowCategory.Text = "Category";
            this.lblTableRowCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowCategory.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowCategory.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowCategory.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowAddress
            // 
            this.pnlTableRowAddress.Controls.Add(this.lblTableRowAddress);
            this.pnlTableRowAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowAddress.Location = new System.Drawing.Point(469, 0);
            this.pnlTableRowAddress.Name = "pnlTableRowAddress";
            this.pnlTableRowAddress.Size = new System.Drawing.Size(270, 70);
            this.pnlTableRowAddress.TabIndex = 4;
            // 
            // lblTableRowAddress
            // 
            this.lblTableRowAddress.BackColor = System.Drawing.Color.White;
            this.lblTableRowAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowAddress.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowAddress.Name = "lblTableRowAddress";
            this.lblTableRowAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowAddress.Size = new System.Drawing.Size(270, 70);
            this.lblTableRowAddress.TabIndex = 1;
            this.lblTableRowAddress.Text = "Address";
            this.lblTableRowAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowAddress.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowAddress.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowAddress.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowImage
            // 
            this.pnlTableRowImage.BackColor = System.Drawing.Color.White;
            this.pnlTableRowImage.Controls.Add(this.picTableRowImage);
            this.pnlTableRowImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowImage.Location = new System.Drawing.Point(325, 0);
            this.pnlTableRowImage.Name = "pnlTableRowImage";
            this.pnlTableRowImage.Size = new System.Drawing.Size(144, 70);
            this.pnlTableRowImage.TabIndex = 3;
            this.pnlTableRowImage.Click += new System.EventHandler(this.Row_Click);
            this.pnlTableRowImage.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.pnlTableRowImage.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // picTableRowImage
            // 
            this.picTableRowImage.Image = ((System.Drawing.Image)(resources.GetObject("picTableRowImage.Image")));
            this.picTableRowImage.Location = new System.Drawing.Point(6, 8);
            this.picTableRowImage.Name = "picTableRowImage";
            this.picTableRowImage.Size = new System.Drawing.Size(108, 54);
            this.picTableRowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTableRowImage.TabIndex = 0;
            this.picTableRowImage.TabStop = false;
            this.picTableRowImage.Click += new System.EventHandler(this.Row_Click);
            this.picTableRowImage.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.picTableRowImage.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowName
            // 
            this.pnlTableRowName.Controls.Add(this.lblTableRowName);
            this.pnlTableRowName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowName.Location = new System.Drawing.Point(125, 0);
            this.pnlTableRowName.Name = "pnlTableRowName";
            this.pnlTableRowName.Size = new System.Drawing.Size(200, 70);
            this.pnlTableRowName.TabIndex = 2;
            // 
            // lblTableRowName
            // 
            this.lblTableRowName.BackColor = System.Drawing.Color.White;
            this.lblTableRowName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowName.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowName.Name = "lblTableRowName";
            this.lblTableRowName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowName.Size = new System.Drawing.Size(200, 70);
            this.lblTableRowName.TabIndex = 1;
            this.lblTableRowName.Text = "Name";
            this.lblTableRowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowName.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowName.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowName.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowAccommodationID
            // 
            this.pnlTableRowAccommodationID.Controls.Add(this.lblTableRowAccommodationID);
            this.pnlTableRowAccommodationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowAccommodationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRowAccommodationID.Name = "pnlTableRowAccommodationID";
            this.pnlTableRowAccommodationID.Size = new System.Drawing.Size(125, 70);
            this.pnlTableRowAccommodationID.TabIndex = 0;
            // 
            // lblTableRowAccommodationID
            // 
            this.lblTableRowAccommodationID.BackColor = System.Drawing.Color.White;
            this.lblTableRowAccommodationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowAccommodationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowAccommodationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowAccommodationID.Name = "lblTableRowAccommodationID";
            this.lblTableRowAccommodationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowAccommodationID.Size = new System.Drawing.Size(125, 70);
            this.lblTableRowAccommodationID.TabIndex = 0;
            this.lblTableRowAccommodationID.Text = "AccommodationID";
            this.lblTableRowAccommodationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowAccommodationID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowAccommodationID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowAccommodationID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // AccommodationsTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTableRow);
            this.Name = "AccommodationsTableRow";
            this.Size = new System.Drawing.Size(870, 70);
            this.Load += new System.EventHandler(this.AccommodationsTableRow_Load);
            this.pnlTableRow.ResumeLayout(false);
            this.pnlTableRowCategory.ResumeLayout(false);
            this.pnlTableRowAddress.ResumeLayout(false);
            this.pnlTableRowImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).EndInit();
            this.pnlTableRowName.ResumeLayout(false);
            this.pnlTableRowAccommodationID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTableRowAddress;
        private System.Windows.Forms.Label lblTableRowAddress;
        private System.Windows.Forms.Panel pnlTableRowImage;
        private System.Windows.Forms.PictureBox picTableRowImage;
        private System.Windows.Forms.Panel pnlTableRowName;
        private System.Windows.Forms.Label lblTableRowName;
        private System.Windows.Forms.Panel pnlTableRowAccommodationID;
        private System.Windows.Forms.Label lblTableRowAccommodationID;
        private System.Windows.Forms.Panel pnlTableRowCategory;
        private System.Windows.Forms.Label lblTableRowCategory;
    }
}
