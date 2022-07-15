using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Alex";
            musteri1.Surname = "sj";

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.musteriEkle(musteri1);
            musteriManager.musteriListele(musteri1);
            musteriManager.musteriSil(musteri1);
        }
    }
}
