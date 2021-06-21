using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.DAO
{
   public interface ITable2DAO
    {
        List<Table2> LoadTable2List();
        bool InsertTable2(string name);
        bool UpdateTable2(int id, string name, string status);
    }
}
