using System;
using System.Globalization;

namespace TotalVendas
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal totalComprasAVista = 0;
            decimal totalComprasAPrazo = 0;
            decimal totalComprasEfetuadas = 0;
            decimal totalPrimeiraPrestacao = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Informe a {i}ª venda e o código da transação: ");
                string[] transacoes = Console.ReadLine().Split(" ");

                var codigo = transacoes[1];

                if (codigo.Equals("v") || codigo.Equals("V"))
                {
                    totalComprasAVista += decimal.Parse(transacoes[0], CultureInfo.InvariantCulture);
                }
                else if (codigo.Equals("p") || codigo.Equals("P"))
                {
                    totalComprasAPrazo += Convert.ToDecimal(transacoes[0], CultureInfo.InvariantCulture); 
                }
            }

            totalComprasEfetuadas = totalComprasAVista + totalComprasAPrazo;
            totalPrimeiraPrestacao = totalComprasAPrazo;

            Console.WriteLine($"Valor total de compras à vista: R$ {totalComprasAVista}");
            Console.WriteLine($"Valor total de compras à prazo: R$ {totalComprasAPrazo}");
            Console.WriteLine($"Valor total de compras efetuadas: R$ {totalComprasEfetuadas}");
            Console.WriteLine($"Valor total de primeira prestação de compras à prazo: R$ {totalPrimeiraPrestacao}");

        }
    }
}
