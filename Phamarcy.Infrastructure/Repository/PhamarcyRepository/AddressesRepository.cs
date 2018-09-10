using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class AddressesRepository : Repository<Addresses>, IAddressesRepository
    {
        public AddressesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
