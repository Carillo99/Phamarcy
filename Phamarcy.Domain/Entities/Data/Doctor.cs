namespace Phamarcy.Domain.Entities.Data
{
    public class Doctor : EntitiesBase
    {
        public int AddressesId { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string FullName { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public string Descricao { get; protected set; }
        public string Gender { get; protected set; }

        public virtual Addresses Addresses { get; protected set; }
    }
}
