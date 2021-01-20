using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteriler1 = new Musteri();
            musteriler1.Id = 15;
            musteriler1.Ad = "Emre";
            musteriler1.Soyadi = "Candan";

            Musteri musteriler2 = new Musteri();
            musteriler2.Id = 20;
            musteriler2.Ad = "Ayşegül";
            musteriler2.Soyadi = "Akman";

            Musteri[] musteriler = new Musteri[] {musteriler1, musteriler2};

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.Id+ " " +Musteri.Ad+ " " +Musteri.Soyadi);
            }

            Console.WriteLine("-----------------------------");

            MusteriManager musterimanager1 = new MusteriManager();
            musterimanager1.MusteriEkle(musteriler1);
            musterimanager1.MusteriEkle(musteriler2);

            Console.WriteLine("****************************");

            MusteriManager musterimanager2 = new MusteriManager();
            musterimanager2.MusteriSilme(musteriler1);
            musterimanager2.MusteriSilme(musteriler2);

        }
    }
}
