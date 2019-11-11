using AngularShop.Data.Infrastructure;
using AngularShop.Model.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace TeduShop.Data.Repositories
{
    public interface IOrderDetailRepository : IResponsitory<OrderDetail>
    {
    }

    public class OrderDetailRepository : ResponsitoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        void IResponsitory<OrderDetail>.Add(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        void IResponsitory<OrderDetail>.Delete(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<OrderDetail> IResponsitory<OrderDetail>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<OrderDetail> IResponsitory<OrderDetail>.GetMulti(Expression<Func<OrderDetail, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        IQueryable<OrderDetail> IResponsitory<OrderDetail>.GetMultiPaging(Expression<Func<OrderDetail, bool>> filter, out int total, int index, int size, string[] includes)
        {
            throw new NotImplementedException();
        }
    }
}