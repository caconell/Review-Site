using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        public TacoContext db;
        public ReviewRepository(TacoContext db) 
        {
            this.db = db;
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetByID(int id)
        {
            return db.Reviews.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
