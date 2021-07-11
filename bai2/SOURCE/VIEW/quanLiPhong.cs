using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace bai2.SOURCE.VIEW
{
    public partial class quanLiPhong : Form
    {
        public quanLiPhong()
        {
            InitializeComponent();
        }

        // tao lien ket den co so du lieu 
        quanLyKiTucXaEntities3 sv = new quanLyKiTucXaEntities3();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9UQ2HGP\SQLEXPRESS;Initial Catalog=quanLyKiTucXa;Integrated Security=True");
        
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //hiển thị thông tin của phòng nên bảng chi tiết 

        public void showinfor(int IdPhong)
        {          
            txtTenPhong.Text = IdPhong.ToString();


            // hien thi tinh trang
            /*conn.Open();
            string max = "select tinhTrang from quanLiPhong where idPhong = "+ IdPhong;
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();      
            conn.Close();
            txtTinhTrang.Text = result;


            // hien thi so luong sinh vien 
            conn.Open();
            string max2 = "select dangThue from quanLiPhong where idPhong = " + IdPhong;
            SqlCommand cmd2 = new SqlCommand(max, conn);
            String result1 = (String)cmd.ExecuteScalar();
            conn.Close();
            txtSinhVien.Text = result1+ "/6"; */         

        }
        
        
        private void P101_Click(object sender, EventArgs e)
        {
        }

        // hiển thị thông tin chi tiết của các phòng

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            showinfor(101);
        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void P101_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void P102_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void tt2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            showinfor(102);
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void P109_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p9_Click(object sender, EventArgs e)
        {

        }

        private void tt9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void P103_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void tt3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            showinfor(103);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            showinfor(203);
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void P104_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p4_Click(object sender, EventArgs e)
        {

        }

        private void tt4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            showinfor(104);
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            showinfor(202);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void P108_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p8_Click(object sender, EventArgs e)
        {

        }

        private void tt8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            showinfor(108);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void P105_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p5_Click(object sender, EventArgs e)
        {

        }

        private void tt5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            showinfor(105);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            showinfor(201);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void P106_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p6_Click(object sender, EventArgs e)
        {

        }

        private void tt6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            showinfor(106);
        }

        private void P107_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p7_Click(object sender, EventArgs e)
        {

        }

        private void tt7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            showinfor(107);
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }
    }
}
