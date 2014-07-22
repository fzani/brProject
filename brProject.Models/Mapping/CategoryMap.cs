using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using FluentNHibernate.Automapping;
using brProject.Models;
using FluentNHibernate.Mapping;


namespace brProject.Models
{


    public class CategoryMap : ClassMap<Category>
    {

        public CategoryMap()
        {
            Table("Category");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            References(x => x.Parent).Column("Parent");
            Map(x => x.Name).Column("Name");
            Map(x => x.Parent).Column("Parent");
            HasManyToMany(x => x.Products)
                   .Cascade.All()
                   .Table("Product_Category");
        }
    }
}
