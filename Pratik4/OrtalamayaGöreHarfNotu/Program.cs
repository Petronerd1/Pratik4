using System;

namespace OrtalamayaGöreHarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize Notu :");
            int vize = int.Parse(Console.ReadLine());
            Console.Write("Final Notu :");
            int final = int.Parse(Console.ReadLine());
            double ort = (vize * 0.40) + (final * 0.60);
            if(ort>=0&& ort<=40) 
            {
                Console.Write("Ortalamanız={0} ", ort); Console.Write("FF Kaldınız\n ");
            }
            else if (ort >= 39 && ort <= 45) { Console.Write("Ortalamanız={0} ", ort); Console.Write("FD Kaldınız\n"); }
            else if (ort >= 46 && ort <= 52) { Console.Write("Ortalamanız={0}", ort); Console.Write("DD Koşullu\n"); }
            else if (ort >= 53 && ort <= 59) { Console.Write("DC Koşullu\n"); }
            else if (ort >= 60 && ort <= 66) { Console.Write("CC Geçtiniz\n"); }
            else if (ort >= 67 && ort <= 73) { Console.Write("Ortalamanız={0}", ort); Console.Write("CB Geçtiniz\n"); }
            else if (ort >= 74 && ort <= 80) { Console.Write("Ortalamanız={0}", ort); Console.Write("BB Geçtiniz\n"); }
            else if (ort >= 81 && ort <= 87) { Console.Write("Ortalamanız={0}", ort); Console.Write("BA Geçtiniz\n"); }
            else if (ort >= 88 && ort <= 100) Console.Write("Ortalamanız={0}", ort); Console.Write("AA Geçtiniz\n");
            Console.ReadKey();
        }
        
    }
}