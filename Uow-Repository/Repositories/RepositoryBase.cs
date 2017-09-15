using System.Data.Entity;
using System.Linq;

namespace Uow_Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private PruebasEntities _mainContext;
        private readonly IDbSet<TEntity> _dbset;

        protected IDataFactory DataFactory
        {
            get;
            private set;
        }

        protected PruebasEntities MainContext
        {
            get { return _mainContext ?? (_mainContext = DataFactory.GetContext()); }
        }

        protected RepositoryBase(IDataFactory dataFactory)
        {
            DataFactory = dataFactory;
            _dbset = MainContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbset.AsNoTracking().AsQueryable();
        }

        public virtual void Add(TEntity entityToAdd)
        {
            _dbset.Add(entityToAdd);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _dbset.Attach(entityToUpdate);
            _mainContext.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            _dbset.Remove(entityToDelete);
        }
    }
}
