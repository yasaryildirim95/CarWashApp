using CarWashApp.Entity.Abstract;

namespace CarWashApp.Entity.Concrete
{
    public class DirtinessLevel : IEntity
    {
        public int DirtinessLevelID { get; set; }
        public string DirtinessLevelName { get; set; }
        public int AdditionalDuration { get; set; }
        public override string ToString()
        {
            return DirtinessLevelName;
        }
    }
}
