using CarSalesDb.Models;
using CarSalesDb.ViewModels;

namespace CarSalesDb.Services.Interfaces
{
    public interface ICarModelService
    {
        List<CarModelVm> GetCarModels();
        CarModel? GetCarModelById(int id);
        void CreateCarModel(CarModel carModel);
        void UpdateCarModel(CarModel carModel);
        void DeleteCarModel(int id);
    }
}
