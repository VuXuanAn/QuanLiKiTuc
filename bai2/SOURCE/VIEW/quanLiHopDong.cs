using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bai2.SOURCE.VIEW
{
    public partial class quanLiHopDong : Form
    {
        public quanLiHopDong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        quanLyKiTucXaEntities3 sv = new quanLyKiTucXaEntities3();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9UQ2HGP\SQLEXPRESS;Initial Catalog=quanLyKiTucXa;Integrated Security=True");


        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        // hàm hỗ trợ 
        // load trang hợp đồng 
        private void quanLiHopDong_Load(object sender, EventArgs e)
        {
            showDataInTable();

            conn.Open();
            string max =    "select count(IdHopDong) from hoaDonPhong" ;
            string max1 = "select count(IdHopDong) from hoaDonPhong where thanhToan = 'Da thanh toan'";
            string max2 = "select count(IdHopDong) from hoaDonPhong where thanhToan = 'Chua thanh toan'";

            SqlCommand cmd = new SqlCommand(max, conn);
            int result = (int)cmd.ExecuteScalar();
            txtSumOfBill.Text = result.ToString();

            SqlCommand cmd1 = new SqlCommand(max1, conn);
            int result1 = (int)cmd1.ExecuteScalar();
            txtDaThanhToan.Text = result1.ToString();


            SqlCommand cmd2 = new SqlCommand(max2, conn);
            int result2 = (int)cmd2.ExecuteScalar();
            txtChuaThanhToan.Text = result2.ToString();

            conn.Close();


            txtMaPhong.DataSource = sv.getAllRoom();



        }

        // hiển thị dữ liệu nên girdView 
        void showDataInTable()
        {

            dgvHopDong.DataSource = sv.getAllBill1();
        }


        // hàm reset
        public void reset()
        {
            txtMaHopDong.Text = "";
            KiHan.Text = "";
            txtMaPhong.Text = "";
            txtMaSinhVien.Text = "";
            checkBox.Checked = false;
            cbxNgayBatDau.Text = "";

        }

        // hiển thị dữ liệu khi click vào girdView 
        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHopDong.CurrentRow.Index;
            txtMaHopDong.Text = dgvHopDong.Rows[i].Cells[0].Value.ToString();           
            txtMaPhong.Text = dgvHopDong.Rows[i].Cells[1].Value.ToString();
            txtMaSinhVien.Text = dgvHopDong.Rows[i].Cells[2].Value.ToString();
            KiHan.Text = dgvHopDong.Rows[i].Cells[3].Value.ToString();
            cbxNgayBatDau.Text = dgvHopDong.Rows[i].Cells[4].Value.ToString();

            if(dgvHopDong.Rows[i].Cells[5].Value.ToString()== "Da thanh toan")
            {
                checkBox.Checked = true;
            }else checkBox.Checked = false;
        }




        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------  THÊM - SỬA - XÓA -----------------------------------------------------------------------------------------------


        // ------------------------------------------------------------------------THÊM -----------------------------------------------------------------------------------------------
        // hiển thị nút đăng kí 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            btnDangKi.Visible = true;
            btnXoa.Visible = false;

        }

        // Hàm đăng kí 
        private bool dangKi()
        {
            
            String trangThai;
            if (checkBox.Checked == true)
            {
                trangThai = "Da thanh toan";
            }
            else
                trangThai = "Chua thanh toan";

            sv.pc_insertBill(int.Parse(txtMaHopDong.Text), int.Parse( txtMaPhong.Text), int.Parse(txtMaSinhVien.Text), int.Parse(KiHan.Text), Convert.ToDateTime(cbxNgayBatDau.Text), trangThai);
            return true;
        }

        //active đăng kí button 
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

            /*conn.Open();
            string max = "select max(IdHopDong) from hoaDonPhong ";
            SqlCommand cmd = new SqlCommand(max, conn);
            int result = (int)cmd.ExecuteScalar();
            txtMaHopDong.Text = (result + 1).ToString();
            conn.Close();*/
            btnChuyenPhong.Visible = false;
            btnDangKi.Visible = true;
            btnXoa.Visible = false;
        }

        //tiến hành đăng kí 
        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
            
            if (dangKi() == true)
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                btnDangKi.Visible = false;
                btnChuyenPhong.Visible = true;
                btnXoa.Visible = true;
            }
            else
            {
                MessageBox.Show("thêm thất bại , vui lòng kiểm tra lại thông tin");
            }

            showDataInTable();
            reset(); 
        }
        // ------------------------------------------------------------------------ XÓA  -----------------------------------------------------------------------------------------------

        // hàm xóa hợp đồng 

        private bool xoaHopDong(int maHopDong)
        {
            sv.deleteBill(maHopDong);
            return true;

        }
        // Tiến hành xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa hợp đồng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {

                if(xoaHopDong(int.Parse(txtMaHopDong.Text)))
                {
                    MessageBox.Show("Xóa thành công !");
                    showDataInTable();
                    reset();
                }
                else MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại thông tin !");
                }


              
        }
        // --------------------------------------------------------------------------------------------------------------------------------------------------------------

        // kiểm tra 1 sinh viên  có trong cơ sở dữ liệu hay không ?
        public bool check(String maSinhVien)
        {
            conn.Open();
            string max = "select gioiTinh from quanLiHoSoSinhVien where maSinhVien = " +maSinhVien;
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();
            conn.Close();

                return result == null ? true :false ;
        }



        // kiểm tra sinh viên đã thuê phòng chưa
       /* public bool checkSinhVien(String maSinhVien)
        {
            conn.Open();
            string max = "select maSinhVien from hoaDonPhong where maSinhVien = " + maSinhVien;
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();
            conn.Close();
            return result != null ? true : false;
        }*/





        // bắt lỗi mã sinh viên 
        private void txtMaSinhVien_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (check((txtMaSinhVien.Text).ToString()))
            {
                e.Cancel = true;
                txtMaSinhVien.Focus();
                validMSV.SetError(txtMaSinhVien, "Sinh viên không hợp lệ hoặc đã thuê phòng rồi !");
            }
            else
            {
                e.Cancel = false;
                validMSV.SetError(txtMaSinhVien, "");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        // kiểm tra 1 phòng có trong cơ sở dữ liệu hay không ?
        private bool checkPhong(String maPhong)
        {
            conn.Open();
            string max = "select tinhTrang from quanLiPhong where idPhong = " + maPhong;            
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();
            conn.Close();
            return result == null ? true : false;
        }

        // kiểm tra 1 phòng còn sức chứa hay không ?
        private bool checkSucChua(String maPhong)
        {
            conn.Open();
            string max = "select dangThue from quanLiPhong where idPhong = " + maPhong;
            SqlCommand cmd = new SqlCommand(max, conn);
            String result = (String)cmd.ExecuteScalar();
            conn.Close();
            if(result == null )
            {
                return true;
            }
            else
            return int.Parse(result) == 6 ? true : false;
        }
        //tiến hành bắt lỗi phòng
        private void txtMaPhong_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (checkPhong((txtMaPhong.Text).ToString())&& checkSucChua((txtMaPhong.Text).ToString()))
            {
                e.Cancel = true;
                 txtMaPhong.Focus();
                validMSV.SetError(txtMaPhong, "Phòng không hợp lệ hoặc đã đầy !");
            }
            else
            {
                e.Cancel = false;
                validMSV.SetError(txtMaPhong, "");
            }
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            dgvHopDong.DataSource = sv.getAllBill1();
        }
        // tìm kiếm sinh viên 

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = sv.findContract(int.Parse(txtMaSV.Text));
        }
        // lọc đã thanh toán 
        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            dgvHopDong.DataSource = sv.findPaidContract1();
        }

        private void radRadioButton3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            dgvHopDong.DataSource = sv.findUnaidContract2();
        }
        // chuyển phòng 
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {


            // xóa hợp đồng cũ 
            xoaHopDong(int.Parse(txtMaHopDong.Text));
            // tạo hợp đồng mới 
            if (dangKi() == true)
            {
                MessageBox.Show("Chuyển phòng thành công !");
                reset();
                btnDangKi.Visible = false;
            }
            else
            {
                MessageBox.Show("Chuyển phòng thất bại  , vui lòng kiểm tra lại thông tin");
            }

            showDataInTable();
            reset();
        }


        // -------------------------------------------------------------------------------------------------------------------------------------------------------------









    }
}
