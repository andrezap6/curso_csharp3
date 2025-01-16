using System;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, media;


            Console.WriteLine("Escreva a primeira nota do aluno:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva a segunda nota do aluno");
            num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2) / 2;
            Console.WriteLine("Media: {0}", media); 







        }
    }
}
