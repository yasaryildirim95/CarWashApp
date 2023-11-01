using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IOwnerVehicleService
    {
        bool SearchByPlate(string plate);
        bool AddOwner(string name, string surname, string phoneNumber, string email);
        bool AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName);
    }
}
