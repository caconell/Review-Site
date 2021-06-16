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
                new Product(1, "Shrimp Tacos", "/images/spicy-shrimp-tacos.jpg"),
                new Product(2, "Keto Tacos", "/images/Keto-Tacos.jpg" ),
                new Product(3, "Ground Beef Tacos", "/images/ground-beef-tacos-3.jpg" ),
                new Product(4, "Carnitas Tacos", "/images/carnitas.jpg" ),
                new Product(5, "Chicken Tacos", "/images/instant-pot-shredded-chicken-tacos-5.jpg" ),
                new Product(6, "Fish Tacos", "/images/fish-taco.jpg" ),
                new Product(7, "Veggie Tacos", "/images/Vegetarian-Tacos-3.jpg" )
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
