namespace ProjectX.UserControls
{
    partial class ItineraryBuilderSelectorRow
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.Row_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblName.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 29);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 14);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.Row_Click);
            this.lblAddress.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.lblAddress.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            // 
            // ItineraryBuilderAddAPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "ItineraryBuilderAddAPlace";
            this.Size = new System.Drawing.Size(320, 54);
            this.Load += new System.EventHandler(this.ItineraryBuilderLibrary_Load);
            this.Click += new System.EventHandler(this.Row_Click);
            this.MouseEnter += new System.EventHandler(this.HoverEffect_Enter);
            this.MouseLeave += new System.EventHandler(this.HoverEffect_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
    }
}
