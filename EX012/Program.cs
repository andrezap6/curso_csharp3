﻿namespace EX012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.WriteLine("******************************");
            Console.WriteLine("Todos os pares de um intervalo:");
            Console.WriteLine("******************************");
            Console.WriteLine();

            Console.WriteLine("Digite o final do intervalo: ");
            final = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} , ", i);
                }
            }
        }
     }
}   
