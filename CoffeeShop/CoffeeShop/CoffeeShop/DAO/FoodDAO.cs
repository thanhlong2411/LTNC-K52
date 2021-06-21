using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class FoodDAO
	{
		private static FoodDAO _instance;

		public static FoodDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new FoodDAO();
				}
				return _instance;
			}
		}

		private FoodDAO() { }

		public List<Food> GetFoodsByCategoryID(int catID)
		{
			List<Food> foods = new List<Food>();

			string query = "EXEC USP_GetFoodByCategoryID @catID";
			object[] param = new object[] { catID };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				foods.Add(new Food(row));
			}

			return foods;
		}

		public List<Food> GetListFood()
		{
			List<Food> foods = new List<Food>();

			string query = "EXEC USP_GetAllFood";

			DataTable table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				foods.Add(new Food(row));
			}

			return foods;
		}

		public List<Food> SearchFoodByName(string name)
		{
			List<Food> foods = new List<Food>();

			string query = "EXEC USP_SearchFoodByName @name";
			object[] param = new object[] { name };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				foods.Add(new Food(row));
			}

			return foods;
		}

		public bool InsertFood(string name, int idCategory, float price )
		{
			string query = "EXEC USP_InsertFood @name , @idCategory , @price ";
			object[] param = new object[] { name, idCategory, price };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateFood(int foodID, string name, int idCategory, float price)
		{
			string query = "EXEC USP_UpdateFood @id , @name , @idCategory , @price";
			object[] param = new object[] { foodID, name, idCategory, price };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool Delete(int foodID)
		{
			BillInfoDAO.Instance.DeleteBillInfoByFoodID(foodID);

			string query = "EXEC USP_DeleteFood @id";
			object[] param = new object[] { foodID };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
