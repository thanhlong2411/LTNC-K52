using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class MenuDAO
	{
		private static MenuDAO _instance;

		public static MenuDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new MenuDAO();
				}
				return _instance;
			}
		}

		private MenuDAO() { }

		public List<Menu> GetListMenuByTable(int tableID)
		{
			List<Menu> listMenu = new List<Menu>();

			int billID = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
			if (billID != -1)
			{
				string query = "EXEC USP_GetMenuByBillID @billID";
				object[] param = new object[] { billID };
				DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

				foreach (DataRow row in table.Rows)
				{
					listMenu.Add(new Menu(row));
				}
			}

			return listMenu;
		}
	}
}
