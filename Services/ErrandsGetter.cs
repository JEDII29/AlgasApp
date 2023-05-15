using AlgasApp.Abstract;
using AlgasApp.Models;

namespace AlgasApp.Services
{
    public class ErrandsGetter : IErrandsGetter
    {
        public List<Errand> GetErrands() => new List<Errand>{
                new Errand
                {
                    Id = 1,
                    FullName = "Igor Wozny",
                    ServiceType = "serwis",
                    OrderTime = DateTime.Now,
                    Description = "nie odpala"
                },
                new Errand
                {
                    Id = 2,
                    FullName = "Jebac Koziera",
                    ServiceType = "do wyjebania",
                    OrderTime = DateTime.Today,
                    Description = "error e10"
                },
                new Errand
                {
                    Id = 3,
                    FullName = "Alina Chuj",
                    ServiceType = "serwis",
                    OrderTime = DateTime.UtcNow,
                    Description = "wymiana szamotu"
                }
        };

    }
}
