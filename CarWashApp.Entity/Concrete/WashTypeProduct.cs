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
        public int WashTypeId { get; set; }
        public Product Product { get; set; }
        public int ProductTypeId { get; set; }
        public int Quantity { get; set; }
    }
}
