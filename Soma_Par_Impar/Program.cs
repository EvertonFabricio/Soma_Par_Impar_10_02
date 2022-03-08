using System;

namespace Soma_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0, par = 0, impar = 0;

            Console.WriteLine("Digite um número inteiro e positivo.");
            num = int.Parse(Console.ReadLine());

            if (num >=0 && num <= 1000)

            do
            {

                if (num % 2 == 0)                
                    par = num + par;
                
                else
                    impar = num + impar;

                Console.WriteLine("\nDigite outro número inteiro e positivo." +
                " O Programa será encerrado quando digitar um número negativo ou maior que 1000");
                num = int.Parse(Console.ReadLine());
            }

            while (num <= 1000 && num >= 0);

            Console.WriteLine("\n**Programa encerrado!**\n");
            Console.WriteLine($"A soma de todos os números pares digitados é igual a {par}");
            Console.WriteLine($"\nA soma de todos os números impares digitados é igual a {impar}\n\n\n\n\n\n\n\n");


        }
    }
}
