using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class PharmaceuticalCompaniesRepository : Repository<PharmaceuticalCompanies>, IPharmaceuticalCompaniesRepository
    {
        public PharmaceuticalCompaniesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
