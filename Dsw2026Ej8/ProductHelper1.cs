using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price) => $"[{code}] {description} - {GetPriceWithFormat(price)}";
    }
    
}
