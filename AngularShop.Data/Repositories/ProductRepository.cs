using AngularShop.Data.Infrastructure;
using AngularShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace AngularShop.Data.Repositories
{
    public  interface IProductRepository
    {

    }
    public class ProductRepository : ResponsitoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.Products.Where(x => x.Alias == alias);
        }
    }
}