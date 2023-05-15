using AlgasApp.Abstract;
using AlgasApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlgasApp.Controllers
{
    [Route("api/[controller]")]
    public class ErrandsController : Controller
    {
        private readonly IErrandsGetter _errandsGetter;
        private readonly IErrandsRecorder _errandsRecorder;
        public ErrandsController(IErrandsGetter errandsGetter, IErrandsRecorder errandsRecorder) 
        {
            _errandsGetter = errandsGetter;
            _errandsRecorder = errandsRecorder;
        }

        [HttpGet]
        public List<Errand> Index()
        {
            return _errandsGetter.GetErrands();
        }

        [HttpPost]
        public void Post(Errand errand)
        {
            if (errand != null)
            {
                _errandsRecorder.SaveErrand(errand);
            }
        }
    }
}
