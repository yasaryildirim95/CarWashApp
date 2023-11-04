using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class Vehicle : IEntity
    {
        public int VehicleID { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public VehicleOwner VehicleOwner { get; set; }
        public int VehicleOwnerID { get; set; }
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeID { get; set; }
        public override string ToString()
        {
            return Plate;
        }
    }
}
