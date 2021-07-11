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
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text== "USERNAME")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text=="")
            {
                txtUser.Text = "USERNAME";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //if (txtUser.Text=="VuXuanAn" && txtPassword.Text =="Anvu1998")
          // {
                load load1 = new load();
                load1.Show();
                this.Hide();
           /*}
           else
            {
             MessageBox.Show("Đăng nhập thất bại ! vui lòng kiểm tra lại thông tin");
            }*/
        }
    }
}
