using AlgasApp.Abstract;
using AlgasApp.Models;

namespace AlgasApp.Services
{
    public class ErrandsGetterFromDb : IErrandsGetter
    {
        private readonly AppDbContext _dbContext;

        public ErrandsGetterFromDb(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Errand> GetErrands()
        {
            return _dbContext.Errands.ToList();
        }
    }
}
