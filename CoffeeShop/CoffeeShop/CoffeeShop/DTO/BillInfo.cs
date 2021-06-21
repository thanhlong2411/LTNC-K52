using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class BillInfo
	{
		private int iD;
		private int billID;
		private int foodID;
		private int count;

		public int ID { get => iD; set => iD = value; }
		public int BillID { get => billID; set => billID = value; }
		public int FoodID { get => foodID; set => foodID = value; }
		public int Count { get => count; set => count = value; }

		public BillInfo(int iD, int billID, int foodID, int count)
		{
			ID = iD;
			BillID = billID;
			FoodID = foodID;
			Count = count;
		}

		public BillInfo(DataRow row)
		{
			ID = (int)row["id"];
			BillID = (int)row["idBill"];
			FoodID = (int)row["idFood"];
			Count = (int)row["count"];
		}
	}
}
