using Phamarcy.Domain.Enum;

namespace Phamarcy.Domain.Entities.Data
{
    public class Medication : EntitiesBase
    {
        public TipeMedication TipeMedication { get; protected set; }
        public int CompaniesId { get; protected set; }
        public string Name { get; protected set; }
        public decimal Cost { get; protected set; }
        public string Description { get; protected set; }
        public string OtherDetails { get; protected set; }

        public virtual PharmaceuticalCompanies PharmaceuticalCompanies { get; set; }        
    }
}
