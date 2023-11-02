using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class Personel : IEntity
    {
        public int PersonelID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int LeavesLeft { get; set; }
        public Shift Shift { get; set; }
        public int ShifTypeID { get; set; }
        public bool IsWasher { get; set; }
        public bool IsWorking { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
