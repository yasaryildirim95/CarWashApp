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
        public int WashId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public WashType WashType { get; set; }
        public int WashTypeId { get; set; }
        public DirtinessLevel DirtinessLevel { get; set; }
        public int DirtinessLevelId { get; set; }
        public Personel Personel { get; set; }
        public int PersonelId { get; set;}



    }
}
