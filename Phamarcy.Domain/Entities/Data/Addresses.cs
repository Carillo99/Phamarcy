namespace Phamarcy.Domain.Entities.Data
{
    public class Addresses : EntitiesBase
    {
        public string Building { get; protected set; }
        public string Number { get; protected set; }
        public string Street { get; protected set; }
        public string City { get; protected set; }
        public string Postcode { get; protected set; }
        public string ProvinceCountre { get; protected set; }
        public string Country { get; protected set; }
        public string Details { get; protected set; }
    }
}
