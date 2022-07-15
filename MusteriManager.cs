using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri name)
        {
            Console.WriteLine(name.Name+"      eklendi");
            Console.WriteLine("-------------------------------------------------");

        }
        public void musteriSil(Musteri name)
        {
            Console.WriteLine(name.Name + "      silindi");
            Console.WriteLine("-------------------------------------------------");
        }
        public void musteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listele : " + musteri.Name + " " + musteri.Surname);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
