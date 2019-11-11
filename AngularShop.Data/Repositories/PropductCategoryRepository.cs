using AngularShop.Data.Infrastructure;
using AngularShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace AngularShop.Data.Repositories
{
    public interface IPropductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class PropductCategoryRepository : ResponsitoryBase<ProductCategory>
    {
        public PropductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public  IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}