using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class OwnerVehicleManager : BaseManager<VehicleOwner>,IOwnerVehicleService
    {
        protected OwnerVehicleRepository _ownerVehicleRepository;

        public OwnerVehicleManager(OwnerVehicleRepository ownerVehicleRepository) : base(ownerVehicleRepository)
        {
            _ownerVehicleRepository = ownerVehicleRepository;
        }

        public string SearchByPlate(string plate)
        {
            try
            {
                if (_ownerVehicleRepository.SearchByPlate(plate))
                {
                    return "Plaka bulundu.";
                }
                else
                {
                    return "Plaka kayıtlı değil.";
                }
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
        public string AddOwner(string name, string surname, string phoneNumber, string email)
        {
            try
            {
                var newOwner = new VehicleOwner()
                {
                    Name = name,
                    Surname = surname,
                    PhoneNumber = phoneNumber,
                    Email = email,
                };

                if(_ownerVehicleRepository.AddOwner(newOwner))
                {
                    return "Araç sahibi eklemesi gerçekleştirildi.";
                }
                else
                {
                    return "Araç sahibi eklemesi gerçekleştirilemedi.";
                }
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }

        }
        public string AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName)
        {
            try
            {
                if(_ownerVehicleRepository.AddVehicle(phoneNumber, plate, brand, model, color, vehicleTypeName))
                {
                    return "Araç eklendi";
                }
                return "Araç eklenemedi";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
    }
}
