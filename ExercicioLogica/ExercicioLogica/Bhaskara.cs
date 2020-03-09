using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLogica
{
    class Bhaskara
    {
		public static void A()
		{
			double a ;
			double b ;
			double c ;

			Console.WriteLine("Expressão de Segundo Grau, Fórmula de Bhaskara");

			Console.Write("Digite a : ");
			a = double.Parse(Console.ReadLine());

			Console.Write("Digite b : ");
			b = double.Parse(Console.ReadLine());

			Console.Write("Digite c : ");
			c = double.Parse(Console.ReadLine());

			double delta = Math.Pow(b, 2.0) - (4 * a * c);

			if (a == 0 || delta < 0)
			{			
				Console.WriteLine("Impossível Calcular");
			}
			else
			{
				double raiz = Math.Sqrt(delta);
				var x1 = ((-(b)) + raiz) / (2 * a);
				var x2 = ((-(b)) - raiz) / (2 * a);

				Console.WriteLine("Valor de X1: {0:F3}", x1);
				Console.WriteLine("Valor de X2: {0:F3}", x2);
			}

			
			
		}
	}
}
