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
    public partial class Flogin : DevComponents.DotNetBar.Office2007Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Flogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassWord.Text;

            if (!Login(userName, password))
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
                return;
            }

            Account account = AccountDAO.Instance.GetAccountByUserName(userName);
            FMain f = new FMain(account);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
     

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Bạn có chắc chắn muốn thoát chương trình hay không?";
            var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true; // Cancel event
        }
    }
}
