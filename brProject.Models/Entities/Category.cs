using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class Category
    {
        public Category()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
        }
        public virtual int Id { get; set; }
        public virtual Category Parent { get; set; }
        public virtual Store Store { get; set; }
        public virtual String Name { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual IList<Product> Products { get; set; }

    }
}
