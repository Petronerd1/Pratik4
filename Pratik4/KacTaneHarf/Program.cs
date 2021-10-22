using System;

namespace KacTaneHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Telepati Yazılım";
            text = text.ToLower();
            string character = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";
            int[] count = new int[character.Length];
            for (int i = 0; i<text.Length; i++)
            {
                int index = character.IndexOf(text[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for(int i = 0;i<count.Length;i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(character[i]+" "+count[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
