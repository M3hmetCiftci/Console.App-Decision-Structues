using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_decision_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<---------------------------------- if - else if - else--------------------------------
            //int S1;
            //Console.Write("S1: ");
            //S1=Convert.ToInt32(Console.ReadLine());
            //if (S1==25)
            //{
            //    Console.WriteLine("Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Stayed");
            //}


            //<------------------------------Average-----------------------

            //int S1, S2,Avarage;
            //Console.Write("S1:");
            //S1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("S2:");
            //S2 = Convert.ToInt32(Console.ReadLine());
            //Avarage=(S1+S2)/2;
            //Console.WriteLine("Average: "+Avarage);
            //if (Avarage >= 50)
            //{
            //    Console.WriteLine("Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Flunk");
            //}






            //<---------------------------------- if - else if - else--------------------------------
            //int s1, s2;
            //    Console.Write("S1: ");
            //    s1=Convert.ToInt32(Console.ReadLine());
            //    Console.Write("S2: ");
            //    s2 = Convert.ToInt32(Console.ReadLine());

            //    if (s1 < s2)
            //    {
            //        Console.WriteLine("is less than");
            //    }
            //    else if (s1 > s2) 
            //    {
            //        Console.WriteLine("is greater than");
            //    }
            //    else {
            //        Console.WriteLine("equals "); 
            //    }

            //<---------------------------------- if multiple blocks--------------------------------

            //int s1, s2, s3, Average;
            //Console.Write("S1: ");
            //s1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("S2: ");
            //s2=Convert.ToInt32(Console.ReadLine());
            //Console.Write("S3: ");
            //s3=Convert.ToInt32(Console.ReadLine());
            //Average=(s1+s2+s3)/3;
            //Console.WriteLine("Average: " + Average);
            //if (Average <= 50)
            //{
            //    Console.WriteLine("flunk");
            //}
            //if (Average >= 51 & Average <= 65)
            //{
            //    Console.WriteLine("Good");
            //}
            //if (Average>=66&Average<=85)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //if (Average>=100)
            //{
            //    Console.WriteLine("Great");
            //}



            //<---------------------------------- & --------------------------------

            //string Password, UserName;
            //Console.Write("UserName: ");
            //UserName = Console.ReadLine();         
            //Console.Write("Password: ");
            //Password=Console.ReadLine();
            //if (UserName=="Admin"&Password=="123456")
            //{
            //    Console.WriteLine("Hello");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Password");
            //}

            //<---------------------------------- != --------------------------------

            //int Word;
            //Console.Write("Word: ");
            //Word=Convert.ToChar(Console.ReadLine());
            //if (Word!='a')
            //{
            //    Console.WriteLine("flunk");
            //}

            //else
            //{
            //   Console.WriteLine("a");
            //}

            //<---------------------------------- || --------------------------------

            //Console.WriteLine("Question");
            //Console.WriteLine("---------------------");
            //int Question = 1;
            //string Reply;
            //if (Question == 1)
            //{
            //    Console.WriteLine("Türkiye'nin Başkenti Neresidir");
            //    Console.WriteLine("A) Ankara");
            //    Console.WriteLine("B) İstanbul");
            //    Console.WriteLine("C) Gaziantep");
            //    Console.WriteLine("D) İzmir");
            //    Console.WriteLine();
            //    Console.Write("Cevabınız: ");
            //    Reply= Console.ReadLine();
            //    if (Reply=="b"|| Reply=="B")
            //    {
            //        Console.WriteLine("Cevap Doğru: Toplam Puanınız 50");
            //        Question = Question + 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cevap Yanlış : Toplam puanınız 0");
            //    }
            //}
            //if (Question==2)
            //{
            //    Console.WriteLine("Soru2");
            //    Console.WriteLine();
            //    Console.WriteLine("Cumhuriyet kaç yılında ilan edildi");
            //    Console.WriteLine("A) 1923");
            //    Console.WriteLine("B) 1924");
            //    Console.WriteLine("C) 1925");
            //    Console.WriteLine("D) 1926");
            //    Console.Write("Cevabınız: ");
            //    Reply=Console.ReadLine();
            //    if (Reply == "a" || Reply == "A") 
            //    {
            //        Console.WriteLine("Cevap Doğru : Toplam Puanınız 100");
            //    }
            //    else
            //    {
            //       Console.WriteLine("Cevap Yanlış: toplam puanınız 50 ");
            //    }
            //}
            //Console.Read();



            //<----------------------------------Switch Case String --------------------------------
            //byte plaka;
            //Console.WriteLine("Plakayı giriniz: ");
            //plaka=byte.Parse(Console.ReadLine());
            //switch (plaka)
            //{
            //    case 1:Console.Write("Adana"); break;
            //    case 2:Console.Write("Afyon");break;
            //    case 3:Console.Write("Ardahan"); break;
            //    default:Console.WriteLine("Geçerli bir şehir girmediniz");break;
            //}
            //Console.Read();

            //Console.WriteLine("Mevsimler");
            //Console.Write("");
            //string mevsim;
            //Console.Write("Lütfen Mevsim Giriniz: ");
            //mevsim = Console.ReadLine();
            //switch(mevsim)
            //{
            //    case "Yaz":Console.Write("Haziran-temmuz ağutos");break;
            //    case "İlkbahar":Console.Write("Mart-Nisan-Mayıs");break;
            //    case "Sonbahar":Console.Write("Eylül-Ekim-Kasım");break;
            //    case "Kış":Console.Write("Aralık-Ocak-Şubat");break;
            //    default:Console.WriteLine("Hatalı mevsim girişi"); break;

            //}
            //Console.Read();
        }
    }
}
