using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Bcl.EntityFramework.Repositories
{
    public abstract class BclRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BclDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BclRepositoryBase(IDbContextProvider<BclDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BclRepositoryBase<TEntity> : BclRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BclRepositoryBase(IDbContextProvider<BclDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
