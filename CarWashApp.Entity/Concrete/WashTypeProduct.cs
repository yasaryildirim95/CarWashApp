using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class WashTypeProduct : IEntity
    {
        public int WashTypeProductID { get; set; }
        public WashType WashType { get; set; }
        public int WashTypeID { get; set; }
        public Product Product { get; set; }
        public int ProductTypeID { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return WashType.WashTypeName + " " + Product.ProductName + " " + Quantity;
        }
    }
}
