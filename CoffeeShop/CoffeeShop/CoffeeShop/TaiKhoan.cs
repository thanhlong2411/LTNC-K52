using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.DAO;
using CoffeeShop.DTO;

namespace CoffeeShop
{
    public partial class TaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();
		public Account LoginAccount;
		public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
			LoadState();
        }
		void LoadState()
		{
			
			dgvAccount.DataSource = accountList;
			LoadAccount();
			AddAccountBinding();
		}
		#region Account Methods

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}

		void AddAccountBinding()
		{
			txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			nmAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		void AddAccount(string userName, string displayNane, int type)
		{
			if (AccountDAO.Instance.Insert(userName, displayNane, type))
			{
				MessageBox.Show("Thêm tài khoản mới thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình thêm tài khoản");
			}

			LoadAccount();
		}

		void UpdateAccount(string userName, string displayNane, int type)
		{
			if (AccountDAO.Instance.Update(userName, displayNane, type))
			{
				MessageBox.Show("Cập nhât tài khoản thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình cập nhật tài khoản");
			}

			LoadAccount();
		}

		void DeleteAccount(string userName)
		{
            //if (userName.Equals(LoginAccount.UserName))
            //{
            //    MessageBox.Show("Tài khoản đang đăng nhập nên không thể xóa");
            //    return;
            //}

            if (AccountDAO.Instance.Delete(userName))
			{
				MessageBox.Show("Xóa tài khoản thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình xóa tài khoản");
			}

			LoadAccount();
		}

		void ResetPassword(string userName)
		{
			if (AccountDAO.Instance.ResetPassword(userName))
			{
				MessageBox.Show("Đặt lại mật khẩu mặc định thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình đặt lại mật khẩu");
			}
		}
        #endregion

        private void btnViewAcc_Click(object sender, EventArgs e)
        {
			LoadAccount();
		}

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
			string userName = txtNewUserName.Text;
			string displayName = txtDisplayName.Text;
			int type = (int)nmAccountType.Value;

			AddAccount(userName, displayName, type);
		}

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
			string userName = txtUserName.Text;
			string displayName = txtDisplayName.Text;
			int type = (int)nmAccountType.Value;

			UpdateAccount(userName, displayName, type);
		}

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
			string userName = txtUserName.Text;
			DeleteAccount(userName);
		}

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
			string userName = txtUserName.Text;
			ResetPassword(userName);
		}
    }
}
