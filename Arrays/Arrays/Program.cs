using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
                numbers[i] = rnd.Next(1, 100);

            Console.WriteLine("Dizideki elemanlar:");
            foreach (int i in numbers)
                Console.WriteLine(i);

            int[] newnumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
                newnumbers[i] = numbers[i];

            Console.WriteLine("Yeni sayiyi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            newnumbers[10] = sayi;
            Array.Sort(newnumbers);
            Array.Reverse(newnumbers);

            Console.WriteLine("Küçükten büyüğe oluşturulmuş dizi:");
            for (int i = 0; i < newnumbers.Length; i++)
                Console.WriteLine(newnumbers[i]);
        }
    }
}