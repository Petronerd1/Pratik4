using System;

namespace KaçBasamaklıOlduğunu_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, timer = 1, b=1;
            string s;
            Console.Write("Number : ");
            s = Console.ReadLine();
            number = Int32.Parse(s);
            while ((number /b)>9)
            {
                b = b * 10;
                timer++;
            }
            Console.WriteLine(timer+" Order ");
            Console.ReadLine();
        }
    }
}
