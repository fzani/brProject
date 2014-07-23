using FluentNHibernate.Mapping;


namespace brProject.Models
{


    public class CategoryMap : ClassMap<Category>
    {

        public CategoryMap()
        {
            Schema("dbo");
            Table("Category");
            //LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");

            References(x => x.Parent).Column("Parent").Not.LazyLoad(); ;
            References(x => x.Store).Column("Store_Id").Not.LazyLoad(); ;

            Map(x => x.Name).Column("Name");

            HasMany(x => x.Categories).KeyColumn("Parent").Not.LazyLoad(); ;
            HasManyToMany(x => x.Products)
                   .Cascade.All()
                   .Table("Product_Category").Not.LazyLoad(); 
        }
    }
}
