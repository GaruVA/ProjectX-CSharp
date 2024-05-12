namespace ProjectX.Forms
{
    partial class ReportAnalytics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnGenerate = new ProjectX.RoundButton();
            this.btnReports = new ProjectX.RoundButton();
            this.pnlDataTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itineraryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ProjectX.DatabaseDataSet();
            this.pnlChartContent = new System.Windows.Forms.Panel();
            this.salesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblPnlTopDataView = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTransportation = new System.Windows.Forms.Panel();
            this.transportationNo = new System.Windows.Forms.Label();
            this.lblTransportation = new System.Windows.Forms.Label();
            this.pnlItinerary = new System.Windows.Forms.Panel();
            this.itineraryNo = new System.Windows.Forms.Label();
            this.lblItinerary = new System.Windows.Forms.Label();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.customerNo = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.pnlBookings = new System.Windows.Forms.Panel();
            this.bookingNo = new System.Windows.Forms.Label();
            this.lblBookings = new System.Windows.Forms.Label();
            this.bookingsTableAdapter = new ProjectX.DatabaseDataSetTableAdapters.BookingsTableAdapter();
            this.pnlContent.SuspendLayout();
            this.pnlDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.pnlChartContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).BeginInit();
            this.tblPnlTopDataView.SuspendLayout();
            this.pnlTransportation.SuspendLayout();
            this.pnlItinerary.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            this.pnlBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.btnGenerate);
            this.pnlContent.Controls.Add(this.btnReports);
            this.pnlContent.Controls.Add(this.pnlDataTable);
            this.pnlContent.Controls.Add(this.pnlChartContent);
            this.pnlContent.Controls.Add(this.tblPnlTopDataView);
            this.pnlContent.Location = new System.Drawing.Point(76, 48);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.MaximumSize = new System.Drawing.Size(872, 584);
            this.pnlContent.MinimumSize = new System.Drawing.Size(872, 584);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContent.Size = new System.Drawing.Size(872, 584);
            this.pnlContent.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnGenerate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnGenerate.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.BorderRadius = 20;
            this.btnGenerate.BorderSize = 1;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(628, 525);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(113, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.TextColor = System.Drawing.Color.White;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnReports.BorderColor = System.Drawing.Color.Black;
            this.btnReports.BorderRadius = 20;
            this.btnReports.BorderSize = 1;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(747, 525);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(113, 44);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextColor = System.Drawing.Color.Black;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlDataTable
            // 
            this.pnlDataTable.Controls.Add(this.dataGridView1);
            this.pnlDataTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataTable.Location = new System.Drawing.Point(12, 382);
            this.pnlDataTable.Name = "pnlDataTable";
            this.pnlDataTable.Padding = new System.Windows.Forms.Padding(3);
            this.pnlDataTable.Size = new System.Drawing.Size(848, 133);
            this.pnlDataTable.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.itineraryIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(842, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itineraryIDDataGridViewTextBoxColumn
            // 
            this.itineraryIDDataGridViewTextBoxColumn.DataPropertyName = "ItineraryID";
            this.itineraryIDDataGridViewTextBoxColumn.HeaderText = "ItineraryID";
            this.itineraryIDDataGridViewTextBoxColumn.Name = "itineraryIDDataGridViewTextBoxColumn";
            this.itineraryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlChartContent
            // 
            this.pnlChartContent.Controls.Add(this.salesChart);
            this.pnlChartContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChartContent.Location = new System.Drawing.Point(12, 83);
            this.pnlChartContent.Name = "pnlChartContent";
            this.pnlChartContent.Padding = new System.Windows.Forms.Padding(3);
            this.pnlChartContent.Size = new System.Drawing.Size(848, 299);
            this.pnlChartContent.TabIndex = 1;
            // 
            // salesChart
            // 
            this.salesChart.BorderlineColor = System.Drawing.Color.Black;
            this.salesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.salesChart.ChartAreas.Add(chartArea1);
            this.salesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.salesChart.Legends.Add(legend1);
            this.salesChart.Location = new System.Drawing.Point(3, 3);
            this.salesChart.Name = "salesChart";
            this.salesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.salesChart.Series.Add(series1);
            this.salesChart.Size = new System.Drawing.Size(842, 293);
            this.salesChart.TabIndex = 0;
            this.salesChart.Text = "Sales Chart";
            // 
            // tblPnlTopDataView
            // 
            this.tblPnlTopDataView.ColumnCount = 4;
            this.tblPnlTopDataView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlTopDataView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlTopDataView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlTopDataView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlTopDataView.Controls.Add(this.pnlTransportation, 3, 0);
            this.tblPnlTopDataView.Controls.Add(this.pnlItinerary, 2, 0);
            this.tblPnlTopDataView.Controls.Add(this.pnlCustomers, 1, 0);
            this.tblPnlTopDataView.Controls.Add(this.pnlBookings, 0, 0);
            this.tblPnlTopDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPnlTopDataView.Location = new System.Drawing.Point(12, 12);
            this.tblPnlTopDataView.Margin = new System.Windows.Forms.Padding(4);
            this.tblPnlTopDataView.Name = "tblPnlTopDataView";
            this.tblPnlTopDataView.RowCount = 1;
            this.tblPnlTopDataView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlTopDataView.Size = new System.Drawing.Size(848, 71);
            this.tblPnlTopDataView.TabIndex = 0;
            // 
            // pnlTransportation
            // 
            this.pnlTransportation.BackColor = System.Drawing.Color.White;
            this.pnlTransportation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransportation.Controls.Add(this.transportationNo);
            this.pnlTransportation.Controls.Add(this.lblTransportation);
            this.pnlTransportation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransportation.Location = new System.Drawing.Point(640, 4);
            this.pnlTransportation.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTransportation.Name = "pnlTransportation";
            this.pnlTransportation.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTransportation.Size = new System.Drawing.Size(204, 63);
            this.pnlTransportation.TabIndex = 3;
            // 
            // transportationNo
            // 
            this.transportationNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transportationNo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportationNo.Location = new System.Drawing.Point(5, 31);
            this.transportationNo.Name = "transportationNo";
            this.transportationNo.Size = new System.Drawing.Size(192, 25);
            this.transportationNo.TabIndex = 1;
            this.transportationNo.Text = "00";
            this.transportationNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransportation
            // 
            this.lblTransportation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransportation.Location = new System.Drawing.Point(5, 5);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(192, 28);
            this.lblTransportation.TabIndex = 0;
            this.lblTransportation.Text = "NO OF BOOKED TRANSPORTATIONS";
            this.lblTransportation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlItinerary
            // 
            this.pnlItinerary.BackColor = System.Drawing.Color.White;
            this.pnlItinerary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItinerary.Controls.Add(this.itineraryNo);
            this.pnlItinerary.Controls.Add(this.lblItinerary);
            this.pnlItinerary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItinerary.Location = new System.Drawing.Point(428, 4);
            this.pnlItinerary.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItinerary.Name = "pnlItinerary";
            this.pnlItinerary.Padding = new System.Windows.Forms.Padding(5);
            this.pnlItinerary.Size = new System.Drawing.Size(204, 63);
            this.pnlItinerary.TabIndex = 2;
            // 
            // itineraryNo
            // 
            this.itineraryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itineraryNo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itineraryNo.Location = new System.Drawing.Point(5, 31);
            this.itineraryNo.Name = "itineraryNo";
            this.itineraryNo.Size = new System.Drawing.Size(192, 25);
            this.itineraryNo.TabIndex = 1;
            this.itineraryNo.Text = "00";
            this.itineraryNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItinerary
            // 
            this.lblItinerary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItinerary.Location = new System.Drawing.Point(5, 5);
            this.lblItinerary.Name = "lblItinerary";
            this.lblItinerary.Size = new System.Drawing.Size(192, 28);
            this.lblItinerary.TabIndex = 0;
            this.lblItinerary.Text = "NO OF ITINERARIES";
            this.lblItinerary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.BackColor = System.Drawing.Color.White;
            this.pnlCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomers.Controls.Add(this.customerNo);
            this.pnlCustomers.Controls.Add(this.lblCustomers);
            this.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomers.Location = new System.Drawing.Point(216, 4);
            this.pnlCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCustomers.Size = new System.Drawing.Size(204, 63);
            this.pnlCustomers.TabIndex = 1;
            // 
            // customerNo
            // 
            this.customerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNo.Location = new System.Drawing.Point(5, 31);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(192, 25);
            this.customerNo.TabIndex = 1;
            this.customerNo.Text = "00";
            this.customerNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomers
            // 
            this.lblCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomers.Location = new System.Drawing.Point(5, 5);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(192, 28);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "NO OF CUSTOMERS";
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBookings
            // 
            this.pnlBookings.BackColor = System.Drawing.Color.White;
            this.pnlBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookings.Controls.Add(this.bookingNo);
            this.pnlBookings.Controls.Add(this.lblBookings);
            this.pnlBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookings.Location = new System.Drawing.Point(4, 4);
            this.pnlBookings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBookings.Size = new System.Drawing.Size(204, 63);
            this.pnlBookings.TabIndex = 0;
            // 
            // bookingNo
            // 
            this.bookingNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingNo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingNo.Location = new System.Drawing.Point(5, 31);
            this.bookingNo.Name = "bookingNo";
            this.bookingNo.Size = new System.Drawing.Size(192, 25);
            this.bookingNo.TabIndex = 1;
            this.bookingNo.Text = "00";
            this.bookingNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookings
            // 
            this.lblBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookings.Location = new System.Drawing.Point(5, 5);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(192, 28);
            this.lblBookings.TabIndex = 0;
            this.lblBookings.Text = "NO OF BOOKINGS";
            this.lblBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportAnalytics";
            this.Text = "REPORT / ANALYTICS";
            this.Load += new System.EventHandler(this.ReportAnalytics_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.pnlChartContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).EndInit();
            this.tblPnlTopDataView.ResumeLayout(false);
            this.pnlTransportation.ResumeLayout(false);
            this.pnlItinerary.ResumeLayout(false);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlBookings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private RoundButton btnGenerate;
        private RoundButton btnReports;
        private System.Windows.Forms.Panel pnlDataTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlChartContent;
        private System.Windows.Forms.TableLayoutPanel tblPnlTopDataView;
        private System.Windows.Forms.Panel pnlTransportation;
        private System.Windows.Forms.Label transportationNo;
        private System.Windows.Forms.Label lblTransportation;
        private System.Windows.Forms.Panel pnlItinerary;
        private System.Windows.Forms.Label itineraryNo;
        private System.Windows.Forms.Label lblItinerary;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel pnlBookings;
        private System.Windows.Forms.Label bookingNo;
        private System.Windows.Forms.Label lblBookings;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DatabaseDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itineraryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesChart;
    }
}