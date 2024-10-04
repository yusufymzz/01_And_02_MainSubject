using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Yusuf";
            //Console.Write(name);

            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail,district, city;

            //passengerName = "Ali";
            //passengerSurname = "Çınar";
            //passengerPhone = "+90 500 400 30 20";
            //passengerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + passengerName + "" + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);

            //Console.WriteLine();

            //passengerName = "Yusuf";
            //passengerSurname = "Yılmaz";
            //passengerPhone = "+90 500 400 90 80";
            //passengerEmail = "ysf@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";


            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + passengerName + "" + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);















            #endregion

            #region İnt Değişkenler

            //int 
            //int number = 36;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***** Restoran Menü Fiyatları *****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            //Console.WriteLine("-----Kola Fiyatı " + cokePrice + "TL");
            //Console.WriteLine("-----Su Fiyatı" + waterPrice + "TL");
            //Console.WriteLine("-----Kızartma Fiyatı " + friesPrice + "TL");
            //Console.WriteLine("-----Pizaa Fiyatı " + pizzaPrice + "TL");
            //Console.WriteLine("-----Limonata Fiyatı" + lemonadePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("***** Restoran Menü Fiyatları *****");


            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice = 0;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;



            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;




            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");

            //Console.WriteLine();

            //int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");















            #endregion

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.50;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.87;

            //Console.WriteLine("-----Elma Birim Fiyatı; "+ applePrice +  " TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı" + orangePrice +  " TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı; " + strawberryPrice +  " TL");
            //Console.WriteLine("-----Patates Birim Fiyatı; " + potatoPrice +  " TL");
            //Console.WriteLine("-----Domates Birim Fiyatı; " + tomatoPrice +  "  TL");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice ;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " Gramaj - " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " Gramaj - " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " Gramaj - " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + tomatoPrice + " Gramaj - " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + potatoPrice + " Gramaj - " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine();    

            //double shoppingTotalPrice= appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışverişin Toplam Tutarı: " + shoppingTotalPrice + " TL");












            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 19:00'DA
            //" '

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);










            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + passengerDistrict + "/" + passengerCity + passengerAge);













            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC21D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000; 

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adedini Giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Adedini Giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Adedini Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Adedini Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz Gereken Toplam Ücret: " + totalPrice + " TL");



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sınav Notunu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.Sınav Notunu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);











            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz: ";
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender;








            #endregion


            Console.Read();











        }
    }
}
    