using DatabaseViewerModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseViewerTemplate.Service
{
    public class DbService : IDbService
    {
        private readonly DbContext _context;

        public DbService(DbContext context)
        {
            _context = context;
        }

        // Replace (including interface) with your db query
        public List<T> getData<T>(Func<T, object>? orderBy = null)
        {
            throw new NotImplementedException();
        }
    }
}
