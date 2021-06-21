using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
  public  class Table2
    {
		private int iD;
		private string name;
		private string status;

		public int ID { get => iD; set => iD = value; }
		public string Name { get => name; set => name = value; }
		public string Status { get => status; set => status = value; }

		public Table2(int iD, string name, string status)
		{
			ID = iD;
			Name = name;
			Status = status;
		}

		public Table2(DataRow row)
		{
			ID = (int)row["id"];
			Name = row["name"].ToString();
			Status = row["status"].ToString();
		}
	}
}
