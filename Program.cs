using System.ComponentModel.Design.Serialization;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi girin:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kac kere yazılsın?");
            //int kadar = Convert.ToInt32(Console.ReadLine()); 
            //for (int i = 1; i <= kadar; i++)
            //{
            //   // Console.WriteLine(i + "." + isim);
            //    Console.WriteLine($"{i + 1}.{isim}");
            //}

            //try
            //{
            //    Console.WriteLine("Başlangıç değeri girin:");
            //    int basla = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Bitiş değeri girin:");
            //    int bitir = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Çift sayılar mı yoksa tek sayılar  mı?");
            //    string cevap = Console.ReadLine();
            //    int sonuc = 0;
            //    if (basla > bitir)
            //    {
            //        int temp = basla;
            //        basla = bitir;
            //        bitir = temp;
            //    }

            //    for (int i = basla; i <= bitir; i++)
            //    {
            //        if (i % 2 == (cevap == "tek" ? 1 : 0))
            //        {
            //            Console.WriteLine(i);
            //            //sonuc = sonuc + i;
            //            sonuc += i;
            //        }

            //    }
            //    Console.WriteLine(sonuc);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayı girin");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata oluştu");

            //}

            //Console.WriteLine("Taban Giriniz:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üs Giriniz:");
            //int us = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İşlemin Sonucu");
            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc *= taban;
            //}

            //Console.WriteLine(sonuc);

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //   sonuc *= i;
            //}

            //Console.WriteLine($"Girilen sayının faktöriyeli:{sonuc}");


            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 2; i <= (sayi/2); i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break; //döngüden çıkar.
            //    }
            //}

            //Console.WriteLine(sayac == 0? "Asal" : "Asal değil");


            //sonsuz döngü
            //for (; ; ) 
            //{
            //    Console.WriteLine("Kullanıcı adı girin:");
            //    string isim = Console.ReadLine();
            //    Console.WriteLine("Şifre girin:");
            //    string sifre = Console.ReadLine();
            //    if (isim =="ceren" && sifre == "123" )
            //    {
            //        Console.WriteLine("Giriş başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.Clear(); //temizler ekranı
            //        Console.WriteLine("Tekrar deneyin");
            //    }

            //}

            //int max = int.MinValue;
            //int toplam = 0;
            //int ort ;
            //int sayac = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Sayı girin:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi > max)
            //    {
            //        max = sayi;


            //    }
            //    sayac++;
            //    toplam += sayi;
            //    ort = toplam / sayac;
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "h")
            //    {
            //        break;

            //    }
            //}
            //Console.WriteLine($"Girdiğiniz en büyük değer:{max} \n Sayıların toplamı:{toplam} \n Girilen sayıların ortalaması:{ort}");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j} \t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("enter row count:");
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter column count:");
            //int column = int.Parse(Console.ReadLine());
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //abcd=4*dcba
            //abcd?
            //bool sonuc=false;
            //for (int a = 1; a < 9; a++)
            //{
            //    for (int b = 0; b < 9; b++)
            //    {
            //        for (int c = 0; c < 9; c++)
            //        {
            //            for (int d = 0; d < 9; d++)
            //            {
            //                if (1000 * a + 100 * b + 10 * c + d == 4 * (1000 * d + 100 * c + 10 * b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    sonuc = true;
            //                    break;
            //                }
            //            }
            //            if (sonuc)
            //            {
            //                break;
            //            }
            //        }
            //        if (sonuc)
            //        {
            //            break;
            //        }
            //    }
            //    if (sonuc)
            //    {
            //        break;
            //    }
            //}

            //Hipotenüs uzunluğu 100 birime kadar olan dik üçgenleri yazdırınız?
            //a2+b2=c2

            //for (int i = 1; i < 100; i++)
            //{
            //    for(int j = 1; j < 100; j++)
            //    {
            //        for (int k = 0; k < 100; k++)
            //        {
            //            if ((i * i) + (j * j) == k * k) 
            //            {
            //                Console.WriteLine($"{i} , {j} , {k}");
            //            }
            //        }
            //    }
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Enter starting number:");
            //    int start = int.Parse(Console.ReadLine());
            //    if (start > 2) 
            //    {
            //        break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("You can not enter a number lower than 2");
            //    }
            //}
            //Console.WriteLine("Enter end number:");
            //int end=int.Parse(Console.ReadLine());
            //for (int i = start; i < end; i++) 
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i / 2); j++) 
            //    {
            //        if (i % j == 0) 
            //        {
            //            count++; //sayaç
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count > 0 ? $"{i}-Is not prime" : $"{i}-prime"); //prime : asal
            //}

            //int count = 0;
            //while (count < 5) 
            //{
            //    Console.WriteLine("Gazi");
            //    count++;
            //}

            //int max = int.MinValue;
            //int toplam = 0;
            //int ort;
            //int sayac = 0;
            //while(true)
            //{
            //    Console.WriteLine("Enter a number");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi > max)
            //    {
            //        max = sayi;


            //    }
            //    sayac++;
            //    toplam += sayi;
            //    ort = toplam / sayac;
            //    Console.WriteLine("Would you like to enter another number?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "h")
            //    {
            //        break;

            //    } //if, for, while içine tek satır yazacaksak blok {} açmaya gerek yok.

            //}
            //Console.WriteLine($"Girdiğiniz en büyük değer:{max} \n Sayıların toplamı:{toplam} \n Girilen sayıların ortalaması:{ort}");

            //do
            //{
            //    Console.WriteLine("Gazi");
            //} while (false);

            //int sum = 0;
            //string answer;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    Console.WriteLine("Would you like to enter another number?");
            //    answer = Console.ReadLine();
            //} while (answer == "y"); 
            // Console.WriteLine(sum);

            //for (int i = 0; i < 10; i++)
            //{
            //    Random rnd = new Random();
            //    int number = rnd.Next(33, 127);
            //    Console.Write((char)number);//rasgele karakter atar.
            //}


            //while, do while, for döngüleri

            //Random rnd = new Random();
            //int number = rnd.Next(1, 100);
            //int deneme=3;
            //for (; ; )
            //{
            //    Console.WriteLine("Tahmin ediniz:");
            //    int sayi = int.Parse(Console.ReadLine());

            //    if (sayi == number)
            //    {
            //        Console.WriteLine("Tebrikler!");
            //        break;
            //    }
            //    else if(sayi != number) 
            //    {
            //        deneme--;

            //    }
            //    if (deneme == 0)
            //    {
            //        Console.WriteLine("Hakkınız bitti :(");
            //    }
            //}

            //Random rnd = new Random();
            //int number = rnd.Next(1, 100);
            //int deneme = 3;
            //while (true)
            //{
            //    Console.WriteLine("Gues the number:");
            //    int user = int.Parse(Console.ReadLine());
            //    if (user == number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else if (user != number)
            //    {
            //        deneme--;
            //    }
            //    if (deneme == 0)
            //    {
            //        Console.WriteLine("Hakkınız bitti");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Try again!");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }




            //Seviyeye göre puanlama 
            //Seviye seçme

            //Random rnd = new Random();
            //int number = rnd.Next();
            //int deneme;
            //while (true)
            //{
            //    Console.WriteLine("Seviye seçininiz: kolay/orta/zor");
            //    string sev = Console.ReadLine();
            //    if (sev == "kolay")
            //    {
            //        int sayi = rnd.Next(1, 10);
            //        int denemes = 3;
            //    }
            //    Console.WriteLine("Gues the number:");
            //    int user = int.Parse(Console.ReadLine());
            //    if (user == number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else if (user != number)
            //    {
            //        deneme--;
            //    }
            //    if (deneme == 0)
            //    {
            //        Console.WriteLine("Hakkınız bitti");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Try again!");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }

            //}

            //ödev

            Random rnd = new Random();
            int deneme = 3;
            bool gameEnded = false;
            int number = 0; // number değişkenini başlangıçta tanımla

            while (true)
            {
                Console.WriteLine("Seviye seçiniz: kolay/orta/zor");
                string sev = Console.ReadLine();

                // Seçilen zorluk seviyesine göre aralığı ayarla
                if (sev == "kolay")
                {
                    number = rnd.Next(1, 10);
                }
                else if (sev == "orta")
                {
                    number = rnd.Next(1, 50);
                }
                else if (sev == "zor")
                {
                    number = rnd.Next(1, 100);
                }
                else
                {
                    Console.WriteLine("Geçersiz seviye! Tekrar deneyin.");
                    gameEnded = true;
                }

                if (gameEnded)
                {
                    break; // oyun bittiyse döngüden çıkar
                }

                Console.WriteLine("Sayıyı tahmin edin:");
                int user = 0; // Kullanıcı girişini başlangıçta tanımla

                try
                {
                    user = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz Giriş. Lütfen geçerli bir numara girin.");
                    deneme--;
                }

                if (user == number)
                {
                    Console.WriteLine("Kazandın!");
                    break;
                }
                else
                {
                    deneme--;

                    if (deneme == 0)
                    {
                        Console.WriteLine("Hakkınız bitti");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyin!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}




