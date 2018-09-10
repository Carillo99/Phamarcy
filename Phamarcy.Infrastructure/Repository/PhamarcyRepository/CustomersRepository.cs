using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class CustomersRepository : Repository<Customers>, ICustomersRepository
    {
        public CustomersRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
