using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_Project.API.Business.Models
{
    public class BasketProduct
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int BasketID { get; set; }
        public int amount { get; set; }
    }
}