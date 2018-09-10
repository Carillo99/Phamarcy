using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class PrescriptionStatusRepository : Repository<PrescriptionStatus>, IPrescriptionStatusRepository
    {
        public PrescriptionStatusRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
