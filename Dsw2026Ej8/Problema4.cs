using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int?[] notas = { nota1, nota2, nota3 };
            int totalNotas = 0;
            int cantNotasValidas=0;
            foreach(int? n in notas) 
            {
                if (n.HasValue && n.Value!<0 && n.Value!>10) 
                {
                    totalNotas += n.Value;
                    cantNotasValidas++;
                }
            }
            return cantNotasValidas > 0 ? totalNotas / cantNotasValidas : totalNotas;
        }
    }
}
