﻿

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu - alias


            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları botonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


        }
    }
}

