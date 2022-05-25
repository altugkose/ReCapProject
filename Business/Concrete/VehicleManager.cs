using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VehicleManager : IVehicleService
    {   
        IVehicleDal  _vehicleDal;

        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public void Add(Car car)
        {
            _vehicleDal.Add(car);
        }

        public void Delete(Car car)
        {
            _vehicleDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return _vehicleDal.GetAll();
        }

        public List<Car> GetById(int brandId)
        {
            return _vehicleDal.GetById(brandId);
        }

        public void Update(Car car)
        {
            _vehicleDal.Update(car);
        }
    }
}
