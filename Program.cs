using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("digite uma frase:");
            frase = Console.ReadLine();
            Console.WriteLine("o cebolinha diria:");
            Console.WriteLine(frase.Replace("r" , "l"));
        }
    }
}
