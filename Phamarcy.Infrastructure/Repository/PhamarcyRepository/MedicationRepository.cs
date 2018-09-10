using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Enum;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class MedicationRepository : Repository<Medication>, IMedicationRepository
    {
        public MedicationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
