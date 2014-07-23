using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using brProject.Models;
using FluentNHibernate.Mapping;


namespace brProject.Models
{



    public class ProductMap : ClassMap<Product>
    {

        public ProductMap()
        {
            Schema("dbo");
            Table("Product");
            //LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");

            References(x => x.Store).Column("Store_Id").Not.LazyLoad(); ;

            Map(x => x.Name).Column("Name");
            Map(x => x.Price).Column("Price");
            
            HasManyToMany(x => x.Categories)
                .Cascade.All()
                .ParentKeyColumn("Product_Id")
                  .ChildKeyColumn("Category_Id")
                .Table("Product_Category")
                .Not.LazyLoad();
        }
    }

}
