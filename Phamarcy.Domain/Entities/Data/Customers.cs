namespace Phamarcy.Domain.Entities.Data
{
    public class Customers : EntitiesBase
    {
        public int AddressesId { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string FullName { get; protected set; }
        public string Phone { get; protected set; }
        public string CreditCardNumber { get; protected set; }
        public string DateCardExpiry { get; protected set; }
        public string Details { get; protected set; }

        public virtual Addresses Addresses { get; protected set; }
    }
}
