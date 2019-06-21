using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace Chunky.Data.Access.DAL
{
    public class ETUnitOfWork
    {
        private DbContext _context;

        public ETUnitOfWork(DbContext context)
        {
            _context = context;
        }
        public DbContext DbContext => _context;
        // public Itransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Snapshot)
        // {
            
        // }
        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>();
        }
    }
}