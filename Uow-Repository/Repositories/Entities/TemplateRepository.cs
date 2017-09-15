namespace Uow_Repository.Repositories.Entities
{
    public class TemplateRepository : RepositoryBase<Templates>, ITemplateRepository
    {
        public TemplateRepository(IDataFactory dataFactory) : base(dataFactory)
        {
        }
    }
}
