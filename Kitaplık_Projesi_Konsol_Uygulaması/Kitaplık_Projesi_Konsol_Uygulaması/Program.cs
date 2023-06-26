using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplık_Projesi_Konsol_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            string secim;
            Console.WriteLine("************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("  **    Türkçe Kitaplar Kategorisi        **  Yabancı Kitaplar Kategorisi          **");
            Console.WriteLine();
            Console.WriteLine("  **    1-Çalıkuşu: Reşat Nuri            **  7-Tuna Kılavuzu: Jules Verne        **");
            Console.WriteLine();
            Console.WriteLine("  **    2-Yaban: Yakup Kadri              **  8-Bir Kuzey Macerası: Jack London   **");
            Console.WriteLine();
            Console.WriteLine("  **    3-Sinekli Bakkal: Halide Edip     **  9-Altıncı Koğuş: Anton Çehov        **");
            Console.WriteLine();
            Console.WriteLine("  **    4-Tehlikeli Oyunlar: Oğuz Atay    **  10-Kumarbaz: Dostoyevski            **");
            Console.WriteLine();
            Console.WriteLine("  **    5-Geçtiğim Günlerden: H.Yücel     **  11-İki Şehrin Hikayesi: C.Dickens   **");
            Console.WriteLine();
            Console.WriteLine("  **    6-Kuyucaklı Yusuf: S.Ali          **  12-Vişne Bahçesi: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1- Fiyat Sorgulama ");
            Console.WriteLine("2- Yeni Okur Kaydı ");
            Console.WriteLine("3- Günün Kitabı ");
            Console.WriteLine("4- Kitap Arşivi ");
            Console.WriteLine("5- Yeni Kitap Satın Al ");
            Console.WriteLine("6- Oyun ");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemi Seçin: ");

            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Kitabın Numarasını Giriniz: ");
                string numara;
                numara = Console.ReadLine();
                Console.WriteLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu 12 TL"); break;
                    case "2": Console.Write("Yaban 21 TL"); break;
                    case "3": Console.Write("Sinekli Bakkal 2 TL"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar 14 TL"); break;
                    case "5": Console.Write("Geçtiği Günlerden 15"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf 19 TL"); break;
                    case "7": Console.Write("Tuna Kılavuzu 35 TL"); break;
                    case "8": Console.Write("Bir Kuzey Macerası 55 TL"); break;
                    case "9": Console.Write("Altıncı Koğuş 25 TL"); break;
                    case "10": Console.Write("Kumarbaz 62 TL"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi 45 TL"); break;
                    case "12": Console.Write("Vişne Bahçesi 30 TL"); break;
                    default: Console.Write("Hatalı Tuşlama"); break;
                }

            }
            if (islem == '2')
            {
                Console.WriteLine();
                Console.Write("Lütfen Bilgilerinizi Giriniz");
                Console.WriteLine();
                string ad, soyad, uni;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversite: ");
                uni = Console.ReadLine();
                Console.WriteLine();
                Console.Write(ad + " " + soyad + " " + uni);

                string dosya = @"C:\Users\eralt\OneDrive\Masaüstü\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Ad Soyad: " + ad + " " + soyad + " " + "Üniversite: " + uni);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                Console.WriteLine("****** Bugünün Kitabı: Kuyucaklı Yusuf ****** ");
                Console.WriteLine();
                Console.WriteLine("**********************************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\eralt\OneDrive\Masaüstü\arsiv.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("**********************************************");

            }
            if (islem == '5')
            {
                Console.WriteLine("Alacağınız Kitabın Numarasını Tuşlayın ");
                secim = Console.ReadLine();
                for (int i = 1; i <= 100; i++)
                {
                    if (secim == "1")
                    {
                        toplam += 12;
                    }
                    else if (secim == "2")
                    {
                        toplam += 21;
                    }
                    else if (secim == "3")
                    {
                        toplam += 2;
                    }
                    else if (secim == "4")
                    {
                        toplam += 14;
                    }
                    else if (secim == "5")
                    {
                        toplam += 15;
                    }
                    else if (secim == "6")
                    {
                        toplam += 19;
                    }
                    else if (secim == "7")
                    {
                        toplam += 35;
                    }
                    else if (secim == "8")
                    {
                        toplam += 55;
                    }
                    else if (secim == "9")
                    {
                        toplam += 25;
                    }
                    else if (secim == "10")
                    {
                        toplam += 62;
                    }
                    else if (secim == "11")
                    {
                        toplam += 45;
                    }
                    else if (secim == "12")
                    {
                        toplam += 30;
                    }
                    else
                        Console.WriteLine("Hatalı Tuşlama");
                    Console.WriteLine();
                    Console.WriteLine("Kitap Almaya Devam Etmek İstemiyorsanız Hayır/hayır Yazınız ");
                    string cevap = Console.ReadLine();
                    if (cevap == "Hayır" || cevap == "hayır") break;
                }
                Console.WriteLine("Toplam Tutar: " + toplam);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random r = new Random();
                int sayi = r.Next(0, 100);
                while (sayi != tahmin)
                {
                    Console.Write("Tahminizi Giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                    }
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha Büyük Bir Sayı Giriniz");

                    }
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("Bildiniz");

                    }


                }





            }
            Console.Read();
        }
    }
}
