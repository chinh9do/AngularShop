namespace AngularShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private AngularShopDbContext dbContext;

        public AngularShopDbContext Init()
        {
            return dbContext ?? (dbContext = new AngularShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}