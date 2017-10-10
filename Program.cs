using System;

namespace PrjCadastraPessoaSandro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Data = new string[10];
            string [] Variable = new string[] {"name","adress","city","birthPlace","city","age","genre","civelState","rg","cpf"};
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine("Digete o seu/sua " + Variable[i]);
                Data[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Relatório");
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine(Variable[i] + ":" + Data[i]);
            }
            Console.WriteLine();
        }
    }
}
