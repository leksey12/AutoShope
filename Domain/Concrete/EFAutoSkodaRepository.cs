using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
   public class EFAutoSkodaRepository : IAutoSkodaRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<AutoSk> AutoSkoda
        {
            get { return context.AutoSkoda; }
        }
    }
}
