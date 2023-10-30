using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class WashTypeProduct : IEntity
    {
        public WashType WashType { get; set; }
        public int WashTypeID { get; set; }
        public Product Product { get; set; }
        public int ProductTypeID { get; set; }
        public int Quantity { get; set; }
    }
}
