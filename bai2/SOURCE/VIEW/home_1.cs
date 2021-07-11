using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace bai2.SOURCE.VIEW
{
    public partial class home_1 : Form
    {
        public home_1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtWelcome_Click(object sender, EventArgs e)
        {

        }

        private void home_1_Load(object sender, EventArgs e)
        {
            this.infChar.Series["Year"].Points.AddXY("2016", 350);
            this.infChar.Series["Year"].Points.AddXY("2017", 400);
            this.infChar.Series["Year"].Points.AddXY("2018", 450);
            this.infChar.Series["Year"].Points.AddXY("2019", 450 );
            this.infChar.Series["Year"].Points.AddXY("2020", 470);
            timer1.Start();
            


            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void home_1_Shown(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.ShowSync(welcome, false, BunifuAnimatorNS.Animation.Transparent);
            transition.ShowSync(mid, false, BunifuAnimatorNS.Animation.Transparent);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        int j = 0;
        int n = 0;
        int m = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            txtTongPhong.Text = i.ToString();
            if (i == 100)
                timer1.Stop();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            txtPhongSua.Text = j.ToString();
            if (j == 3)
                timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            n++;
            txtPhongTrong.Text = n.ToString();
            if (n == 53)
                timer3.Stop();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            m=m+5;
            txtTongSinhVien.Text = m.ToString();
            if (m ==590)
                timer4.Stop();
        }
       
    }
}
