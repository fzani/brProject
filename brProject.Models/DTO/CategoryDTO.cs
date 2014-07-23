using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class CategoryDTO
    {
        public CategoryDTO()
        {
            Categories = new List<CategoryDTO>();
            Products = new List<ProductDTO>();
        }
        public  int Id { get; set; }
        public  CategoryDTO Parent { get; set; }
        public  StoreDTO Store { get; set; }
        public  String Name { get; set; }
        public IList<CategoryDTO> Categories { get; set; }
        public  IList<ProductDTO> Products { get; set; }

    }
}
