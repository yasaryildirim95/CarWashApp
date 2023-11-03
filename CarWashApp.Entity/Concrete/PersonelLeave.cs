using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class PersonelLeave : IEntity
    {
        public int ID { get; set; }
        public Personel Personel { get; set; }
        public int PersonelID { get; set; }
        public DateTime StartDate { get; set; }
        public int NumOfDays { get; set; }

        public override string ToString()
        {
            return Personel + " " + NumOfDays;
        }
    }
}
