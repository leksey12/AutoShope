using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{

    public class EFSkodaRepository : ISkodaRepository
    {
        EFDbContext context = new EFDbContext();
    public IEnumerable<Skoda> Skodas
        {
            get { return context.Skodas; }

        }
    }
}
     
       

