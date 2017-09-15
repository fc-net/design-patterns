using System;

namespace Uow_Repository.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IDataFactory _dataFactory;
        private PruebasEntities _context;
        protected PruebasEntities MainContext => _context ?? (_context = _dataFactory.GetContext());

        public UnitOfWork(IDataFactory dataFactory)
        {
            _dataFactory = dataFactory;
        }

        public int Commit()
        {
            return MainContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                return;

            if (_context == null)
                return;

            _context.Dispose();
            _context = null;
        }
    }
}
