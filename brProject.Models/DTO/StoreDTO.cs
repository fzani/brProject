using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Models
{
    public class StoreDTO
    {
        public int Id { get; protected set; }
        public string Name { get; set; }
        public IList<ProductDTO> Products { get; protected set; }
        public IList<CategoryDTO> Categories { get; protected set; }

        public StoreDTO()
        {
            Products = new List<ProductDTO>();
            //Staff = new List<Employee>();
            Categories = new List<CategoryDTO>();
        }

        //public virtual void AddProduct(Product product)
        //{
        //    product.StoresStockedIn.Add(this);
        //    Products.Add(product);
        //}

        //public virtual void AddEmployee(Employee employee)
        //{
        //    employee.Store = this;
        //    Staff.Add(employee);
        //}
    }
}
