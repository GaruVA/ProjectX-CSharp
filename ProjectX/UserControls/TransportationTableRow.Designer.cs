namespace ProjectX.UserControls
{
    partial class TransportationTableRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportationTableRow));
            this.pnlTableRow = new System.Windows.Forms.Panel();
            this.pnlTableRowBasePrice = new System.Windows.Forms.Panel();
            this.lblTableRowBasePrice = new System.Windows.Forms.Label();
            this.pnlTableRowPricePerKM = new System.Windows.Forms.Panel();
            this.lblTableRowPricePerKM = new System.Windows.Forms.Label();
            this.pnlTableRowImage = new System.Windows.Forms.Panel();
            this.picTableRowImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTableRowType = new System.Windows.Forms.Panel();
            this.lblTableRowType = new System.Windows.Forms.Label();
            this.pnlTableRowName = new System.Windows.Forms.Panel();
            this.lblTableRowName = new System.Windows.Forms.Label();
            this.pnlTableRowTransportationID = new System.Windows.Forms.Panel();
            this.lblTableRowTransportationID = new System.Windows.Forms.Label();
            this.pnlTableRow.SuspendLayout();
            this.pnlTableRowBasePrice.SuspendLayout();
            this.pnlTableRowPricePerKM.SuspendLayout();
            this.pnlTableRowImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).BeginInit();
            this.pnlTableRowType.SuspendLayout();
            this.pnlTableRowName.SuspendLayout();
            this.pnlTableRowTransportationID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableRow
            // 
            this.pnlTableRow.Controls.Add(this.label1);
            this.pnlTableRow.Controls.Add(this.pnlTableRowBasePrice);
            this.pnlTableRow.Controls.Add(this.pnlTableRowPricePerKM);
            this.pnlTableRow.Controls.Add(this.pnlTableRowImage);
            this.pnlTableRow.Controls.Add(this.pnlTableRowType);
            this.pnlTableRow.Controls.Add(this.pnlTableRowName);
            this.pnlTableRow.Controls.Add(this.pnlTableRowTransportationID);
            this.pnlTableRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableRow.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRow.Name = "pnlTableRow";
            this.pnlTableRow.Size = new System.Drawing.Size(870, 70);
            this.pnlTableRow.TabIndex = 7;
            // 
            // pnlTableRowBasePrice
            // 
            this.pnlTableRowBasePrice.Controls.Add(this.lblTableRowBasePrice);
            this.pnlTableRowBasePrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowBasePrice.Location = new System.Drawing.Point(761, 0);
            this.pnlTableRowBasePrice.Name = "pnlTableRowBasePrice";
            this.pnlTableRowBasePrice.Size = new System.Drawing.Size(109, 70);
            this.pnlTableRowBasePrice.TabIndex = 7;
            // 
            // lblTableRowBasePrice
            // 
            this.lblTableRowBasePrice.BackColor = System.Drawing.Color.White;
            this.lblTableRowBasePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowBasePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowBasePrice.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowBasePrice.Name = "lblTableRowBasePrice";
            this.lblTableRowBasePrice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowBasePrice.Size = new System.Drawing.Size(109, 70);
            this.lblTableRowBasePrice.TabIndex = 1;
            this.lblTableRowBasePrice.Text = "BasePrice";
            this.lblTableRowBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowBasePrice.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowBasePrice.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowBasePrice.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowPricePerKM
            // 
            this.pnlTableRowPricePerKM.Controls.Add(this.lblTableRowPricePerKM);
            this.pnlTableRowPricePerKM.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowPricePerKM.Location = new System.Drawing.Point(645, 0);
            this.pnlTableRowPricePerKM.Name = "pnlTableRowPricePerKM";
            this.pnlTableRowPricePerKM.Size = new System.Drawing.Size(116, 70);
            this.pnlTableRowPricePerKM.TabIndex = 5;
            // 
            // lblTableRowPricePerKM
            // 
            this.lblTableRowPricePerKM.BackColor = System.Drawing.Color.White;
            this.lblTableRowPricePerKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowPricePerKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowPricePerKM.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowPricePerKM.Name = "lblTableRowPricePerKM";
            this.lblTableRowPricePerKM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowPricePerKM.Size = new System.Drawing.Size(116, 70);
            this.lblTableRowPricePerKM.TabIndex = 1;
            this.lblTableRowPricePerKM.Text = "PricePerKM";
            this.lblTableRowPricePerKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowPricePerKM.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowPricePerKM.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowPricePerKM.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // pnlTableRowImage
            // 
            this.pnlTableRowImage.BackColor = System.Drawing.Color.White;
            this.pnlTableRowImage.Controls.Add(this.picTableRowImage);
            this.pnlTableRowImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowImage.Location = new System.Drawing.Point(525, 0);
            this.pnlTableRowImage.Name = "pnlTableRowImage";
            this.pnlTableRowImage.Size = new System.Drawing.Size(120, 70);
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(-11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 10);
            this.label1.TabIndex = 6;
            // 
            // pnlTableRowType
            // 
            this.pnlTableRowType.Controls.Add(this.lblTableRowType);
            this.pnlTableRowType.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowType.Location = new System.Drawing.Point(325, 0);
            this.pnlTableRowType.Name = "pnlTableRowType";
            this.pnlTableRowType.Size = new System.Drawing.Size(200, 70);
            this.pnlTableRowType.TabIndex = 4;
            // 
            // lblTableRowType
            // 
            this.lblTableRowType.BackColor = System.Drawing.Color.White;
            this.lblTableRowType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowType.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowType.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowType.Name = "lblTableRowType";
            this.lblTableRowType.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowType.Size = new System.Drawing.Size(200, 70);
            this.lblTableRowType.TabIndex = 1;
            this.lblTableRowType.Text = "Type";
            this.lblTableRowType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowType.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowType.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowType.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
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
            // pnlTableRowTransportationID
            // 
            this.pnlTableRowTransportationID.Controls.Add(this.lblTableRowTransportationID);
            this.pnlTableRowTransportationID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTableRowTransportationID.Location = new System.Drawing.Point(0, 0);
            this.pnlTableRowTransportationID.Name = "pnlTableRowTransportationID";
            this.pnlTableRowTransportationID.Size = new System.Drawing.Size(125, 70);
            this.pnlTableRowTransportationID.TabIndex = 0;
            // 
            // lblTableRowTransportationID
            // 
            this.lblTableRowTransportationID.BackColor = System.Drawing.Color.White;
            this.lblTableRowTransportationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableRowTransportationID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableRowTransportationID.Location = new System.Drawing.Point(0, 0);
            this.lblTableRowTransportationID.Name = "lblTableRowTransportationID";
            this.lblTableRowTransportationID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableRowTransportationID.Size = new System.Drawing.Size(125, 70);
            this.lblTableRowTransportationID.TabIndex = 0;
            this.lblTableRowTransportationID.Text = "TransportationID";
            this.lblTableRowTransportationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTableRowTransportationID.Click += new System.EventHandler(this.Row_Click);
            this.lblTableRowTransportationID.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblTableRowTransportationID.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // TransportationTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTableRow);
            this.Name = "TransportationTableRow";
            this.Size = new System.Drawing.Size(870, 70);
            this.Load += new System.EventHandler(this.TransportationTableRow_Load);
            this.pnlTableRow.ResumeLayout(false);
            this.pnlTableRowBasePrice.ResumeLayout(false);
            this.pnlTableRowPricePerKM.ResumeLayout(false);
            this.pnlTableRowImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTableRowImage)).EndInit();
            this.pnlTableRowType.ResumeLayout(false);
            this.pnlTableRowName.ResumeLayout(false);
            this.pnlTableRowTransportationID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTableRowBasePrice;
        private System.Windows.Forms.Label lblTableRowBasePrice;
        private System.Windows.Forms.Panel pnlTableRowPricePerKM;
        private System.Windows.Forms.Label lblTableRowPricePerKM;
        private System.Windows.Forms.Panel pnlTableRowType;
        private System.Windows.Forms.Label lblTableRowType;
        private System.Windows.Forms.Panel pnlTableRowImage;
        private System.Windows.Forms.PictureBox picTableRowImage;
        private System.Windows.Forms.Panel pnlTableRowName;
        private System.Windows.Forms.Label lblTableRowName;
        private System.Windows.Forms.Panel pnlTableRowTransportationID;
        private System.Windows.Forms.Label lblTableRowTransportationID;
    }
}
