using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Shift : IEntity
    {
        public int ShiftTypeID { get; set; }
        public string ShiftName { get; set; }
    }
}
