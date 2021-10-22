using System;

namespace ParkingFee
{
    class Program
    {
        static void Main(string[] args)
        {
            int parktime = 0;
            int price = 0;
            Console.Write("Park Time : ");
            parktime = Convert.ToInt32(Console.ReadLine());
            if (parktime < 5) price = parktime * 1;
            else if (parktime > 3 && parktime < 7) price = parktime * 2;
            else if (parktime >= 7 && parktime < 15) price = parktime * 4;
            else if (parktime >= 20) price = parktime * 2;
            Console.Write("Parking Fee Payable = {0}",price);
            Console.ReadKey();

        }
    }
}
