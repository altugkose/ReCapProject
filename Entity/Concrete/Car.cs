using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : IEntity
    {

        [Key]
        public int VehicleId;
        
        public string Name { get ; set ; }
        public int ModelYear { get ; set ; }
        public decimal DailyPrice { get ; set; }
        public string Desciription { get ; set ; }
        
    }
}
