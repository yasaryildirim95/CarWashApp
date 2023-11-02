using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class LoginDetail : IEntity
    {
        public int ID { get; set; }
        public int PersonelID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        //Nav Property
        public Personel Personel { get; set; }

        public override string ToString()
        {
            return $"{PersonelID} {Username} {Password}";
        }
    }
}
