using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class VehicleType : IEntity
    {
        public int VehicleTypeId { get; set; }
        public string VehicleName { get; set; }
        public int PriceMultiplier { get; set; }
    }
}
