using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Reviewername { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public Review(int id, int productId, string reviewername, string content)
        {
            Id = id;
            ProductId = productId;
            Reviewername = reviewername;
            Content = content;


        }

        public Review()
        {
        }
    }
   
}
