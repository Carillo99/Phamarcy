using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
