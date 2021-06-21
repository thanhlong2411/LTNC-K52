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
using System.Globalization;

namespace CoffeeShop
{
    public partial class Tang1 : UserControl
    {
        public Tang1()
        {
			InitializeComponent();
            LoadTable();
        }
		private Account account;
		public Table CurerntTable { get => lvFood.Tag as Table; }


		public Tang1(Account acc)
		{
			account = acc;
			InitializeComponent();


			
		}
		private void Tang1_Load(object sender, EventArgs e)
		{
			LoadTable();
			LoadCategory();
			LoadComboboxTable(cbSwitchTable);
		}
		#region Method
		void LoadCategory()
		{
			List<Category> categories = CategoryDAO.Instance.GetListCategory();
			cbCategory.DataSource = categories;
			cbCategory.DisplayMember = "Name";
		}

		void LoadFoodListByCategoryID(int catID)
		{
			List<Food> foods = FoodDAO.Instance.GetFoodsByCategoryID(catID);
			cbFood.DataSource = foods;
			cbFood.DisplayMember = "Name";
		}

		private void fpTable_Paint(object sender, PaintEventArgs e)
        {

        }
		void LoadTable()
		{
			fpTable.Controls.Clear();
			List<Table> tableList = TableDAO.Instance.LoadTableList();

			foreach (Table table in tableList)
			{
				Label btn = new Label()
				{
					Width = TableDAO.TableWidth,
					Height = TableDAO.TableHeight
				};
				btn.Text = table.Name + Environment.NewLine + table.Status;
				btn.Tag = table;

				switch (table.Status)
				{
					case "Trống":
						btn.Image = Properties.Resources.coffee_cup__1_;
						break;

					default:
						btn.Image = Properties.Resources.coffee_cup__2_;
						break;
				}

				btn.Click += Btn_Click;
				fpTable.Controls.Add(btn);
			}
		}
		void ShowBill(int tableId)
		{
			List<DTO.Menu> listMenu = MenuDAO.Instance.GetListMenuByTable(tableId);
			float totalPrice = 0;

			lvFood.Items.Clear();
			foreach (DTO.Menu item in listMenu)
			{
				ListViewItem lsvItem = new ListViewItem(item.FoodName);
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString("###,###,###"));
				lvFood.Items.Add(lsvItem);

				totalPrice += item.TotalPrice;
			}

			CultureInfo culture = new CultureInfo("vi-VN");
			// Thread.CurrentThread.CurrentCulture = culture;
			txtTotalPrice.Text = totalPrice.ToString("c", culture);
		}
		void LoadComboboxTable(ComboBox cb)
		{
			cb.DataSource = TableDAO.Instance.LoadTableList();
			cb.DisplayMember = "Name";
		}
#endregion 

		private void Btn_Click(object sender, EventArgs e)
			{
				Table currentTable = (sender as Label).Tag as Table;
				int tableID = currentTable.ID;
				lvFood.Tag = currentTable; // Lưu trữ bàn hiện tại vào tag của listview để dễ sử dụng 

				ShowBill(tableID);
			}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.CurerntTable == null)
			{
				MessageBox.Show("Hãy chọn bàn cần thêm món");
				return;
			}

			Table table = this.CurerntTable;

			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int idFood = (cbFood.SelectedItem as Food).ID;
			int count = (int)nmAmount.Value;

			if (idBill == -1)
			{
				BillDAO.Instance.InsertBill(table.ID);
				idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			}

			BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);

			ShowBill(table.ID);
			LoadTable();
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
			int id = 0;

			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;

			Category selected = cb.SelectedItem as Category;
			id = selected.ID;

			LoadFoodListByCategoryID(id);
		}


		private void btnSwitchTable_Click(object sender, EventArgs e)
		{
			int id1 = (lvFood.Tag as Table).ID;

			int id2 = (cbSwitchTable.SelectedItem as Table).ID;
			if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lvFood.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				TableDAO.Instance.SwitchTable(id1, id2);

				LoadTable();
			}
		}

        private void btnCheckout_Click(object sender, EventArgs e)
        {
			if (this.CurerntTable == null) return;

			int billID = BillDAO.Instance.GetUncheckBillIDByTableID(this.CurerntTable.ID);
			int discount = (int)nmDiscount.Value;
			double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Replace(".", string.Empty).Split(',')[0]);
			double finalTotalPrice = totalPrice - (totalPrice * discount / 100);

			if (billID != -1)
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendLine($"Bạn có chắc chắn thanh toán hóa đơn cho {this.CurerntTable.Name} ?");
				builder.AppendLine($"Tổng tiền ban đầu: {totalPrice}");
				builder.AppendLine($"Discount: {discount}%");
				builder.AppendLine($"Tổng tiền sau khi giảm giá: {finalTotalPrice}");
				string msg = builder.ToString();

				DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					BillDAO.Instance.Checkout(billID, discount, (float)finalTotalPrice);
					ShowBill(this.CurerntTable.ID);
				}
			}

			LoadTable();
		}
    }
}
