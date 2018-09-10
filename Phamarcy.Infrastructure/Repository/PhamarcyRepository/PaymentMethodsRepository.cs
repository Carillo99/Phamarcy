using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class PaymentMethodsRepository : Repository<PaymentMethods>, IPaymentMethodsRepository
    {
        public PaymentMethodsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
