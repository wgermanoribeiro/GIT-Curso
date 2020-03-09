using System;

/*
 * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
 * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
*/


namespace ExercicioLogica
{
    class Peça
    {
        static void A(string[] args)
        {
            int codProduto1, codProduto2;
            decimal valorProduto1, qntProduto1, total1;
            decimal valorProduto2, qntProduto2, total2,  totalVenda;



            Console.WriteLine("Insira o código do primeiro item: ");
            codProduto1 = int.Parse(Console.ReadLine());           

            Console.WriteLine("Insira a quantidade do primeiro item: ");
            qntProduto1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do primeiro item: ");
            valorProduto1 = decimal.Parse(Console.ReadLine());

            total1 = qntProduto1 * valorProduto1;



            Console.WriteLine("Insira o código do segundo item: ");
            codProduto2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do segundo item: ");
            qntProduto2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do segundo item: ");
            valorProduto2 = decimal.Parse(Console.ReadLine());

            total2 = qntProduto2 * valorProduto2;



            totalVenda = total1 + total2 ;


            Console.WriteLine("Valor a pagar = " + totalVenda);
        }


    }
}
