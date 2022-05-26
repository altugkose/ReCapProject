using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleDal : ICarDal
    {
        List<Car> _carList;
        public InMemoryVehicleDal()
        {
            _carList = new List<Car> { new Car {} };
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int vehicleId)
        {
            return _carList.Where(c => c.VehicleId == vehicleId).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateToCar;

            UpdateToCar = _carList.FirstOrDefault(c => c.VehicleId == car.VehicleId);

            UpdateToCar.ModelYear = car.ModelYear;
            UpdateToCar.DailyPrice= car.DailyPrice;
            UpdateToCar.Desciription = car.Desciription;
        }
    }
}
