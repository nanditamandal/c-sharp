using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public interface ISalesmanRepository
    {

        bool Insert(Salesman s);
        bool Update(Salesman s);
        bool Delete(Salesman s);
      //  Salesman Get(string salesman_ID);
        List<Salesman> GetAllSalesman();
    }
}
