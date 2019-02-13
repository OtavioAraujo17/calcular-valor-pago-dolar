using System;
using System.Globalization;

namespace Valor_pago_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólar você quer comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tot = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais = " + tot.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
