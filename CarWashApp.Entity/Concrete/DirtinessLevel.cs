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
        public int DirtinessLevelId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

    }
}
