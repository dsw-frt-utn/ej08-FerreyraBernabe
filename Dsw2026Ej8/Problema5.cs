using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale) 
        {
            return sale.CalculateTotal();
        }
    }
    internal class Sale 
    {
        decimal total;
        public virtual decimal CalculateTotal() { return total;}
    }
    internal class  RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal();
        }
    }
    internal class WholeSale : Sale
    {
        decimal discount = 0.1M;
        public override decimal CalculateTotal()
        {
            decimal total = base.CalculateTotal();
            return total * (1 - discount);
        }
    }
}
