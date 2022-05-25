using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : IVehicles
    {
        public int VehicleId { get ; set ; }
        public int BrandId { get ; set ; }
        public int ColorId { get ; set ; }
        public int ModelYear { get ; set ; }
        public decimal DailyPrice { get ; set; }
        public string Desciription { get ; set ; }


    }
}
