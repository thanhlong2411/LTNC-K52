using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.DAO;
using CoffeeShop.DTO;

namespace CoffeeShop
{
    public partial class FMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private Account account;
        public FMain(Account acc)
        {
            InitializeComponent();
            account = acc;
           ChangeAccount();
        }
        void ChangeAccount()
        {
            ribbonPanelQuanLy.Enabled = account.Type == 1;
            ribbonPanelTraCuu.Enabled = account.Type == 1;
            ribbonBar2.Text += $" ({account.DisplayName})";
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            this.Width = 805;
            this.Height = 676;
            CoffeeShop.Tang1 f = new CoffeeShop.Tang1();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

      

        private void buttonItem8_Click(object sender, EventArgs e)//thucdon
        {
            this.Width = 805;
            this.Height = 600;
            CoffeeShop.ThucDon f = new CoffeeShop.ThucDon();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem15_Click(object sender, EventArgs e)//Oder
        {
            this.Width = 805;
            this.Height = 670;
            CoffeeShop.Tang1 f = new CoffeeShop.Tang1();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem9_Click(object sender, EventArgs e)//danhmuc
        {
            this.Width = 809;
            this.Height = 560;
            CoffeeShop.DanhMuc f = new CoffeeShop.DanhMuc();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem10_Click(object sender, EventArgs e)//ban
        {
            this.Width = 800;
            this.Height = 657;
            CoffeeShop.Ban f = new CoffeeShop.Ban();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem11_Click(object sender, EventArgs e)//nhanvien
        {
            this.Width = 970;
            this.Height = 670;
            CoffeeShop.NhanVien f = new CoffeeShop.NhanVien();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem18_Click(object sender, EventArgs e)//doangthu
        {
            this.Width = 800;
            this.Height = 660;
            CoffeeShop.DoanhThu f = new CoffeeShop.DoanhThu();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem19_Click(object sender, EventArgs e)//thongke
        {
            this.Width = 963;
            this.Height = 634;
            CoffeeShop.ThongKe f = new CoffeeShop.ThongKe();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            this.Width = 513;
            this.Height = 464;
            CoffeeShop.Profile f = new CoffeeShop.Profile(account);
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            FrExcel f = new FrExcel();
            f.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)//taikhoan
        {
            this.Width = 800;
            this.Height = 665;
            CoffeeShop.TaiKhoan f = new CoffeeShop.TaiKhoan();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            this.Width = 805;
            this.Height = 676;
            CoffeeShop.Tang1 f = new CoffeeShop.Tang1();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
