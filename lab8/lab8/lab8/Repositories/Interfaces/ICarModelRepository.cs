using CarSalesDb.Models;
using CarSalesDb.ViewModels;

namespace CarSalesDb.Repositories
{
    public interface ICarModelRepository
    {
        List<CarModelVm> GetAll();
        CarModel? GetById(int id);
        void Add(CarModel carModel);
        void Update(CarModel carModel);
        void Delete(int id);
    }
}
