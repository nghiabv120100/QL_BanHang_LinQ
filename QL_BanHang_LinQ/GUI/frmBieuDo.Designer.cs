namespace QL_BanHang_LinQ.GUI
{
    partial class frmBieuDo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLamMoi_Thang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.chartSoLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLamMoi_Thang_Tab2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.chart_PercentTongTien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLamMoi_Tab2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEnd_Tab2 = new System.Windows.Forms.DateTimePicker();
            this.dtpStart_tab2 = new System.Windows.Forms.DateTimePicker();
            this.chartTongTien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAll_SoLuong = new System.Windows.Forms.Button();
            this.btnAll_TongTien = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercent)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PercentTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPercent
            // 
            this.chartPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea5.Name = "ChartArea1";
            this.chartPercent.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPercent.Legends.Add(legend5);
            this.chartPercent.Location = new System.Drawing.Point(737, 94);
            this.chartPercent.Name = "chartPercent";
            this.chartPercent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "##.##%";
            series5.Legend = "Legend1";
            series5.Name = "Số Lượng";
            this.chartPercent.Series.Add(series5);
            this.chartPercent.Size = new System.Drawing.Size(761, 406);
            this.chartPercent.TabIndex = 0;
            this.chartPercent.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title5.Name = "Title";
            title5.Text = "Phần Trăm Số Lượng Hàng Bán Được Theo Loại Hàng";
            this.chartPercent.Titles.Add(title5);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống Kê Theo Thời Gian Cụ Thể.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(812, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thống Kê Theo Tháng.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1752, 784);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnAll_SoLuong);
            this.tabPage1.Controls.Add(this.btnLamMoi_Thang);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.btnLamMoi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpEnd);
            this.tabPage1.Controls.Add(this.dtpStart);
            this.tabPage1.Controls.Add(this.chartPercent);
            this.tabPage1.Controls.Add(this.chartSoLuong);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1744, 755);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Số Lượng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi_Thang
            // 
            this.btnLamMoi_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi_Thang.Location = new System.Drawing.Point(1159, 696);
            this.btnLamMoi_Thang.Name = "btnLamMoi_Thang";
            this.btnLamMoi_Thang.Size = new System.Drawing.Size(124, 36);
            this.btnLamMoi_Thang.TabIndex = 13;
            this.btnLamMoi_Thang.Text = "Làm Mới";
            this.btnLamMoi_Thang.UseVisualStyleBackColor = true;
            this.btnLamMoi_Thang.Click += new System.EventHandler(this.btnLamMoi_Thang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1007, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tháng:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(1134, 593);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(149, 30);
            this.dtpDate.TabIndex = 11;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(377, 696);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 36);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đến Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ Ngày:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(178, 640);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(323, 30);
            this.dtpEnd.TabIndex = 6;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(178, 593);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(323, 30);
            this.dtpStart.TabIndex = 7;
            // 
            // chartSoLuong
            // 
            chartArea8.Name = "ChartArea1";
            this.chartSoLuong.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartSoLuong.Legends.Add(legend8);
            this.chartSoLuong.Location = new System.Drawing.Point(-4, 94);
            this.chartSoLuong.Name = "chartSoLuong";
            this.chartSoLuong.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Lime;
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series8.Legend = "Legend1";
            series8.Name = "Số Lượng";
            this.chartSoLuong.Series.Add(series8);
            this.chartSoLuong.Size = new System.Drawing.Size(749, 406);
            this.chartSoLuong.TabIndex = 1;
            this.chartSoLuong.Text = "chart1";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title8.Name = "Title";
            title8.Text = "Số Lượng Hàng Bán Được Theo Loại Hàng";
            this.chartSoLuong.Titles.Add(title8);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnAll_TongTien);
            this.tabPage2.Controls.Add(this.btnLamMoi_Thang_Tab2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.chart_PercentTongTien);
            this.tabPage2.Controls.Add(this.btnLamMoi_Tab2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dtpEnd_Tab2);
            this.tabPage2.Controls.Add(this.dtpStart_tab2);
            this.tabPage2.Controls.Add(this.chartTongTien);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1744, 755);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tổng Tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi_Thang_Tab2
            // 
            this.btnLamMoi_Thang_Tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi_Thang_Tab2.Location = new System.Drawing.Point(1070, 699);
            this.btnLamMoi_Thang_Tab2.Name = "btnLamMoi_Thang_Tab2";
            this.btnLamMoi_Thang_Tab2.Size = new System.Drawing.Size(124, 36);
            this.btnLamMoi_Thang_Tab2.TabIndex = 19;
            this.btnLamMoi_Thang_Tab2.Text = "Làm Mới";
            this.btnLamMoi_Thang_Tab2.UseVisualStyleBackColor = true;
            this.btnLamMoi_Thang_Tab2.Click += new System.EventHandler(this.btnLamMoi_Thang_Tab2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(943, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tháng:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "MM/yyyy";
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(1070, 589);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(149, 30);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // chart_PercentTongTien
            // 
            this.chart_PercentTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea6.Name = "ChartArea1";
            this.chart_PercentTongTien.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_PercentTongTien.Legends.Add(legend6);
            this.chart_PercentTongTien.Location = new System.Drawing.Point(845, 94);
            this.chart_PercentTongTien.Name = "chart_PercentTongTien";
            this.chart_PercentTongTien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series6.IsValueShownAsLabel = true;
            series6.LabelFormat = "##.##%";
            series6.Legend = "Legend1";
            series6.Name = "Phần trăm";
            this.chart_PercentTongTien.Series.Add(series6);
            this.chart_PercentTongTien.Size = new System.Drawing.Size(689, 406);
            this.chart_PercentTongTien.TabIndex = 16;
            this.chart_PercentTongTien.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title6.Name = "Title";
            title6.Text = "Phần Trăm Tổng Tiền Bán Được Theo Loại Hàng";
            this.chart_PercentTongTien.Titles.Add(title6);
            // 
            // btnLamMoi_Tab2
            // 
            this.btnLamMoi_Tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi_Tab2.Location = new System.Drawing.Point(470, 699);
            this.btnLamMoi_Tab2.Name = "btnLamMoi_Tab2";
            this.btnLamMoi_Tab2.Size = new System.Drawing.Size(124, 36);
            this.btnLamMoi_Tab2.TabIndex = 15;
            this.btnLamMoi_Tab2.Text = "Làm Mới";
            this.btnLamMoi_Tab2.UseVisualStyleBackColor = true;
            this.btnLamMoi_Tab2.Click += new System.EventHandler(this.btnLamMoi_Tab2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đến Ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Từ Ngày:";
            // 
            // dtpEnd_Tab2
            // 
            this.dtpEnd_Tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd_Tab2.Location = new System.Drawing.Point(271, 643);
            this.dtpEnd_Tab2.Name = "dtpEnd_Tab2";
            this.dtpEnd_Tab2.Size = new System.Drawing.Size(323, 30);
            this.dtpEnd_Tab2.TabIndex = 11;
            // 
            // dtpStart_tab2
            // 
            this.dtpStart_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart_tab2.Location = new System.Drawing.Point(271, 596);
            this.dtpStart_tab2.Name = "dtpStart_tab2";
            this.dtpStart_tab2.Size = new System.Drawing.Size(323, 30);
            this.dtpStart_tab2.TabIndex = 12;
            // 
            // chartTongTien
            // 
            chartArea7.Name = "ChartArea1";
            this.chartTongTien.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTongTien.Legends.Add(legend7);
            this.chartTongTien.Location = new System.Drawing.Point(89, 94);
            this.chartTongTien.Name = "chartTongTien";
            this.chartTongTien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Legend = "Legend1";
            series7.Name = "Tổng Tiền";
            this.chartTongTien.Series.Add(series7);
            this.chartTongTien.Size = new System.Drawing.Size(652, 437);
            this.chartTongTien.TabIndex = 2;
            this.chartTongTien.Text = "Số Tiền Bán Được Theo Từng Loại Hàng";
            title7.BackColor = System.Drawing.Color.White;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title7.Name = "Title1";
            title7.Text = "Tổng Tiền Bán Được Theo Loại Hàng";
            this.chartTongTien.Titles.Add(title7);
            // 
            // btnAll_SoLuong
            // 
            this.btnAll_SoLuong.Location = new System.Drawing.Point(1320, 27);
            this.btnAll_SoLuong.Name = "btnAll_SoLuong";
            this.btnAll_SoLuong.Size = new System.Drawing.Size(137, 39);
            this.btnAll_SoLuong.TabIndex = 14;
            this.btnAll_SoLuong.Text = "All";
            this.btnAll_SoLuong.UseVisualStyleBackColor = true;
            this.btnAll_SoLuong.Click += new System.EventHandler(this.btnAll_SoLuong_Click);
            // 
            // btnAll_TongTien
            // 
            this.btnAll_TongTien.Location = new System.Drawing.Point(1396, 20);
            this.btnAll_TongTien.Name = "btnAll_TongTien";
            this.btnAll_TongTien.Size = new System.Drawing.Size(126, 42);
            this.btnAll_TongTien.TabIndex = 20;
            this.btnAll_TongTien.Text = "All";
            this.btnAll_TongTien.UseVisualStyleBackColor = true;
            this.btnAll_TongTien.Click += new System.EventHandler(this.btnAll_TongTien_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkOrange;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(593, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thống Kê Số Lượng Loại Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(482, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(694, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thống Kê Tổng Tiền Theo Loại Sản Phẩm";
            // 
            // frmBieuDo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1764, 804);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmBieuDo";
            this.Text = "frmBieuDo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBieuDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPercent)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PercentTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoLuong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLamMoi_Thang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTongTien;
        private System.Windows.Forms.Button btnLamMoi_Thang_Tab2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PercentTongTien;
        private System.Windows.Forms.Button btnLamMoi_Tab2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEnd_Tab2;
        private System.Windows.Forms.DateTimePicker dtpStart_tab2;
        private System.Windows.Forms.Button btnAll_SoLuong;
        private System.Windows.Forms.Button btnAll_TongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}