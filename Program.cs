using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GaziDiziler.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi / Array

            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //index

            //int[] numbers = { 50, 20, 30 };

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Array.Sort(numbers); //sıralar //sort = sıralamak //küçükten büyüğe sıralar //Array.Reverse() = büyükten küçüğe sıralar.

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Kaç adet isim sıralamak istiyorsunuz? 3
            //1. ismi giriniz? Ali
            //2. ismi giriniz? Veli
            //3. ismi giriniz? Deli
            //Sıralanmış isimler:
            //1-Ali
            //2-Deli
            //3-Veli

            //Console.WriteLine("How many names do you want to sort?");
            //int count = int.Parse(Console.ReadLine());

            //string[] names = new string[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter {i+1}.Name:");
            //    names[i] = Console.ReadLine();
            //}

            //Array.Sort(names);
            //Console.WriteLine("Sorted Names:");

            //for (int i = 0; i < count; i++) 
            //{
            //    Console.WriteLine($"{i+1}-{names[i]}");
            //}


            Console.WriteLine("How many numbers do you want to sort?");
            byte count = byte.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = rnd.Next(100);
                } while (Array.IndexOf(numbers, randomNumber) != -1); //Array.IndexOf metodu, belirli bir değerin dizide bulunup bulunmadığını kontrol ediyor.

                numbers[i] = randomNumber;
            }

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

//Referans: Heap bölgesindeki değerlerin adreslerini tutan yapılardır.  