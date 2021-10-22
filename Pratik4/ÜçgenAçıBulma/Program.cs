using System;

namespace ÜçgenAçıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Enter Angle :");
            int angle1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Enter Angle :");
            int angle2 = int.Parse(Console.ReadLine());
            int total = angle1 + angle2;
            int unknown = 180 - total;
            Console.WriteLine("Unknown angle :" + unknown);
            Console.ReadKey();
        }
    }
}
