using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string producDescription, int quantity, decimal unitPrice)
        {
            var saleDetail = new
            {
                Code = productCode,
                Description = producDescription,
                Quantity = quantity,
                Total = quantity > 0 ? unitPrice * quantity : 0
            };

            return $"{saleDetail.Code}-{saleDetail.Description}-{saleDetail.Total}";
        }
    }
}
