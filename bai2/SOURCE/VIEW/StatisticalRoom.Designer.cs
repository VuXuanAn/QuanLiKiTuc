namespace bai2.SOURCE.VIEW
{
    partial class StatisticalRoom
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticalRoom));
            this.phong5Nam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.stateOfRoom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phong5Nam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateOfRoom)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // phong5Nam
            // 
            this.phong5Nam.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.Name = "ChartArea1";
            this.phong5Nam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.phong5Nam.Legends.Add(legend1);
            this.phong5Nam.Location = new System.Drawing.Point(12, 12);
            this.phong5Nam.Name = "phong5Nam";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Year";
            this.phong5Nam.Series.Add(series1);
            this.phong5Nam.Size = new System.Drawing.Size(558, 300);
            this.phong5Nam.TabIndex = 0;
            title1.Name = "Title1";
            title1.Text = "Số lượng sinh viên thuê phòng trong 5 năm gần nhất ";
            this.phong5Nam.Titles.Add(title1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // stateOfRoom
            // 
            this.stateOfRoom.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea2.Name = "ChartArea1";
            this.stateOfRoom.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.stateOfRoom.Legends.Add(legend2);
            this.stateOfRoom.Location = new System.Drawing.Point(12, 341);
            this.stateOfRoom.Name = "stateOfRoom";
            this.stateOfRoom.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "state";
            series2.YValuesPerPoint = 2;
            this.stateOfRoom.Series.Add(series2);
            this.stateOfRoom.Size = new System.Drawing.Size(558, 351);
            this.stateOfRoom.TabIndex = 1;
            this.stateOfRoom.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.Name = "Title1";
            title2.Text = "Tình trạng phòng";
            this.stateOfRoom.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(602, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 300);
            this.panel1.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.label14);
            this.panel15.Controls.Add(this.pictureBox9);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Location = new System.Drawing.Point(602, 343);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(253, 349);
            this.panel15.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(86, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 29);
            this.label14.TabIndex = 2;
            this.label14.Text = "2000";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(24, 90);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(204, 152);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel16.Controls.Add(this.label15);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(251, 63);
            this.panel16.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(45, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tiền nước";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.pictureBox8);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(919, 344);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(242, 348);
            this.panel13.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Fuchsia;
            this.label12.Location = new System.Drawing.Point(81, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "70.000";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(15, 71);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(204, 151);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel14.Controls.Add(this.label13);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(240, 65);
            this.panel14.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(60, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tiền wifi";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1225, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 351);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(77, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "70.000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 65);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền wifi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticalRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1460, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stateOfRoom);
            this.Controls.Add(this.phong5Nam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticalRoom";
            this.Text = "StatisticalRoom";
            this.Load += new System.EventHandler(this.StatisticalRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phong5Nam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateOfRoom)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart phong5Nam;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart stateOfRoom;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}