using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class ProductDTO
    {
        public  int Id { get; protected set; }
        public  string Name { get; set; }
        public  double Price { get; set; }
        public  StoreDTO Store { get; protected set; }
        public  IList<CategoryDTO> Categories { get; protected set; }

        public ProductDTO()
        {
            //Stores = new List<Store>();
            Categories = new List<CategoryDTO>();
        }
    }
}
