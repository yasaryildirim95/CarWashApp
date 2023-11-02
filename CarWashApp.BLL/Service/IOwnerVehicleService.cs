using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IOwnerVehicleService
    {
        string SearchByPlate(string plate);
        string AddOwner(string name, string surname, string phoneNumber, string email);
        string AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName);
    }
}
