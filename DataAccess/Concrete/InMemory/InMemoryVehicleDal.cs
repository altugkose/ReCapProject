using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleDal : IVehicleDal
    {
        List<Car> _carList;
        public InMemoryVehicleDal()
        {
            _carList = new List<Car> { new Car {VehicleId=1, BrandId=1, ColorId=9999, DailyPrice=200, ModelYear=2020, Desciription="Cabrio"} };
        }

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar;

            DeleteToCar = _carList.FirstOrDefault(c => c.VehicleId == car.VehicleId);

            _carList.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetById(int brandId)
        {
            return _carList.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateToCar;

            UpdateToCar = _carList.FirstOrDefault(c => c.VehicleId == car.VehicleId);

            UpdateToCar.BrandId=car.BrandId;
            UpdateToCar.ColorId=car.ColorId;
            UpdateToCar.ModelYear = car.ModelYear;
            UpdateToCar.DailyPrice= car.DailyPrice;
            UpdateToCar.Desciription = car.Desciription;
        }
    }
}
