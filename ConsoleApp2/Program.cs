using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um texto");

            var digitadoPeloUsuario = Console.ReadKey(true);

            switch (digitadoPeloUsuario.KeyChar)
            {
                case 'a':
                    {
                        Console.WriteLine($"Você digitou a");
                        break;
                    }
                    case 'b':
                    {
                        Console.WriteLine($"Você digitou b");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Você digitou {digitadoPeloUsuario.KeyChar}");
                        break;
                    }
            }

            Console.ReadLine();

        }
    }
}
