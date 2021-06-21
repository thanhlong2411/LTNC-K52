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
    public partial class DanhMuc : UserControl
    {
        BindingSource categoryList = new BindingSource();
        public DanhMuc()
        {
            InitializeComponent();
        }
		void LoadState()
		{

			dgvCategory.DataSource = categoryList;
			LoadListCategory();
			AddCategoryBinding();
		}
			
		private void DanhMuc_Load(object sender, EventArgs e)
        {
			LoadState();
        }
		#region Category Methods

		void LoadListCategory()
		{
			categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
		}

		void AddCategoryBinding()
		{
			txtCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
			txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
		}

        #endregion

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
			LoadListCategory();
		}

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
			string name = txtCategoryName.Text;

			if (CategoryDAO.Instance.InsertCategory(name))
			{
				string msg = "Thêm nhóm thức ăn mới thành công";
				MessageBox.Show(msg);
				LoadListCategory();
				insertCategoryEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				string msg = "Có lỗi xảy ra trong quá trình thêm nhóm thức ăn";
				MessageBox.Show(msg);
			}
		}

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
			int id = int.Parse(txtCategoryId.Text);
			string name = txtCategoryName.Text;

			if (CategoryDAO.Instance.UpdateCategory(id, name))
			{
				MessageBox.Show("Cập nhật nhóm thức ăn thành công");
				LoadListCategory();
				updateCategoryEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra trong quá trinh cập nhật món thức ăn");
			}
		}
		private event EventHandler insertCategoryEvent;
		public event EventHandler InsertCategoryEvent
		{
			add { insertCategoryEvent += value; }
			remove { insertCategoryEvent -= value; }
		}

		private event EventHandler updateCategoryEvent;
		public event EventHandler UpdateCategoryEvent
		{
			add { updateCategoryEvent += value; }
			remove { updateCategoryEvent -= value; }
		}
		private event EventHandler deleteCategoryEvent;
		public event EventHandler DeleteCategoryEvent
		{
			add { deleteCategoryEvent += value; }
			remove { deleteCategoryEvent -= value; }
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

			int id = Convert.ToInt32(txtCategoryId.Text);

			if (CategoryDAO.Instance.DeleteCategory(id))
			{
				MessageBox.Show("Xóa Danh Mục thành công");
				LoadListCategory();
				deleteCategoryEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa Danh Mục");
			}
		}
    }
}
