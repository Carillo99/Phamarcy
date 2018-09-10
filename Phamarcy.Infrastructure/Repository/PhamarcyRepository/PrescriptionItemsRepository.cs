using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class PrescriptionItemsRepository : Repository<PrescriptionItems>, IPrescriptionItemsRepository
    {
        public PrescriptionItemsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
