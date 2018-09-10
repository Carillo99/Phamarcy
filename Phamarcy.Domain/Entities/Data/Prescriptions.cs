using System;
namespace Phamarcy.Domain.Entities.Data
{
    public class Prescriptions : EntitiesBase
    {
        public DateTime DateReceived { get; protected set; }
        public DateTime DateRenewal { get; protected set; }
        public DateTime DateSentToDoctor { get; protected set; }
        public DateTime DateReceivedFromdoctor { get; protected set; }
        public DateTime DateSentTocompany { get; protected set; }
        public DateTime DateFiled { get; protected set; }
        public DateTime Details { get; protected set; }
    }
}
