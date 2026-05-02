using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valueCopy = originalValue;
            valueCopy++;
            Product productCopy = product;
            productCopy.SetDescription("Nueva descripción");

            return $"{originalValue}-{valueCopy}-{productCopy.GetDescription()}";
        }
    }
    public class Product 
    {
        private string _description;

        public string GetDescription() => _description;
        public string SetDescription(string description) => _description = description;
    }
}
