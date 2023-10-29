using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Vehicle : IEntity
    {
        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public VehicleOwner VehicleOwner { get; set; }
        public int VehicleOwnerId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeId { get; set; }
    }
}
