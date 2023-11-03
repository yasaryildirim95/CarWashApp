using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class WashType : IEntity
    {
        public int WashTypeID { get; set; }
        public string WashTypeName { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return WashTypeName;
        }
    }
}
