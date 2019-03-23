namespace CityFlow.Core.Entity
{
    public class Address : BaseEntity
    {
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
