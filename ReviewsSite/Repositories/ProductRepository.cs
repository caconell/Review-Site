using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ProductRepository : IRepository<Product>
        
    {
        public TacoContext db;
        

        public ProductRepository(TacoContext db)
        {
            this.db = db;
        
        
        }

        public void Create(Product obj)
        {
            db.Products.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Product> GetAll()
            {
                return db.Products.ToList();
            }

            public Product GetByID(int id)
            {
                return db.Products.Where(p => p.Id == id).FirstOrDefault();
            }

        //public Product SearchById(string id)
        //{
        //    return new Product();
        //    //return db.Products.Where(s => s. == id).FirstOrDefault();
        //}

        public void Update(Product obj)
        {
            db.Products.Update(obj);
            db.SaveChanges();
        }


    }
}
