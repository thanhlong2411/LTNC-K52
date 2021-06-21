using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class Account
	{
		private string userName;
		private string displayName;
		private string password;
		private int type;
		//private string image;
		public string UserName { get => userName; set => userName = value; }
		public string DisplayName { get => displayName; set => displayName = value; }
		public string Password { get => password; set => password = value; }
		public int Type { get => type; set => type = value; }
		//public string Image { get => image; set => image = value; }

		public Account(string userName, string displayName, int type, string password = null)
		{
			UserName = userName;
			DisplayName = displayName;
			Password = password;
			Type = type;
			//Image = image;
		}

		public Account(DataRow row)
		{
			UserName = row["userName"].ToString();
			DisplayName = row["displayName"].ToString();
			Type = (int)row["type"];
			Password = row["password"].ToString();
			//Image = row["image"].ToString();
		}
	}
}
