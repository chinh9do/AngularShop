using System;

namespace AngularShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AngularShopDbContext Init();
    }
}