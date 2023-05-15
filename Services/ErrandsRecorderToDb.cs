using AlgasApp.Abstract;
using AlgasApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlgasApp.Services
{
    public class ErrandsRecorderToDb : IErrandsRecorder
    {
        private readonly AppDbContext _dbContext;

        public ErrandsRecorderToDb(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveErrand([FromBody]Errand errandToSave)
        {
            using (_dbContext)
            {
                _dbContext.Errands.Add(errandToSave);
                _dbContext.SaveChanges();
            }
        }
    }
}
