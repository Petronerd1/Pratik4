using System;
using System.Threading;

namespace ProgramBekletme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Thread.Sleep(10000);
            Console.Write("Süre Doldu");
            Console.ReadLine();
        }
    }
}
