using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class BillDAO
	{
		private static BillDAO _instance;

		public static BillDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BillDAO();
				}
				return _instance;
			}
		}

		private BillDAO() { }

       

        /// <summary>
        /// Thành công: bill ID
        /// Thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
		{
			string query = "EXEC USP_GetUncheckBillsByTableID @tableID";
			object[] param = new object[] { id };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			if (table.Rows.Count > 0)
			{
				Bill bill = new Bill(table.Rows[0]);
				return bill.ID;
			}

			return -1;
		}

		public void InsertBill(int tableID)
		{
			string query = "EXEC USP_InsertBill @idTable";
			object[] param = new object[] { tableID };

			DataProvider.Instance.ExecuteNonQuery(query, param);
		}

		public void Checkout(int billID, int discount, float totalPrice)
		{
			string query = "EXEC USP_CheckoutBill @billID , @discount , @totalPrice";
			object[] param = new object[] { billID, discount, totalPrice };

			DataProvider.Instance.ExecuteNonQuery(query, param);
		}

		public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
		{
			string query = "EXEC USP_GetListBillByDate @checkIn , @checkOut";
			object[] param = new object[] { checkIn, checkOut };
			return DataProvider.Instance.ExecuteQuery(query, param);
		}
	}
}
