using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class PersonelLeave : IEntity
    {
        public int ID { get; set; }
        public Personel Personel { get; set; }
        public int PersonelID { get; set; }
        public DateTime StartDate { get; set; }
        public int NumOfDays { get; set; }

    }
}
