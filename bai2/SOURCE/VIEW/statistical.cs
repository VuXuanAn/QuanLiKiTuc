using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2.SOURCE.VIEW
{
    public partial class statistical : Form
    {
        public statistical()
        {
            InitializeComponent();
        }

        private void statistical_Load(object sender, EventArgs e)
        {
            // biểu đồ số lượng sinh viên 
            this.infChart.Series["Year"].Points.AddXY("2015", 300);
            this.infChart.Series["Year"].Points.AddXY("2016", 350);
            this.infChart.Series["Year"].Points.AddXY("2017", 400);
            this.infChart.Series["Year"].Points.AddXY("2018", 450);
            this.infChart.Series["Year"].Points.AddXY("2019", 450);
            this.infChart.Series["Year"].Points.AddXY("2020", 470);

            // boy and girl 
            this.boyAndGirl.Series["Giới tính"].Points.AddXY("Nam", 250);
            this.boyAndGirl.Series["Giới tính"].Points.AddXY("Nữ", 209);

            //domand 
            this.domand.Series["Year"].Points.AddXY("2015", 10);
            this.domand.Series["Year"].Points.AddXY("2016", 15);
            this.domand.Series["Year"].Points.AddXY("2017", 5);
            this.domand.Series["Year"].Points.AddXY("2018", 20);
            this.domand.Series["Year"].Points.AddXY("2019", 10);
            this.domand.Series["Year"].Points.AddXY("2020", 30);
        }
    }
}
