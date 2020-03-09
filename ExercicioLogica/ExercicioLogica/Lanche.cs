using System;
using System.Collections.Generic;
using System.Text;

/*
 * Com base na tabela de preços ao lado, faça um programa que leia o código de um item e a
 * quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
 * 
 */

namespace ExercicioLogica
{
    class Lanche
    {
        static void A(string[] args)
        {
            int codigo, quantidade;
            double preco = 0, total;

            Console.WriteLine("Digite o código do lanche: " +
                "1 - Cachorro Quente / " +
                "2 - X-Salada / " +
                "3 - X-Bacon / " +
                "4 - Torrada Simples / " +
                "5 - Refrigerante ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                preco = 4.0;
            }
            else if (codigo == 2)
            {
                preco = 4.50;
            }
            else if (codigo == 3)
            {
                preco = 5.00;
            }
            else if (codigo == 4)
            {
                preco = 2.00;
            }
            else if (codigo == 5)
            {
                preco = 1.50;
            }
            
            total = quantidade * preco;

            Console.Write("Total a pagar: R$ " + total);

        }


    }
}
