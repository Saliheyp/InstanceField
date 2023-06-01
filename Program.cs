using System;

namespace sinif_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class sinifAdi
            // {
            //     [Erişim belirleyici] [Veri Tipi] ÖzellikAdi;
            //     [Erişim belirleyici] [Geri Dönüş Tipi] MethodAdi([Parametre Listesi])
            //     {
            //         //Method Komutları
            //     }
            // }

            //Erişim belirleyiciler
            // * Public (Her yerden erişilebilir)
            // * Private (Sadece tanımlandığı sınıf içerisinden erişilebilir.)
            // * Internal (Sadece bulunduğu proje içerisiniden erişilebilir)
            // * Protected (Sadece bulunduğu sınıfta veya O sınıftan kalıtım(miras) alan sınıflar içerisinden)
            Calisan calisan1 = new Calisan();
            calisan1.ad ="Ayşe";
            calisan1.soyad="Kara";
            calisan1.No=23425634;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("**********");

            Calisan calisan2 = new Calisan();
            calisan2.ad ="Deniz";
            calisan2.soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string ad;
        public string soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);




        }

    }
}