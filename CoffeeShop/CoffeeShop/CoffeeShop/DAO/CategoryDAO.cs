using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class CategoryDAO : ICategoryDAO
	{
		private static CategoryDAO _instance;

		public static CategoryDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new CategoryDAO();
				}
				return _instance;
			}
		}

		private CategoryDAO() { }

		public List<Category> GetListCategory()
		{
			List<Category> categories = new List<Category>();

			string query = "EXEC USP_GetAllCategory";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				categories.Add(new Category(row));
			}

			return categories;
		}

		public Category GetCategoryByID(int id)
		{
			string query = "EXEC USP_GetCategoryByID @id";
			object[] param = new object[] { id };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				return new Category(row);
			}

			return null;
		}

		public bool InsertCategory(string name)
		{
			string query = "EXEC USP_CategoryInsert @name";
			object[] param = new object[] { name };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateCategory(int id, string name)
		{
			string query = "EXEC USP_CategoryUpdate @id , @name";
			object[] param = new object[] { id, name };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool DeleteCategory(int id)
		{
			string query = "EXEC USP_DeleteCategory @id ";
			object[] param = new object[] { id};
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
