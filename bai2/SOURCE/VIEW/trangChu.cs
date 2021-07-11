using bai2.SOURCE.VIEW;
using System;
using System.Windows.Forms;

namespace bai2
{
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();




            QuanLiSinhVien frm2 = new QuanLiSinhVien();
            frm2.TopLevel = false;
            panel4.Controls.Add(frm2);            
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            home_1 frm3 = new home_1();
            frm3.TopLevel = false;
            panel4.Controls.Add(frm3);
            frm3.Dock = DockStyle.Fill;
            frm3.Show();

            

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
           
            MDIParent1 frm2 = new MDIParent1();
            frm2.TopLevel = false;
            panel4.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 0;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
            i++;
            if (i % 2 != 0)
            {
                panel1.Width = 50;
            }
            else
            {
                
                panel1.Width = 230;
                btnUpdateProfile.Visible = true;
                radSeparator1.Visible = true;

                
            }
            
            

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

            
            panel4.Controls.Clear();


            home_1 frm2 = new home_1();
            frm2.TopLevel = false;
            panel4.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            quanLiHopDong frm2 = new quanLiHopDong();
            frm2.TopLevel = false;
            panel4.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            Form2 frm2 = new Form2();
            frm2.TopLevel = false;
            panel4.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }
    }

}
