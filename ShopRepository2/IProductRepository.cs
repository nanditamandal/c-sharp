using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public interface IProductRepository
    {
        bool Insert(Product p);
        bool Update(Product p);
        bool Delete(Product p);
      //  List<Product> search(string text);
        List<Product> GetAllProduct();
        List<Product> Buyallproduct();
        
    }
}
