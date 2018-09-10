namespace Phamarcy.Domain.Entities.Data
{
    public class PrescriptionItems : EntitiesBase
    {
        public int MedicationId { get; protected set; }
        public int PrescriptionsId { get; protected set; }
        public string PrescriptionQuantity { get; protected set; }
        public string InstructionsCustumer { get; protected set; }
        
        public virtual Medication Medication { get; protected set; }
        public virtual Prescriptions Prescriptions { get; protected set; }
    }
}
