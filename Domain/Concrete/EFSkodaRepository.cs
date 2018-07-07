using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{

    public class EFSkodaRepository : IBMWRepository
    {
        EFDbContext context = new EFDbContext();
    public IEnumerable<Skoda> BMW
        {
            get { return context.Skodas; }

        }
    }
}
     
       

