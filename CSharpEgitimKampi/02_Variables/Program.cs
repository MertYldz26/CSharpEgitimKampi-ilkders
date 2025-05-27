using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkeni 
            //double number;
            //number = 2.26;
            //Console.WriteLine(number);

            //Console.WriteLine(" ***** Fiyat Listesi ****");
            //Console.WriteLine();

            //Double applePrice,orangePrice,StrawberryPrice;
            //applePrice = 12.50;
            //orangePrice = 16.75;
            //StrawberryPrice = 26;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + StrawberryPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //Double AppleGram,OrangeGram,StrawberryGram;
            //AppleGram = 1.350;
            //OrangeGram = 0.925;
            //StrawberryGram = 0.500;
            //Double AppleTotalPrice = AppleGram * applePrice;
            //Double OrangeTotalPrice = OrangeGram * orangePrice;
            //Double StrawberryTotalPrice = StrawberryPrice*StrawberryGram;
            //Console.WriteLine("Alınan Ürün : Elma -  Birim Fiyatı: " + applePrice+" Gramaj: "+AppleGram+" Toplam Tutar: "+ AppleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal -  Birim Fiyatı: " + orangePrice + " Gramaj: " + OrangeGram + " Toplam Tutar: " + OrangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Elma -  Birim Fiyatı: " + StrawberryPrice + " Gramaj: " + StrawberryGram + " Toplam Tutar: " + StrawberryTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();
            //double totalPrice = AppleTotalPrice + OrangeTotalPrice + StrawberryTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı: "+ totalPrice);

            #endregion

            #region char değişkeni

            //ABCDEFG


            //char symbol = 'm';
            //Console.WriteLine(symbol);


            #endregion

            #region klavyeden veri alma

            //Console.WriteLine("****** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName,passengerSurname, district, city,passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //district = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //city = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: - "+passengerIdentityNumber+" Yolcu Ad Soyad: "+passengerName+" "+passengerSurname+" "+district+"/"+city); 


            #endregion

            #region Klavyeden Tam sayı girişleri ve dönüşümler

            //int ShoesPrice, ComputerPrice, TVPrice, ChairPrice;
            //ShoesPrice = 1000;
            //ComputerPrice = 30000;
            //ChairPrice = 1500;
            //TVPrice = 20000;

            //int ShoesCount, ComputerCount, TVCount, ChairCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısınız Giriniz: ");
            //ShoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısınız Giriniz: ");
            //ComputerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Tv Sayısınız Giriniz: ");
            //TVCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Sandalye Sayısınız Giriniz: ");
            //ChairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();


            //int totalPrice = ShoesCount*ShoesPrice+ ComputerCount * ComputerPrice + TVCount * TVPrice + ChairCount * ChairPrice;
            //Console.Write("Toplam Alışveriş Tutarınız: " + totalPrice + " TL");
            #endregion


            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result); 
            #endregion

            #region Klavyeden karakter girişleri


            //Char Gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K): ");
            //Gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet " + Gender);
            #endregion
            Console.Read();
        }
    }
}
