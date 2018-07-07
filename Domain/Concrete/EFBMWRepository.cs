using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
   public class EFBMWRepository : IBMWRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<BMW> BMWs
        {
            get { return context.BMWs; }
        }
       
    }
}
