using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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
        [ScriptIgnore]
        public  CategoryDTO Parent { get; set; }
        [ScriptIgnore]
        public StoreDTO Store { get; set; }
        public  String Name { get; set; }
        [ScriptIgnore]
        public IList<CategoryDTO> Categories { get; set; }
        [ScriptIgnore]
        public IList<ProductDTO> Products { get; set; }

    }
}
