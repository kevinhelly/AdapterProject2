using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product : IProduct
    {
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public string BarCode { get; set; }
    }
}
