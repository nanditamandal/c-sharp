using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public interface ICustomerRepository
    {
        bool Insert(Customer c);
    }
}
