using System;

namespace Phamarcy.Domain.Entities.Data
{
    public class ItemsOrdered : EntitiesBase
    {
        public int PrescriptionId { get; protected set; }
        public DateTime DateOrdered { get; protected set; }
        public int QuantityOrdered { get; protected set; }
        public DateTime DateReceiver { get; protected set; }
        public int Quantityreceived { get; protected set; }

        public virtual PrescriptionItems PrescriptionItems { get; protected set; }
    }
}
