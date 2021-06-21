using CoffeeShop.DTO;
using System.Collections.Generic;

namespace CoffeeShop.DAO
{
	public interface ITableDAO
	{
		List<Table> LoadTableList();
		bool InsertTable(string name);
		bool UpdateTable(int id, string name, string status);

		bool DeleteTable(int id);
	}
}
