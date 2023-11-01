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
        public int VehicleTypeID { get; set; }
        public string VehicleTypeName { get; set; }
        public int PriceMultiplier { get; set; }
    }
}
