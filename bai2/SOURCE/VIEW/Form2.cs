using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2.SOURCE.VIEW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        quanLyKiTucXaEntities3 sv = new quanLyKiTucXaEntities3();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9UQ2HGP\SQLEXPRESS;Initial Catalog=quanLyKiTucXa;Integrated Security=True");
        public void showinfor(int IdPhong)
        {

          txtTenPhong.Text = IdPhong.ToString();


            // hien thi tinh trang
            conn.Open();
            string max = "select tinhTrang from quanLiPhong where idPhong = "+ IdPhong;
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();      
            conn.Close();
            txtTinhTrang.Text = result;


            // hien thi so luong sinh vien 
            conn.Open();
            string max2 = "select dangThue from quanLiPhong where idPhong = " + IdPhong;
            SqlCommand cmd2 = new SqlCommand(max2, conn);
            int ketQua = (int)cmd2.ExecuteScalar();
            conn.Close();
            txtSinhVien.Text = ketQua.ToString() + "/6";

           


        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            showinfor(101);
            
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            showinfor(102);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            showinfor(103);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {

            showinfor(104);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            showinfor(105);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            showinfor(106);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            showinfor(107);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            showinfor(108);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            showinfor(109);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            showinfor(201);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            showinfor(202);

        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            showinfor(203);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            showinfor(204);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            showinfor(205);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            showinfor(206);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            showinfor(207);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            showinfor(208);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showinfor(209);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            showinfor(301);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            showinfor(302);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            showinfor(303);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            showinfor(304);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            showinfor(305);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            showinfor(306);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            showinfor(307);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            showinfor(308);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            showinfor(309);
        }
    }
}
