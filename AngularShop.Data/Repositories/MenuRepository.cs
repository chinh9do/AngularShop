using System;
using System.Linq;
using System.Linq.Expressions;
using AngularShop.Data.Infrastructure;
using AngularShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuRepository : IResponsitory<Menu>
    {
    }

    public class MenuRepository : ResponsitoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        void IResponsitory<Menu>.Add(Menu entity)
        {
            throw new NotImplementedException();
        }

        void IResponsitory<Menu>.Delete(Menu entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Menu> IResponsitory<Menu>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<Menu> IResponsitory<Menu>.GetMulti(Expression<Func<Menu, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<Menu> IResponsitory<Menu>.GetMultiPaging(Expression<Func<Menu, bool>> filter, out int total, int index, int size, string[] includes)
        {
            throw new NotImplementedException();
        }
    }
}