using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;
            Console.WriteLine("Lütfen bir sayi giriniz:");
            while (devam)
            {      
                try
                {        
                double sayi = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Pow(sayi, 2));
                devam = false;
                }            
                catch ( FormatException ex)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            
                }
            }
        }
    }
}