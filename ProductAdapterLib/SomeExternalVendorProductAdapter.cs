using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductLib;
using System.Threading.Tasks;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        private readonly SomeExternalVendorProduct _product;
        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct product)
        {
            _product = product;
        }

        public string Title
        {
            get { return _product.Description; }
        }

        public decimal UnitPrice
        {
            get
            {
                return _product.PricePerUnit;
            }
        }

        public string BarCode
        {
            get { return _product.EANCode; }
        }
    }
}
