using System;
using System.Collections.Generic;
using System.Text;

/*
 * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
 * casas decimais conforme exemplos.
 * Fórmula: area = π.raio2
 * Considere o valor de π = 3.14159
 */

namespace ExercicioLogica
{
    class Raio
    {
        static void A(string[] args)
        {
            double pi = 3.14159;
            double raio, area;

            Console.WriteLine("Calcular área de um circulo");
            Console.Write("Insira o valor do raio do circulo => ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Formula: Área = pi.raio2");

            area = pi * (raio * raio);

            Console.WriteLine("Área do circulo: {0:F4}", area);
            
        }
    }    
}
