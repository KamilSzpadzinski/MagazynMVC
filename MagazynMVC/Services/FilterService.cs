using MagazynMVC.Interfaces;
using MagazynMVC.Model.Models;
using MagazynMVC.Persistence;

namespace MagazynMVC.Services
{
    public class FilterService : IFilterService

    {
        private MagazynDbContext _dbContex;

        public FilterService(MagazynDbContext dbContex)
        {
            _dbContex = dbContex;
        }


        public List<Filter> GetFilters()
        {
            var filters = _dbContex.Filter.ToList();

            return filters;


        }
    }

}
