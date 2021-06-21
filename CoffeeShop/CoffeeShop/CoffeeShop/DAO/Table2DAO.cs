using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;
using System.Data;

namespace CoffeeShop.DAO
{
   public class Table2DAO : ITable2DAO
    {
		private static Table2DAO _instance;

		public static Table2DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Table2DAO();
				}
				return _instance;
			}
		}

		public static int TableWidth = 88;
		public static int TableHeight = 88;

		private Table2DAO() { }
		public void SwitchTable(int id1, int id2)
		{
			DataProvider.Instance.ExecuteQuery("USP_SwitchTabel1 @idTable1 , @idTabel2", new object[] { id1, id2 });
		}
		public List<Table2> LoadTable2List()
		{
			List<Table2> tables = new List<Table2>();

			DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTableList1");

			foreach (DataRow row in data.Rows)
			{
				Table2 table = new Table2(row);
				tables.Add(table);
			}

			return tables;
		}

		public bool InsertTable2(string name)
		{
			string query = "EXEC USP_TableInsert1 @name";
			object[] param = new object[] { name };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateTable2(int id, string name, string status)
		{
			string query = "EXEC USP_TableUpdate1 @id , @name , @status";
			object[] param = new object[] { id, name, status };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
