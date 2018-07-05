using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.AutoShop;

namespace Domain.AutoShop
{
    
   public class AutoSkoda
    {
        private List<AutoSkodaLine> lineCollection = new List<AutoSkodaLine>();
        public void AddItem(Auto auto)
        {
            AutoSkodaLine line = lineCollection
                .Where(g => g.Auto.Id == auto.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new AutoSkodaLine
                {
                    Auto = auto
                });
            }
            
        }
[Table("AutoSkoda")]
        public class AutoSkodaLine
        {
           
            public Auto Auto { get; set; }
             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int AutoSkodaId { get; set; }
            public string Name { get; set; }
            public string Model { get; set; }
            public string AutosID { get; set; }
            public decimal Price { get; set; }
        }

       

        public IEnumerable<AutoSkodaLine> Lines
        {
            get { return lineCollection; }
        }

    }
}
