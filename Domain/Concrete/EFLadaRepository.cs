using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
   public class EFLadaRepository : ILadaRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Lada> Lada
        {
            get { return context.Lada; }
        }
       
    }
}
