using System.Collections.Generic;
using System.Threading.Tasks;
using Oqtane.Documentation;
using Oqtane.Models;

namespace Oqtane.Modules.SearchResults.Services
{
    [PrivateApi("Mark SearchResults classes as private, since it's not very useful in the public docs")]
    public interface ISearchResultsService
    {
        Task<Models.SearchResults> SearchAsync(int moduleId, SearchQuery searchQuery);
    }
}
