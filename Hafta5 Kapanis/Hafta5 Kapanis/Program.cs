using Hafta5_Kapanis;

namespace Hafta5_Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            string cevap;
            List<Araba> arabalar = new List<Araba>();

            while (true)
            {         
                Console.WriteLine("Araba üretmek istiyor musunuz? (E/H)");
                cevap = Console.ReadLine().ToLower();
                

                if (cevap == "h")
                    break;
                else if(cevap != "e")
                {
                    Console.WriteLine("Geçersiz cevap. ");
                    continue;
                }
                yeniden:
                Araba araba = new Araba();
                Console.Write("Seri Numarası: ");
                araba.serinumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                araba.marka = Console.ReadLine();

                Console.Write("Model: ");
                araba.model = Console.ReadLine();

                Console.Write("Renk: ");
                araba.renk = Console.ReadLine();

                kapisayisiGir:
                Console.Write("Kapı Sayısı: ");
                try
                {
                    araba.kapisayisi = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz, lütfen sayısal bir değer giriniz.");
                    goto kapisayisiGir;
                }
                arabalar.Add(araba);
                Console.WriteLine("Araba başarıyla üretildi!");
                Console.Write("Başka bir araba üretmek istiyor musunuz? (E/H): ");

                cevap = Console.ReadLine().ToLower();
                if (cevap == "h")
                    break;
                else if (cevap != "e")
                {
                    Console.WriteLine("Geçersiz cevap. ");
                    continue;
                }
                else if(cevap == "e")
                    goto yeniden;
                
            }
            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (var araba in arabalar)
            {
                Console.WriteLine($"Seri Numarası: {araba.serinumarasi}, Marka: {araba.marka}");
            }

            Console.WriteLine("Program sona erdi. İyi günler!");
        }
    }
}