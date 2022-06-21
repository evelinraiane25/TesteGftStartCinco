using System;

namespace CategoriaDoNadador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Informe a idade do nadador: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 5)
                return;

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Nadador categoria: Infantil A");
                return;
            }

            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Nadador categoria: Infantil B");
                return;
            }

            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Nadador categoria: Juvenil A");
                return;
            }

            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Nadador categoria: Juvenil V");
                return;
            }

            Console.WriteLine("Nadador categoria: Adulto");
            return;
        }
    }
}
