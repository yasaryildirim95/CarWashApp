using CarWashApp.BLL.Service;
using CarWashApp.DAL.Common;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class PersonelManager : BaseManager<Personel>, IPersonelService
    {
        protected PersonelRepository _personelRepository;

        public PersonelManager(PersonelRepository personelRepository) : base(personelRepository)
        {
            _personelRepository = personelRepository;
        }

        public (bool, bool) CheckLoginInfo(string username, string password)
        {
            try
            {
                return _personelRepository.CheckLoginInfo(username, password);
            }
            catch (Exception)
            {
                return (false, false);
            }
        }
        public string AddUser(string name, string surname, int salary, int shiftTypeId, bool isWasher)
        {
            try
            {
                if(_personelRepository.AddUser(name, surname, salary, shiftTypeId, isWasher))
                {
                    return "Kullanıcı eklendi";
                }
                return "Kullanıcı eklenemedi";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
        public string AddLoginDetails(int Id, string username, string password, bool IsAdmin)
        {
            try
            {
                if (_personelRepository.AddLoginDetails(Id, username, password, IsAdmin))
                {
                    return "Giriş Bilgileri eklendi.";
                }

                return "Giriş Bilgileri eklenemedi.";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
        public string AddPersonelLeave(PersonelLeave personelLeave)
        {
            try
            {
                if (_personelRepository.AddPersonelLeave(personelLeave))
                {
                    return "İzin tanımlandı.";
                }

                return "İzin tanımlanamadı.";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
        public List<string> FillCombobox()
        {
            var personel = _genericRepository.GetAll();
            List<string> outputList = new List<string>();

            foreach (var person in personel)
            {
                outputList.Add(person.PersonelID + "-" + person.Name);
            }

            return outputList;
        }

        public override void Add(Personel entity)
        {
            entity.LeavesLeft = 14;
            entity.IsWorking = false;
            base.Add(entity);
        }
        public List<Personel> GetAll(int temp)
        {
            return _personelRepository.GetAll(temp);
        }

        public List<PersonelLeave> GetAllPersonelLeaves()
        {
            return _personelRepository.GetAllPersonelLeaves();
        }

        public (List<PersonelAvailabilityStruct>, List<PersonelAvailabilityStruct>) ShowPersonelavailability()
        {
            return _personelRepository.ShowPersonelavailability();
        }
    }
}
