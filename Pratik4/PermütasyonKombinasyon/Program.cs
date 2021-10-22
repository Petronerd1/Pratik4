using System;

namespace KDV
{
    class Program
    {
        static void Main(string[] args)
        {

            double price, tax, totalprice;
            Console.Write("Ürün Fiyatını Giriniz : ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Kdv Giriniz : ");
            tax = double.Parse(Console.ReadLine());
            totalprice = price + price * (tax / 100);
            Console.Write("KDV'li Fiyatı = {0}", totalprice);
            Console.ReadKey();

        }
    }
}
