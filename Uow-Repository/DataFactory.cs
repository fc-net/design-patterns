using System;

namespace Uow_Repository
{
    public class DataFactory : IDataFactory, IDisposable
    {
        private PruebasEntities _context;

        public PruebasEntities GetContext()
        {
            return _context ?? (_context = new PruebasEntities());
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
