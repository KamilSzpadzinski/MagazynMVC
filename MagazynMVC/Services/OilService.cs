using MagazynMVC.Interfaces;
using MagazynMVC.Model.Models;
using MagazynMVC.Persistence;

namespace MagazynMVC.Services
{
    public class OilService : IOilService
    {
        private MagazynDbContext _dbContext;

        public OilService(MagazynDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Oil> GetOils()
        {
            var oils = _dbContext.Oil.ToList();

            return oils;
        }
    }
}
