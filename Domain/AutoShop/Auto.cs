using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создание класса модели данных
namespace Domain.AutoShop
{
   public class Auto
    {
        public int AUTOSHOPId { get; set; }
        public string NAME { get; set; }
        public string ADRESS { get; set; }
        public string CITY { get; set; }
        public string TELEPHONE { get; set; }
        public string SITE { get; set; }
    }
}
