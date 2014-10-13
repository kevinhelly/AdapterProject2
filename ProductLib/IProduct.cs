using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public interface IProduct
    {
        string Title { get; }
        decimal UnitPrice { get; }
        string BarCode { get; }
    }
}
