namespace ProjectX.UserControls
{
    partial class DestinationsTableRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinationsTableRow));
            this.pnlTableRow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTableRowDistrict = new System.Windows.Forms.Panel();
            this.lblTableRowDistrict = new System.Windows.Forms.Label();
            this.pnlTableRowImage = new System.Windows.Forms.Panel();
            this.picTableRowImage = new System.Windows.Forms.PictureBox();
            this.pnlTableRowName = new System.Windows.Forms.Panel();
            this.lblTableRowName = new System.Windows.Forms.Label();
            this.pnlTableRowDestinationID = new System.Windows.Forms.Panel();
            this.lblTableRowDestinationID = new System.Windows.Forms.Label();
            this.pnlTableRowCity = new System.Windows.Forms.Panel();
            this.lblTableRowCity = new System.Windows.Forms.Label();
            this.pnlTableRow.SuspendLayout();
            this.pnlTableRowDistrict.SuspendLayout();
            this.pnlTableRowImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).BeginInit();
            this.pnlTableRowName.SuspendLayout();
            this.pnlTableRowDestinationID.SuspendLayout();
            this.pnlTableRowCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableRow
            // 
            this.pnlTableRow.Controls.Add(this.label1);
            this.pnlTableRow.Controls.Add(this.pnlTableRowDistrict);
            this.pnlTableRow.Controls.Add(this.pnlTableRowImage);
            this.pnlTableRow.Controls.Add(this.pnlTableRowName);
            this.pnlTableRow.Controls.Add(this.pnlTableRowDestinationID);
            this.pnlTableRow.Controls.Add(this.pnlTableRowCity);
            this.pnlTableRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRow.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRow.Name = "pnlTableRow";
            this.pnlTableRow.Size = new System.Drawing.Size(870, 70);
            this.pnlTableRow.TabIndex = 5;
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
            // pnlTableRowDistrict
            // 
            this.pnlTableRowDistrict.Controls.Add(this.lblTableRowDistrict);
            this.pnlTableRowDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRowDistrict.Location = new System.Drawing.Point(537, 0);
            this.pnlTableRowDistrict.Name = "pnlTableRowDistrict";
            this.pnlTableRowDistrict.Size = new System.Drawing.Size(166, 70);
            this.pnlTableRowDistrict.TabIndex = 4;
            // 
            // lblTableRowDistrict
            // 
            this.lblTableRowDistrict.BackColor = System.Drawing.Color.White;
            this.lblTableRowDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowDistrict.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowDistrict.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowDistrict.Name = "lblTableRowDistrict";
            this.lblTableRowDistrict.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowDistrict.Size = new System.Drawing.Size(166, 70);
            this.lblTableRowDistrict.TabIndex = 1;
            this.lblTableRowDistrict.Text = "District";
            this.lblTableRowDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowDistrict.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowDistrict.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowDistrict.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowImage
            // 
            this.pnlTableRowImage.BackColor = System.Drawing.Color.White;
            this.pnlTableRowImage.Controls.Add(this.picTableRowImage);
            this.pnlTableRowImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowImage.Location = new System.Drawing.Point(357, 0);
            this.pnlTableRowImage.Name = "pnlTableRowImage";
            this.pnlTableRowImage.Size = new System.Drawing.Size(180, 70);
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
            this.pnlTableRowName.Location = new System.Drawing.Point(117, 0);
            this.pnlTableRowName.Name = "pnlTableRowName";
            this.pnlTableRowName.Size = new System.Drawing.Size(240, 70);
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
            this.lblTableRowName.Size = new System.Drawing.Size(240, 70);
            this.lblTableRowName.TabIndex = 1;
            this.lblTableRowName.Text = "Name";
            this.lblTableRowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowName.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowName.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowName.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowDestinationID
            // 
            this.pnlTableRowDestinationID.Controls.Add(this.lblTableRowDestinationID);
            this.pnlTableRowDestinationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowDestinationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRowDestinationID.Name = "pnlTableRowDestinationID";
            this.pnlTableRowDestinationID.Size = new System.Drawing.Size(117, 70);
            this.pnlTableRowDestinationID.TabIndex = 0;
            // 
            // lblTableRowDestinationID
            // 
            this.lblTableRowDestinationID.BackColor = System.Drawing.Color.White;
            this.lblTableRowDestinationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowDestinationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowDestinationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowDestinationID.Name = "lblTableRowDestinationID";
            this.lblTableRowDestinationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowDestinationID.Size = new System.Drawing.Size(117, 70);
            this.lblTableRowDestinationID.TabIndex = 0;
            this.lblTableRowDestinationID.Text = "DestinationID";
            this.lblTableRowDestinationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowDestinationID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowDestinationID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowDestinationID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowCity
            // 
            this.pnlTableRowCity.Controls.Add(this.lblTableRowCity);
            this.pnlTableRowCity.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableRowCity.Location = new System.Drawing.Point(703, 0);
            this.pnlTableRowCity.Name = "pnlTableRowCity";
            this.pnlTableRowCity.Size = new System.Drawing.Size(167, 70);
            this.pnlTableRowCity.TabIndex = 5;
            // 
            // lblTableRowCity
            // 
            this.lblTableRowCity.BackColor = System.Drawing.Color.White;
            this.lblTableRowCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowCity.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowCity.Name = "lblTableRowCity";
            this.lblTableRowCity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowCity.Size = new System.Drawing.Size(167, 70);
            this.lblTableRowCity.TabIndex = 1;
            this.lblTableRowCity.Text = "City";
            this.lblTableRowCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowCity.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowCity.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowCity.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // DestinationsTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTableRow);
            this.Name = "DestinationsTableRow";
            this.Size = new System.Drawing.Size(870, 70);
            this.Load += new System.EventHandler(this.DestinationsTableRow_Load);
            this.pnlTableRow.ResumeLayout(false);
            this.pnlTableRowDistrict.ResumeLayout(false);
            this.pnlTableRowImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).EndInit();
            this.pnlTableRowName.ResumeLayout(false);
            this.pnlTableRowDestinationID.ResumeLayout(false);
            this.pnlTableRowCity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTableRowDistrict;
        private System.Windows.Forms.Label lblTableRowDistrict;
        private System.Windows.Forms.Panel pnlTableRowImage;
        private System.Windows.Forms.Panel pnlTableRowName;
        private System.Windows.Forms.Label lblTableRowName;
        private System.Windows.Forms.Panel pnlTableRowDestinationID;
        private System.Windows.Forms.Label lblTableRowDestinationID;
        private System.Windows.Forms.Panel pnlTableRowCity;
        private System.Windows.Forms.Label lblTableRowCity;
        private System.Windows.Forms.PictureBox picTableRowImage;
    }
}
