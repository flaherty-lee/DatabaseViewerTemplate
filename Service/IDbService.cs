using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseViewerModels;

namespace DatabaseViewerTemplate.Service
{
    public interface IDbService
    {
        public List<T> getData<T>(Func<T, object>? orderBy = null);
    }
}
