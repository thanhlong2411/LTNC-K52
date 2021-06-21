using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class Menu
	{
		private string foodName;
		private int count;
		private float price;

		public string FoodName { get => foodName; set => foodName = value; }
		public int Count { get => count; set => count = value; }
		public float Price { get => price; set => price = value; }
		public float TotalPrice { get => price * count; }

		public Menu(string foodName, int count, float price)
		{
			FoodName = foodName;
			Count = count;
			Price = price;
		}

		public Menu(DataRow row)
		{
			FoodName = row["name"].ToString();
			Price = (float)Convert.ToDouble(row["price"]);
			Count = (int)row["count"];
		}
	}
}
