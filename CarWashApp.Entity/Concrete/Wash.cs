using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Wash : IEntity
    {
        public int WashID { get; set; }
        public int Price { get; set; }
        public bool IsDone { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public WashType WashType { get; set; }
        public int WashTypeID { get; set; }
        public DirtinessLevel DirtinessLevel { get; set; }
        public int DirtinessLevelID { get; set; }
        public Personel? Personel { get; set; }
        public int? PersonelID { get; set;}
        public DateTime EndTime { get; set; }
    }
}
