namespace CarWashApp.BLL.Service
{
    public interface IPersonelService
    {
        (bool, bool) CheckLoginInfo(string username, string password);
        bool AddUser(string name, string surname, int salary, int shiftTypeId, bool isWasher);
        string AddLoginDetails(int Id, string username, string password, bool IsAdmin);
        bool AddPersonelLeave(string idAndName, DateTime startDate, int dayCount);
        List<string> FillCombobox();
    }
}
