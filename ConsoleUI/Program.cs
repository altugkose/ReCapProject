using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
       
            car1.Name = "Bmw";
            car1.DailyPrice = 1500;
            car1.Desciription = "Cabrio";
            car1.ModelYear = 2020;

            

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
         
           



        }
    }
}