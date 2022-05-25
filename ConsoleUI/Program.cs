using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ReCapProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.VehicleId = 2;
            car1.BrandId = 4;
            car1.ColorId = 5;
            car1.DailyPrice = 400;
            car1.Desciription = "Temiz çiziksiz";
            
            VehicleManager vehicleManager = new VehicleManager(new InMemoryVehicleDal());
            vehicleManager.Add(car1);
           

            foreach (var car in vehicleManager.GetAll())
            {
                Console.WriteLine(car.Desciription);
            }

 
        }
    }
}