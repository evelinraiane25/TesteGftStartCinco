using System;

namespace Concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Informe o valor do carro: ");
            var valorCarro = Convert.ToDecimal(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine($"Informe se a compra é á vista (V) ou à prazo (P): ");
            var aVistaOuAPrazo = Console.ReadLine();

            var quantidadeParcelas = 0;

            if (aVistaOuAPrazo.Equals("p") || aVistaOuAPrazo.Equals("P"))
            {
                Console.WriteLine($"Informe a quantidade de parcelas: 6, 12 ou 18.");
                quantidadeParcelas = Convert.ToInt32(Console.ReadLine());
            }

            if (quantidadeParcelas == 0)
            {
                var valorDesconto = valorCarro * 20 / 100;
                Console.Write($"Preço final: R$ {valorCarro - valorDesconto}");
                return;
            }

            if (quantidadeParcelas == 6)
            {
                var valorAcrescimo = valorCarro * 3 / 100;
                Console.Write($"Preço final: R$ {valorCarro + valorAcrescimo}\n");
                Console.Write($"Quantidade de parcelas: {quantidadeParcelas}\n");
                Console.Write($"Valor da parcela: R$ {(valorCarro + valorAcrescimo) / quantidadeParcelas}\n");
                return;
            }

            if (quantidadeParcelas == 12)
            {
                var valorAcrescimo = valorCarro * 6 / 100;
                Console.Write($"Preço final: R$ {valorCarro + valorAcrescimo}\n");
                Console.Write($"Quantidade de parcelas: {quantidadeParcelas}\n");
                Console.Write($"Valor da parcela: R$ {(valorCarro + valorAcrescimo) / quantidadeParcelas}\n");
                return;
            }

            if (quantidadeParcelas == 18)
            {
                var valorAcrescimo = valorCarro * 9 / 100;
                Console.Write($"Preço final: R$ {valorCarro + valorAcrescimo}\n");
                Console.Write($"Quantidade de parcelas: {quantidadeParcelas}\n");
                Console.Write($"Valor da parcela: R$ {(valorCarro + valorAcrescimo) / quantidadeParcelas}\n");
                return;
            }
        }
    }
}