namespace Uow_Repository.Repositories.Entities
{
    public class EmployeeRepository : RepositoryBase<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(IDataFactory dataFactory) : base(dataFactory)
        {
        }
    }
}
