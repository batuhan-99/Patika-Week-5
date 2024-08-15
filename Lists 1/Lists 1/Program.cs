using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Bülent Ersoy");
            isimler.Add("Ajda Pekkan");
            isimler.Add("Ebru Gündeş");
            isimler.Add("Haadise");
            isimler.Add("Hande yener");
            isimler.Add("Tarkan");
            isimler.Add("Funda Arar");
            isimler.Add("Demet Akalin");
            int sayi=1;
            foreach(string isim in isimler)
            {
                Console.Write($"{sayi} - ");
                Console.WriteLine($"{isim}");
                sayi++;
            }
        }
    }
}