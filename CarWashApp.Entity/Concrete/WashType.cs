using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class WashType : IEntity
    {
        public int WashTypeId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }

    }
}
