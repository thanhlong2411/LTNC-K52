using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class Food
	{
		private int iD;
		private string name;
		private int categoryID;
		private float price;
		//private string image;

		public int ID { get => iD; set => iD = value; }
		public string Name { get => name; set => name = value; }
		public int CategoryID { get => categoryID; set => categoryID = value; }
		public float Price { get => price; set => price = value; }
		//public string Image { get => image; set => image = value; }

		public Food(int iD, string name, int categoryID, float price,string image)
		{
			ID = iD;
			Name = name;
			CategoryID = categoryID;
			Price = price;
			//Image = image;
		}

		public Food(DataRow row)
		{
			ID = (int)row["id"];
			CategoryID = (int)row["idCategory"];
			Name = row["name"].ToString();
			Price = (float)Convert.ToDouble(row["price"]);
			//Image = row["image"].ToString();
		}
	}
}
