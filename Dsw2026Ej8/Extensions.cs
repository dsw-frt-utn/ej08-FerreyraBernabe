using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string code) 
        {
            if (code is not null)
            {
                code = code.Trim();
                code = code.ToUpper();
                code = code.Replace(' ', '-');

                return code;
            }
            else return "SIN-CODIGO";
        }
    }
}
