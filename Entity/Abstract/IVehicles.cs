using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
    public interface IVehicles
    {
         int VehicleId { get; set; }
         int BrandId { get; set; }
         int ColorId { get; set; }
         int ModelYear { get; set; }
         decimal DailyPrice { get; set; }
         string Desciription { get; set; }


    }
}
