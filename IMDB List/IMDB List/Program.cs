using IMDB_List;

namespace IMDB_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> filmler = new List<Film>();
            string devamcevabi;

            while (true)
            {
                Console.Write("Film adı:");
                string isim = Console.ReadLine();

                Console.Write("IMDB puanı:");
                double puan = Convert.ToDouble(Console.ReadLine());

                Film yenifilm = new Film(isim, puan);
                filmler.Add(yenifilm);
                Console.Write("Yeni bir film eklemek istiyor musunuz? (Evet/Hayır): ");
                devamcevabi = Console.ReadLine().ToLower();
                if (devamcevabi == "hayır")
                    break;

            }
            Console.WriteLine("Filmler:");
            foreach (Film filmadi in filmler)
            {
                Console.WriteLine(filmadi.ismi);
            }
            Console.WriteLine("Puanı 4 ile 9 arasında olanlar");
            foreach (Film filmadi in filmler)
            {
                if (filmadi.puan >= 4.0 && filmadi.puan <= 9.0)
                    Console.WriteLine(filmadi.ismi);
            }
            Console.WriteLine("İsmi A harfi ile başlayan filmler:");
            foreach (Film filmadi in filmler)
            {
                if (filmadi.ismi.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"İsim: {filmadi.ismi}, IMDB Puanı: {filmadi.puan}");
                }
            }

        }
    }
}