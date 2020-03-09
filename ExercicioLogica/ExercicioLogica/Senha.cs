using System;
using System.Collections.Generic;
using System.Text;

/*
 * Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
 * incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
 * impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
 */

namespace ExercicioLogica
{
    class Senha
    {
        public static void A(String[] args)
        {
            int senha = 0;

            while (senha != 2002)
            {
                Console.WriteLine("Digite sua Senha: ");
                senha = int.Parse(Console.ReadLine()); 

                if (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }
            }

        }

    }
}
