using System;

namespace CmToInch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter centimeter :");
            int centimeter = Convert.ToInt32(Console.ReadLine());
            double inch = 0.3937 * centimeter;
            Console.WriteLine("Inches is:" + inch);
            Console.ReadLine();
        }
    }
}
