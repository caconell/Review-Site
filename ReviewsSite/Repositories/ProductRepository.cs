using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ProductRepository : IRepository<Product>
        
    {
        public List<Product> productList;

        public ProductRepository()
        {
            productList = new List<Product>()
            {
                new Product(1, "Spam", "1.png" ),
                new Product(2, "Tofurkey", "2.png" ),
                new Product(3, "Garbage", "3.png" )
            };
        
        
        }

            public IEnumerable<Product> GetAll()
            {
                return productList;
            }

            public Product GetByID(int id)
            {
                return productList.Where(p => p.Id == id).FirstOrDefault();
            }
        

    }
}
