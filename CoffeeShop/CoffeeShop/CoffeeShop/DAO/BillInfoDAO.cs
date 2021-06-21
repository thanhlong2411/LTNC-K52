using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class BillInfoDAO
	{
		private static BillInfoDAO _instance;

		public static BillInfoDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BillInfoDAO();
				}
				return _instance;
			}
		}

		private BillInfoDAO() { }

		public List<BillInfo> GetListBillInfo(int billID)
		{
			List<BillInfo> billInfos = new List<BillInfo>();
			string query = "EXEC USP_GetBillInfosByBillID @billID";
			object[] param = new object[] { billID };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				billInfos.Add(new BillInfo(row));
			}

			return billInfos;
		}

		public void InsertBillInfo(int idBill, int idFood, int count)
		{
			string query = "EXEC USP_InsertBillInfo @idBill , @idFood , @count";
			object[] param = new object[] { idBill, idFood, count };

			DataProvider.Instance.ExecuteNonQuery(query, param);
		}

		public void DeleteBillInfoByFoodID(int foodID)
		{
			string query = "EXEC USP_DeleteBillInfoByFoodID @foodID";
			object[] param = new object[] { foodID };
			DataProvider.Instance.ExecuteNonQuery(query, param);
		}
	}
}
