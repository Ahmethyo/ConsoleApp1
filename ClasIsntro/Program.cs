

namespace ClasIsntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ahmet";
            int yas = 16;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Ahmet";
            kurs1.IzlenmeOrani = 61;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 62;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Ahmet";
            kurs3.IzlenmeOrani = 63;




            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen)

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kura in kurslar)
            {
                Console.WriteLine(Kurs.kursAdi + " : "+ kura.Egitmen);
            }



        }

        class Kurs
        {
            public string kursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
