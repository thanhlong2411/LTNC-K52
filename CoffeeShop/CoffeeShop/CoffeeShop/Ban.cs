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
    public partial class Ban : UserControl
    {
        BindingSource tableList = new BindingSource();
        public Ban()
        {
            InitializeComponent();
        }

        private void Ban_Load(object sender, EventArgs e)
        {
			LoadState();

		}
		void LoadState()
		{
			
			dgvTable.DataSource = tableList;
			LoadTableList();
			AddTableBinding();
		}
		void LoadTableList()
		{
			tableList.DataSource = TableDAO.Instance.LoadTableList();
		}
		void AddTableBinding()
		{
			txtTableId.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "ID"));
			txtTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Name"));
			txtTableStatus.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Status"));
		}
		private event EventHandler insertTableEvent;
		public event EventHandler InsertTableEvent
		{
			add { insertTableEvent += value; }
			remove { insertTableEvent -= value; }
		}

		private event EventHandler updateTableEvent;
		public event EventHandler UpdateTableEvent
		{
			add { updateTableEvent += value; }
			remove { updateTableEvent -= value; }
		}
		private event EventHandler deleteTable;
		public event EventHandler DeleteTable
		{
			add { deleteTable += value; }
			remove { deleteTable -= value; }
		}

		private void btnViewTable_Click(object sender, EventArgs e)
        {
			LoadTableList();
		}

		private void btnAddTable_Click(object sender, EventArgs e)
		{
			string name = txtTableName.Text;

			if (TableDAO.Instance.InsertTable(name))
			{
				MessageBox.Show("Thêm bàn ăn mới thành công");
				LoadTableList();
				insertTableEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra trong quá trình thêm bàn ăn");
			}
		}

		private void btnEditTable_Click(object sender, EventArgs e)
        {
			int id = Convert.ToInt32(txtTableId.Text);
			string name = txtTableName.Text;
			string status = txtTableStatus.Text;

			if (status != "Trống" && status != "Có người")
			{
				MessageBox.Show("Trạng thái của bàn ăn không hợp lệ");
				return;
			}

			if (TableDAO.Instance.UpdateTable(id, name, status))
			{
				MessageBox.Show("Cập nhật bàn ăn hợp lệ");
				LoadTableList();
				updateTableEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật bàn ăn");
			}
		}

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
			int id = Convert.ToInt32(txtTableId.Text);

			if (TableDAO.Instance.DeleteTable(id ))
			{
				MessageBox.Show("Xóa Bàn thành công");
				LoadTableList();
				deleteTable?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa Bàn");
			}
		}
    }
}
