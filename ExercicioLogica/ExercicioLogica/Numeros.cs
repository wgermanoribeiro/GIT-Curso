using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLogica
{
    class Numeros
    {
		public static void A(String[] args)
		{
			int N, X;
			int inn = 0, outt = 0;

			N = int.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				X = int.Parse(Console.ReadLine());

				if ((X >= 10) & (X <= 20))
				{
					inn++;
				}
				else
				{
					outt++;
				}
			}

			Console.WriteLine(inn + " in");
			Console.WriteLine(outt + " out");
		}
	}
}
