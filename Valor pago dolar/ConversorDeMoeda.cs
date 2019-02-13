using System;
using System.Globalization;
namespace Valor_pago_dolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double tot = quantia * cotacao;
            return tot + tot * Iof / 100.00;
        }
 
    }
}
