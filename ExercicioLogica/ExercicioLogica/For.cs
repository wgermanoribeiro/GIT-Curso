using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLogica
{
    class For
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite o numero #" + i);
                int Digit = int.Parse(Console.ReadLine());
                Console.WriteLine("Você digitou: " + Digit);
                soma += Digit;
            }
            Console.WriteLine("Soma Total= " + soma);

        }
    }
}
