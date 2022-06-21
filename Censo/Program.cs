using System;
using System.Globalization;

namespace Censo
{
    class Program
    {
        static void Main(string[] args)
        {
            var continuar = true;

            decimal totalSalario = 0;
            decimal mediaSalarial = 0;
            decimal maiorSalario = 0;

            var totalFilhos = 0;
            var mediaDeFilhos = 0;

            decimal percentualPessoasComSalarioMenorQue350 = 0;
            var quantidadePessoasComSalarioMenorQue350 = 0;

            var contador = 0;

            while (continuar)
            {
                Console.WriteLine($"Informe o salário: ");
                var salario = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (salario <= 350)
                    quantidadePessoasComSalarioMenorQue350++;

                if (maiorSalario < salario)
                    maiorSalario = salario;

                Console.WriteLine($"Informe o n° de filhos: ");
                var quantidadeFilhos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Deseja continuar? (S) ou (N)");
                var valor = Console.ReadLine();

                if (valor.Equals("n") || valor.Equals("N"))
                    continuar = false;

                totalSalario += salario;
                totalFilhos += quantidadeFilhos;
                contador++;
            }

            mediaSalarial = totalSalario / contador;
            mediaDeFilhos = totalFilhos / contador;
            percentualPessoasComSalarioMenorQue350 = (Convert.ToDecimal(quantidadePessoasComSalarioMenorQue350) / Convert.ToDecimal(contador)) * 100;

            Console.WriteLine($"Média salarial: R$ {mediaSalarial}\n");
            Console.WriteLine($"Média de número de filhos: {mediaDeFilhos}\n");
            Console.WriteLine($"Maior salário informado: R$ {maiorSalario}\n");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 350,00: {percentualPessoasComSalarioMenorQue350:F2}%\n");
        }
    }
}
