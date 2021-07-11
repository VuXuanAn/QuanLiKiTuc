namespace bai2.SOURCE.VIEW
{
    partial class statistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistical));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.infChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.boyAndGirl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.domand = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boyAndGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domand)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // infChart
            // 
            this.infChart.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea3.Name = "ChartArea1";
            this.infChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.infChart.Legends.Add(legend3);
            this.infChart.Location = new System.Drawing.Point(12, 12);
            this.infChart.Name = "infChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Year";
            this.infChart.Series.Add(series3);
            this.infChart.Size = new System.Drawing.Size(654, 300);
            this.infChart.TabIndex = 0;
            this.infChart.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "số lượng sinh viên qua các năm";
            this.infChart.Titles.Add(title3);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 1;
            this.bunifuCircleProgressbar1.animationSpeed = 1;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 20;
            this.bunifuCircleProgressbar1.LineThickness = 20;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(98, 33);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(171, 171);
            this.bunifuCircleProgressbar1.TabIndex = 5;
            this.bunifuCircleProgressbar1.Value = 95;
            // 
            // boyAndGirl
            // 
            this.boyAndGirl.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea2.Name = "ChartArea1";
            this.boyAndGirl.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.boyAndGirl.Legends.Add(legend2);
            this.boyAndGirl.Location = new System.Drawing.Point(690, 12);
            this.boyAndGirl.Name = "boyAndGirl";
            this.boyAndGirl.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Giới tính";
            this.boyAndGirl.Series.Add(series2);
            this.boyAndGirl.Size = new System.Drawing.Size(758, 300);
            this.boyAndGirl.TabIndex = 6;
            this.boyAndGirl.Text = "chart3";
            title2.Name = "Title1";
            title2.Text = "Tỉ lê sinh viên nam và nữ";
            this.boyAndGirl.Titles.Add(title2);
            // 
            // domand
            // 
            this.domand.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.Name = "ChartArea1";
            this.domand.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.domand.Legends.Add(legend1);
            this.domand.Location = new System.Drawing.Point(414, 340);
            this.domand.Name = "domand";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Year";
            this.domand.Series.Add(series1);
            this.domand.Size = new System.Drawing.Size(1034, 358);
            this.domand.TabIndex = 7;
            this.domand.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Số lượng sinh viên chuyển phòng trong 5 năm gần nhất ";
            this.domand.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel1.Location = new System.Drawing.Point(12, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 358);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(72, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sinh viên hoàn thành \r\n          hợp đồng";
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1460, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.domand);
            this.Controls.Add(this.boyAndGirl);
            this.Controls.Add(this.infChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistical";
            this.Text = "ChangeRoom";
            this.Load += new System.EventHandler(this.statistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boyAndGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domand)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataVisualization.Charting.Chart infChart;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart domand;
        private System.Windows.Forms.DataVisualization.Charting.Chart boyAndGirl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}