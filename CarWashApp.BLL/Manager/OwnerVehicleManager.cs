using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class OwnerVehicleManager : BaseManager<VehicleOwner>, IOwnerVehicleService
    {
        protected OwnerVehicleRepository _ownerVehicleRepository;

        public OwnerVehicleManager(OwnerVehicleRepository ownerVehicleRepository) : base(ownerVehicleRepository)
        {
            _ownerVehicleRepository = ownerVehicleRepository;
        }

        public bool SearchByPlate(string plate)
        {
            try
            {
                return _ownerVehicleRepository.SearchByPlate(plate);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddOwner(string name, string surname, string phoneNumber, string email)
        {
            try
            {
                return _ownerVehicleRepository.AddOwner(name, surname, phoneNumber, email);
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName)
        {
            try
            {
                return _ownerVehicleRepository.AddVehicle(phoneNumber, plate, brand, model, color, vehicleTypeName);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
