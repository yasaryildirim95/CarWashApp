using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class VehicleOwner : IEntity
    {
        public int VehicleOwnerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{VehicleOwnerID} {Name} {PhoneNumber}";
        }
    }
}
