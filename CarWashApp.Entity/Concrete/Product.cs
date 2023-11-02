using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int StockWarningThreshold { get; set; }

        public override string ToString()
        {
            return $"{ProductName}";
        }
    }
}
