using CityFlow.Core.Entity.Enums;

namespace CityFlow.Core.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public MarkerTypeEnum MarkerType { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
    }
}
