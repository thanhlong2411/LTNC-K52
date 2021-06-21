using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class Bill
	{
		private int iD;
		private DateTime? dateCheckIn;
		private DateTime? dateCheckOut;
		private int status;
		private int discount;

		public int ID { get => iD; set => iD = value; }
		public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int Status { get => status; set => status = value; }
		public int Discount { get => discount; set => discount = value; }

		public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
		{
			ID = iD;
			DateCheckIn = dateCheckIn;
			DateCheckOut = dateCheckOut;
			Status = status;
			this.discount = discount;
		}

		public Bill(DataRow row)
		{
			ID = (int)row["id"];
			DateCheckIn = (DateTime?)row["DateCheckIn"];

			if(!string.IsNullOrWhiteSpace(row["DateCheckOut"].ToString()))
				DateCheckOut = (DateTime?)row["DateCheckOut"];

			Status = (int)row["status"];
			Discount = (int)row["discount"];
		}
	}
}
