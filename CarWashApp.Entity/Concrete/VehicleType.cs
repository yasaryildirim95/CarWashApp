using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class VehicleType : IEntity
    {
        public int VehicleTypeID { get; set; }
        public string VehicleTypeName { get; set; }
        public int PriceMultiplier { get; set; }

        public override string ToString()
        {
            return $"{VehicleTypeName}";
        }
    }
}
