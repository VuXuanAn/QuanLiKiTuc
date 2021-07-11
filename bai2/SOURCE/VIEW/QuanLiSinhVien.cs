using bai2.SOURCE.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bai2.SOURCE.VIEW
{
    public partial class QuanLiSinhVien : Form
    {
        public QuanLiSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9UQ2HGP\SQLEXPRESS;Initial Catalog=quanLyKiTucXa;Integrated Security=True");
        quanLyKiTucXaEntities3 sv = new quanLyKiTucXaEntities3();


        // chuyển dữ liệu hình ảnh sang mảng bit 
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        // chuyển dữ liệu mảng bit sang hình ảnh 
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }



        // hàm hiển thị dữ liệu nên gird view 
        void showDataInTable()
        {        
            dgv.DataSource = sv.getAllStudent();
            // set up image ảnh mặc định 
            ptrAnhSinhVien.Image = Image.FromFile(@"E:\tai lieu chuyen nganh\code C# winform\quanLiThuVien\image\avt.png");         
        }


        // khởi tạo list danh sách Sinh viên 
        List<sinhVien> data = new List<sinhVien>();
        

        private void QuanLiSinhVien_Load(object sender, EventArgs e)
        {
            showDataInTable();
            this.chart1.Series["Year"].Points.AddXY("2015", 300);
            this.chart1.Series["Year"].Points.AddXY("2016", 350);
            this.chart1.Series["Year"].Points.AddXY("2017", 400);
            this.chart1.Series["Year"].Points.AddXY("2018", 450);
            this.chart1.Series["Year"].Points.AddXY("2019", 450);
            this.chart1.Series["Year"].Points.AddXY("2020", 470);
        }

        // hiển thị thông tin sinh viên nên table 
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dgv.CurrentRow.Index;
            conn.Open();
            string max = "select hinhAnh from quanLiHoSoSinhVien where maSinhVien = " + dgv.Rows[i].Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand(max, conn);
            byte[] result = (byte[])cmd.ExecuteScalar();
            byteArrayToImage(result);
            conn.Close();
            ptrAnhSinhVien.Image = byteArrayToImage(result);
            txtMaSinhVien.Text = dgv.Rows[i].Cells[0].Value.ToString();
            
            txtHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dgv.Rows[i].Cells[2].Value.ToString();
                drdGioiTinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
                drdKhoa.Text = dgv.Rows[i].Cells[4].Value.ToString();
                dtNgaySinh.Text = dgv.Rows[i].Cells[5].Value.ToString();
                txtDienThoai.Text = dgv.Rows[i].Cells[6].Value.ToString();

            btnThem.Visible = false;
            btnXoa.Visible = true;
            btnCapNhap.Visible = true;         
        }

        private void radToggleButton3_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        // thêm sinh Viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(themSInhVien()==true)
            {
                MessageBox.Show("thêm thành công");
                reset();
                btnThem.Visible = false;
            }
            else
            {
                MessageBox.Show("thêm thất bại , vui lòng kiểm tra lại thông tin");
            }

            showDataInTable();
        }
        // hàm thêm sinh viên 
        private bool themSInhVien()
        {
            sv.sp_InsertSinhvien( int.Parse(txtMaSinhVien.Text), ImageToByteArray(ptrAnhSinhVien.Image), txtHoTen.Text, txtDiaChi.Text, drdGioiTinh.Text, drdKhoa.Text, Convert.ToDateTime(dtNgaySinh.Text), txtDienThoai.Text);
            return true;
        }
        // ham reset 
        private void reset()
        {
            txtMaSinhVien.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            drdGioiTinh.Text = "";
            drdKhoa.Text = "";
            dtNgaySinh.Text = "";
            txtDienThoai.Text = "";
            ptrAnhSinhVien.Image = Image.FromFile(@"E:\tai lieu chuyen nganh\code C# winform\quanLiThuVien\image\avt.png");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        // cập nhập sinh viên
        
       

        public bool capNhap()
        {

            sv.sp_updateStudent( int.Parse(txtMaSinhVien.Text), ImageToByteArray(ptrAnhSinhVien.Image), txtHoTen.Text, txtDiaChi.Text,
                drdGioiTinh.Text, drdKhoa.Text, Convert.ToDateTime(dtNgaySinh.Text), txtDienThoai.Text);          
            return true;
        }

        // set up UI cho phần text box tìm kiếm sính viên 

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtMaSV.Text== "NHẬP MÃ SINH VIÊN")
            {
                txtMaSV.Text = "";
                txtMaSV.ForeColor = Color.Gray;
            }
        }

        // hiệu ứng cho textBox tìm kiếm sinh viên 
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                txtMaSV.Text = "NHẬP MÃ SINH VIÊN";
                txtMaSV.ForeColor = Color.Gray;
            }
        }

        OpenFileDialog dlg = new OpenFileDialog();

        // load dường dẫn hình ảnh bằng button click 
        private void broHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            
            if (of.ShowDialog() == DialogResult.OK)
            {

                ptrAnhSinhVien.Image = new Bitmap(of.FileName);
            }

        }



     
        
        // active thêm sinh viên 
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            reset();


            /*conn.Open();
            string max = "select max(maSinhVien) from quanLiHoSoSinhVien ";
            SqlCommand cmd = new SqlCommand(max, conn);
            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            txtMaSinhVien.Text = Convert.ToString(result + 1);*/
            btnThem.Visible = true;
            btnXoa.Visible = false;
            btnCapNhap.Visible = false;
            txtMaSinhVien.Enabled = true;
        }
        // chức năng tìm kiếm sinh viên 
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

            dgv.DataSource = sv.sp_findStudent1(txtMaSV.Text);
            conn.Open();
            string max = "select hinhAnh from quanLiHoSoSinhVien where maSinhVien = " + dgv.Rows[0].Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand(max, conn);
            byte[] result = (byte[])cmd.ExecuteScalar();
            byteArrayToImage(result);
            conn.Close();
            ptrAnhSinhVien.Image = byteArrayToImage(result);
        }


        //cập nhập sinh viên 
        private void btnCapNhap_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
           
                if (capNhap() == true)
                {
                    MessageBox.Show("Sửa thành công");
                    showDataInTable();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ! vui lòng thử lại !");
                }

            
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(allStudent_rad.IsChecked == true)
            {
                showDataInTable();
            }
        }

        private void BoyStudent_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(BoyStudent.IsChecked)
            {
                dgv.DataSource = sv.sp_getAllBoyStudent();
            }
        }

        private void girlStudent_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (girlStudent.IsChecked)
            {
                dgv.DataSource = sv.sp_getAllGirlStudent1();
            }
        }
        // xóa sinh viên

        private void btnXoa_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa sinh viên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {

                sv.sp_DeleteStudent(txtMaSinhVien.Text);
                showDataInTable();

            }
            else
            {

            }
        }

        private void txtMaSinhVien_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaSinhVien.Text))
            {
                e.Cancel = true;
                txtMaSinhVien.Focus();
                validMaSinhVien.SetError(txtMaSinhVien, "Sinh viên không hợp lệ hoặc đã thuê phòng rồi !");
            }
            else
            {
                e.Cancel = false;
                validMaSinhVien.SetError(txtMaSinhVien, "");
            }
        }
    }
}
