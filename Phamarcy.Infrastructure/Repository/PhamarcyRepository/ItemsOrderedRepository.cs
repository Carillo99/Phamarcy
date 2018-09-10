using Phamarcy.Domain.Entities.Data;
using Phamarcy.Domain.Repository.PhamarcyIRepository;
using Phamarcy.Infrastructure.DataContext;
using System;

namespace Phamarcy.Infrastructure.Repository.PhamarcyRepository
{
    public class ItemsOrderedRepository : Repository<ItemsOrdered>, IItemsOrderedRepository
    {
        public ItemsOrderedRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
