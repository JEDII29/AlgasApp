using AlgasApp.Models;

namespace AlgasApp.Abstract
{
    public interface IErrandsRecorder
    {
        void SaveErrand(Errand errandToSave);
    }
}
