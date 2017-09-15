using System.Linq;

namespace Uow_Repository.Repositories
{
    public interface IRepository<TModel> where TModel : class
    {
        IQueryable<TModel> GetAll();
        void Add(TModel entityToAdd);
        void Update(TModel entityToUpdate);
        void Delete(TModel entityToDelete);
    }
}
