using CoffeeShop.DTO;
using System.Collections.Generic;

namespace CoffeeShop.DAO
{
	public interface ICategoryDAO
	{
		List<Category> GetListCategory();
		Category GetCategoryByID(int id);
		bool InsertCategory(string name);
		bool UpdateCategory(int id, string name);
		bool DeleteCategory(int id);
	}
}
