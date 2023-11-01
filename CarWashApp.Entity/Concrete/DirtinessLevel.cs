using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class DirtinessLevel : IEntity
    {
        public int DirtinessLevelID { get; set; }
        public string DirtinessLevelName { get; set; }
        public int AdditionalDuration { get; set; }

    }
}
