/**********************************************************************************
**                                        SAKARYA ÜNİVERSİTESİ
**                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                     2016-2017 BAHAR DÖNEMİ
**
**                          ÖDEV NUMARASI..........:1
**                          ÖĞRENCİ ADI............: Melikhan Muhammed Hoşdoğdu 
**                          ÖĞRENCİ NUMARASI.......: G 161210039
**                          DERSİN ALINDIĞI GRUP...:2B
************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g161210039
{
    class Program
    {
        static void Main(string[] args)
        {
            //global degiskenler tanımlanıyor
            #region degiskenler tanımlanıyor
            short satir;
            bool tercih = false; //döngu degeri atanıyor degeimezse döngu dönmiyecek
            int secim;
            #endregion
            //ana do while dongusu
            #region ana dongu
            do              //do while döngü sü baslıyor 
            {
                #region menu
                Console.Clear();
                Console.WriteLine("..::İşlemler::..");
                Console.WriteLine("1-Matris işlemleri");
                Console.WriteLine("2-String İşlemler");
                Console.WriteLine("3-Çıkış");
                Console.Write("Seçiniz:");
                secim = Convert.ToInt16(Console.ReadLine());            //kullanicidan secim aliniyor
                #endregion


                switch (secim)
                {
                    //matris islemleri
                    #region matris islemleri
                    case 1:                                            
                        Console.Clear();                                          //matris islemleri  basliyor
                        Console.WriteLine("..::Matris işlemleri::..");
                        Console.Write("Matrisin satır sayısını girin (1-10 arası olmalı):");
                        satir = Convert.ToInt16(Console.ReadLine());         //kullanicidan satir sayisi aliniyor
                        while (satir < 0 || satir > 10)             //sayinin 0 ile 10 arasi olmasi saglaniyor
                        {
                            Console.Write("1-10 Arası olmalı Tekrar sayi girin:");
                            satir = Convert.ToInt16(Console.ReadLine());
                        }
                        int[,] matris = new int[satir, satir];  //matris icin gerekli olan dizi tanimlandi
                        int[] deger_tutucu_matris = new int[satir * satir];   //matrisin degerleri bu diziye ataniyor en buyuk sayiyi bulmak icin
                        int m = 0;//i ve j degerleri arttilca artacak m degeri 
                        for (short i = 0; i < satir; i++)  //for icinde for kullanarak kullaniciden matrisin degerleri aliniyor
                        {                                                 //                      
                            for (short j = 0; j < satir; j++)
                            {
                                Console.Write("Matrisin {0} x {1} ::", i + 1, j + 1);
                                matris[i, j] = Convert.ToInt16(Console.ReadLine());
                                deger_tutucu_matris[m] = matris[i, j];  //alinan degerler deger tutucu matrise ataniyor daha sonra 
                                m++;                                      //buyuk kucuk karsilastirilmasi yapilacak                           
                            }

                        }

                        //matris değeri sıralanıyor
                        for (short x = 0; x < satir; x++)           //for icinde for kullanarak 
                        {
                            for (short y = 0; y < satir; y++)
                            {
                                Console.Write(matris[x, y] + " ");      //ekrana yazdiriliyor

                            }
                            Console.WriteLine();            //satir bittikce assagi iniyor

                        }
                        //matrisin içindeki seçeneklere geçildi
                        short matris_secim;           //kullanici matrisin icindeki secenekleri seciyor
                        Console.WriteLine("1-Satır en büyük");
                        Console.WriteLine("2-Satır toplam ");
                        Console.Write("Seçiminiz::");
                        int satir_en_buyuk = 0, h = 0;
                        matris_secim = Convert.ToInt16(Console.ReadLine());     //matris secim convert ediliyor
                        #region matris secim 1
                        if (matris_secim == 1)              //1.seceneke gecildi
                        {

                            for (short z = 0; z < satir; z++)       //for icinde for kullanilarak tum degerler 
                            {

                                for (short t = 0; t < satir; t++)       //degerlendiriliyor
                                {

                                    if (deger_tutucu_matris[h] > satir_en_buyuk)        //en buyuk sayi araniyor
                                    {

                                        satir_en_buyuk = deger_tutucu_matris[h];        //denenen en buyuk sayi degiskene atandi
                                        deger_tutucu_matris[h]++;
                                    }
                                    h++;            //matrisin alt satirina geciliyor

                                }
                                Console.Write(satir_en_buyuk + " ");
                                satir_en_buyuk = 0;
                            }
                            tercih = true;//döndü basa sarıyor
                            Console.ReadKey();

                        }
                        #endregion
                        #region matris secim 2
                        else if (matris_secim == 2)       //2.seceneke gecildi
                        {
                            //matris değeri sıralanıyor 
                            int[] satirToplamlari = new int[satir];  //Her satır sayısı toplamını dizi içinde kendi değişkenine koyacagız.                        
                            int toplam = 0;//Genel toplam; 0'dan başlayacak//Her satır için                        
                            for (short x = 0; x < satir; x++)
                            {
                                satirToplamlari[x] = 0;//... o satırın toplamı 0'dan başlar.                            
                                for (short y = 0; y < satir; y++)//Her sütün için...                            
                                {
                                    satirToplamlari[x] += matris[x, y];//Sonra bulunduğumuz satır toplamına ekleriz.                          
                                }
                                toplam += satir;//Genel toplama tek tek sütunları eklemek gereksiz, o satırın toplamını ekleyelim yeter.


                            }
                            Console.Write("Sonuc::");
                            for (short x = 0; x < satir; x++) Console.Write(satirToplamlari[x] + " ");
                            Console.WriteLine();
                            tercih = true;//döngu basa sarıyor
                            Console.ReadKey();
                        }
                        #endregion
                        #region diğer
                        else
                        {
                            Console.Write("Seciminiz yanlis:!!");
                            Console.ReadKey();
                            tercih = true;//döngu basa sarıyor
                        }
                        #endregion

                        break;
                    #endregion


                    //burada string ifadelerine geçiliyor
                    #region syring islemleri
                    case 2:
                        Console.Clear();
                        Console.WriteLine("..::String İşlemleri::..");
                        Console.Write("İşlem yapılacak kelimeyi giriniz:");
                        string kelime = Console.ReadLine();
                        if (kelime.Length < 3)
                        {
                            //Kelime minimum 3 harfli olmalı ki aynı harfi iki kez bulabilelim, aralarında da en az 1 harf olsun.
                            Console.WriteLine("Kelime en az üç harfli olmalıdır.");
                            Console.ReadKey();
                            return;
                        }
                        Console.Write("İstenen harf:");
                        string harf = Console.ReadLine();       //kullanıcıdan harf alınıf
                        if (harf.Length != 1)
                        {
                            Console.WriteLine("Harf tek kelimeden oluşmalıdır.");
                            tercih = true;//döngu basa sarıyor
                            Console.ReadKey();
                            return;
                        }
                        int baslangic = kelime.IndexOf(harf);
                        if (baslangic < 0)
                        {
                            Console.WriteLine("İstenen harf kelime içinde mevcut değildir.");
                            tercih = true;//döngu basa sarıyor
                            Console.ReadKey();
                            return;

                        }
                        int bitis = kelime.LastIndexOf(harf);
                        if (bitis == baslangic)
                        {
                            Console.WriteLine("Harf kelime içinde en az iki kez girmeli.");
                            tercih = true;//döngu basa sarıyor
                            Console.ReadKey();
                            return;
                        }
                        //İlk bulunuşundan bir harf sonrasından keseriz sonuç için, son bulunuşu
                        //da dahil etmediğimizden ikisinin farkından da bir çıkarırız.
                        Console.WriteLine("1-Ara Metni Tersten Yaz:");
                        Console.WriteLine("2-Ara Metni Tekrarlı Yaz:");
                        Console.Write("Seçiminiz:");
                        string sonuc = kelime.Substring(baslangic + 1, bitis - baslangic - 1);
                        switch (Console.ReadLine())
                        {
                            case "1":
                                sonuc = new string(sonuc.ToCharArray().Reverse().ToArray());//aradaki degeri ters cevirdik
                                Console.WriteLine(sonuc);
                                tercih = true;//döngu basa sarıyor
                                Console.Write("Devam etmek için tıklayınız");
                                break;
                            case "2":
                                for (Byte i = 0; i < 5; i++) Console.WriteLine(sonuc);//aradaki deger 5 kere yazildi
                                tercih = true;//döngu basa sarıyor
                                Console.Write("Devam etmek için tıklayınız");
                                break;
                            default:
                                Console.WriteLine("Seçiminiz yanlış 1 veya 2 olmalıydı :(");//kullanici yonlendiriliyor
                                tercih = true;//döngu basa sarıyor

                                break;
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                   // programdan cıkılıyor
                    #region cıkıs
                    case 3:   
                    
                            Console.WriteLine("Programdan çıkış yaptınız:");
                            Console.Write("Devam etmek için tıklayınız");
                            Console.ReadKey();
                        break;
                    #endregion
                    // hatalı deger ayıklanıp tekrar döndürülüyor
                    #region
                    default:
                        Console.WriteLine("Hatalı secim");
                        Console.Write("Devam etmek için tıklayınız");
                        Console.ReadKey();
                        tercih = true;//döngu basa sarıyor
                                      // }
                        break;
                        #endregion
                }

            } while (tercih) ;
            #endregion           
        }
    }
}



