using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;
using System;
namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class PrescriptionsRepository : Repository<Prescriptions>, IPrescriptionsRepository
    {
        public PrescriptionsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
