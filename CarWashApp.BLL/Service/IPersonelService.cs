using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IPersonelService
    {
        (bool, bool) CheckLoginInfo(string username, string password);
        bool AddUser(string name, string surname, int salary, string shiftName, bool isWasher);
        bool AddLoginDetails(string idAndName, string username, string password);
        bool AddPersonelLeave(string idAndName, DateTime startDate, int dayCount);
        List<string> FillCombobox();
    }
}
