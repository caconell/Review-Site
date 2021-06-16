using System;
namespace ReviewsSite.Models
{

    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        //Category - Leaving out as per Davis (SABOTAGE!)
        //Review - Second sprint
        public string Description { get; set; }

        public Product(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }

        public Product()
        {
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

    }
}
