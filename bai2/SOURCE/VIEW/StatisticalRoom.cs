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
    public partial class StatisticalRoom : Form
    {
        public StatisticalRoom()
        {
            InitializeComponent();
        }

        private void StatisticalRoom_Load(object sender, EventArgs e)
        {
           // sơ đồ cột 
            this.phong5Nam.Series["Year"].Points.AddXY("2015", 300);
            this.phong5Nam.Series["Year"].Points.AddXY("2016", 350);
            this.phong5Nam.Series["Year"].Points.AddXY("2017", 400);
            this.phong5Nam.Series["Year"].Points.AddXY("2018", 450);
            this.phong5Nam.Series["Year"].Points.AddXY("2019", 450);
            this.phong5Nam.Series["Year"].Points.AddXY("2020", 470);


            // sơ đồ tròn 
            this.stateOfRoom.Series["state"].Points.AddXY("Phòng trống", 20);
            this.stateOfRoom.Series["state"].Points.AddXY("Phòng đang sử dụng", 60);
            this.stateOfRoom.Series["state"].Points.AddXY("Phòng sửa chữa", 5);
            this.stateOfRoom.Series["state"].Points.AddXY("Phòng đầy", 15);
        }
    }
}
