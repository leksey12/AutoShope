using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.AutoShop
{
    [Table("AutoSkoda")]
   public class AutoSk
    {
        [Key]
        public int AutoSkodaId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string AutosID { get; set; }
        public decimal Price { get; set; }
        
    }
}
