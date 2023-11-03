using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class Shift : IEntity
    {
        public int ShiftTypeID { get; set; }
        public string ShiftName { get; set; }
        public override string ToString()
        {
            return ShiftName;
        }
    }
}
