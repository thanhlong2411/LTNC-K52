using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class TableDAO : ITableDAO
	{
		private static TableDAO _instance;

		public static TableDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new TableDAO();
				}
				return _instance;
			}
		}

		public static int TableWidth = 90;
		public static int TableHeight = 90;

		private TableDAO() { }
		public void SwitchTable(int id1, int id2)
		{
			DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
		}
		public List<Table> LoadTableList()
		{
			List<Table> tables = new List<Table>();

			DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTableList");

			foreach (DataRow row in data.Rows)
			{
				Table table = new Table(row);
				tables.Add(table);
			}

			return tables;
		}

		public bool InsertTable(string name)
		{
			string query = "EXEC USP_TableInsert @name";
			object[] param = new object[] { name };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateTable(int id, string name, string status)
		{
			string query = "EXEC USP_TableUpdate @id , @name , @status";
			object[] param = new object[] { id, name, status };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool DeleteTable(int id)
		{
			string query = "EXEC USP_DeleteTable @id";
			object[] param = new object[] { id };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
