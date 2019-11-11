using AngularShop.Data.Infrastructure;
using AngularShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupRepository : IResponsitory<MenuGroup>
    {
    }

    public class MenuGroupRepository : ResponsitoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        void IResponsitory<MenuGroup>.Add(MenuGroup entity)
        {
            throw new NotImplementedException();
        }

        void IResponsitory<MenuGroup>.Delete(MenuGroup entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<MenuGroup> IResponsitory<MenuGroup>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<MenuGroup> IResponsitory<MenuGroup>.GetMulti(Expression<Func<MenuGroup, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<MenuGroup> IResponsitory<MenuGroup>.GetMultiPaging(Expression<Func<MenuGroup, bool>> filter, out int total, int index, int size, string[] includes)
        {
            throw new NotImplementedException();
        }
    }
}
