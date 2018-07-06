
using System;
using System.Collections.Generic;
using Domain.AutoShop;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Skoda> AutoSkoda { get; set; }
    }
    

}
