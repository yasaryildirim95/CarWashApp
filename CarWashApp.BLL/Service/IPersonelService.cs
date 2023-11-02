namespace CarWashApp.BLL.Service
{
    public interface IPersonelService
    {
        (bool, bool) CheckLoginInfo(string username, string password);
        bool AddUser(string name, string surname, int salary, int shiftTypeId, bool isWasher);
        bool AddLoginDetails(string idAndName, string username, string password);
        bool AddPersonelLeave(string idAndName, DateTime startDate, int dayCount);
        List<string> FillCombobox();
    }
}
