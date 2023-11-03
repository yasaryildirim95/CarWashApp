using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Service
{
    public interface IPersonelService
    {
        (bool, bool) CheckLoginInfo(string username, string password);
        string AddUser(string name, string surname, int salary, int shiftTypeId, bool isWasher);
        string AddLoginDetails(int Id, string username, string password, bool IsAdmin);
        string AddPersonelLeave(PersonelLeave personelLeave);
        List<string> FillCombobox();
    }
}
