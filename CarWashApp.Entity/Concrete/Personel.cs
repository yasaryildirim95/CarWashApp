using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Personel : IEntity
    {
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary {  get; set; }
        public int LeaveNum { get; set; }
        public Shift Shift { get; set; }
        public int ShifTypeId { get; set; }

    }
}
