using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kahve = new List<string>();
            string isim;
            int sayi = 1;
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Kahve {sayi} :");
                isim= Console.ReadLine();
                kahve.Add(isim);
                sayi++;
                
            }
            Console.WriteLine("Girilen Kahve İsimleri:");
            foreach(string s in kahve)
            {
                Console.WriteLine(s);
            }
        }
    }
}