namespace Uow_Repository.Repositories.Entities
{
    public class DepartamentRepository : RepositoryBase<Departaments>, IDepartamentRepository
    {
        public DepartamentRepository(IDataFactory dataFactory) : base(dataFactory)
        {
        }
    }
}
