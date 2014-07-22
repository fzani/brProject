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
            Table("Product");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            //References(x => x.Store).Column("Store_Id");
            Map(x => x.Name).Column("Name");
            HasManyToMany(x => x.Categories)
                .Cascade.All()
                .Table("Product_Category");
        }
    }

}
