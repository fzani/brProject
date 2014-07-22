using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class Category
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual Category Parent { get; protected set; }
        public virtual IList<Product> Products { get; protected set; }
    }
}
