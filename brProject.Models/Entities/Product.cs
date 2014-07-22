using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class Product
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual IList<Store> Stores { get; protected set; }
        public virtual IList<Category> Categories { get; protected set; }

        public Product()
        {
            Stores = new List<Store>();
            Categories = new List<Category>();
        }
    }
}
