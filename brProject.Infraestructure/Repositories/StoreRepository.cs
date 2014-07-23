using AutoMapper;
using brProject.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Infraestructure
{
    public class StoreRepository<T> : Repository<T> where T : class
    {
        public StoreRepository()
        {
            Mapper.CreateMap<Category, CategoryDTO>();
            Mapper.CreateMap<Product, ProductDTO>();
            Mapper.CreateMap<Store, StoreDTO>();
        }
        public IList<ProductDTO> ProductGetByCategory(int id)
        {
            //IList<ProductDTO> list;
            CategoryDTO catMap = new CategoryDTO();

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                var cat = session.Get<Category>(id);


                //Mapper.CreateMap<Category, CategoryDTO>()
                //    .ForMember(
                //    a => a.Categories,
                //    b => b.MapFrom(
                //        c => Mapper.Map<ICollection<Category>,
                //            ICollection<CategoryDTO>>(c.Categories)
                //            ))
                //    .ForMember(
                //    a => a.Store,
                //    b => b.MapFrom(
                //        c => Mapper.Map<Store,
                //            StoreDTO>(c.Store)
                //            ));


                //.ForMember(m => m.Products, opt => opt.MapFrom(f => f.Products));
                Mapper.Map<Category, CategoryDTO>(cat, catMap); //error


            }

            return catMap.Products;
        }

        public IList<CategoryDTO> CategoryGetAll()
        {
            IList<CategoryDTO> response;

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                IList<Category> list;

                list = session.CreateCriteria<Category>().List<Category>();

                response = Mapper.Map<IList<Category>, IList<CategoryDTO>>(list);
            }

            return response;
        }
    }
}
