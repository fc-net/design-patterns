namespace Uow_Repository.Repositories.Entities
{
    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {
        public UserRepository(IDataFactory dataFactory) : base(dataFactory)
        {
        }
    }
}
