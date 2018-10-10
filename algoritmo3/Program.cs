using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio1");
            Console.WriteLine();

            Console.Write("Digite o ano de nascimento: ");
            int anonasc  = Convert.ToInt32(Console.ReadLine());
            int idade = 2018 - anonasc;
            Console.WriteLine("Idade: " + idade);

            Console.WriteLine();

            if (idade >18)
            {
                Console.WriteLine("Maior de idade");
            }
            else if(idade<18)
            {
                Console.WriteLine("Menor de idade");
            }
            else if(idade==18)
            {
                Console.WriteLine("Maior de idade");
            }
            Console.ReadKey();      
        }
    }
}
