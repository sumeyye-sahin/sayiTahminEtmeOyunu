using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rmd = new Random();
            //int newmember = rmd.Next(12, 86);
            //Console.WriteLine(newmember);
            //  ...sayi tahmin etme oyunu...
            Random rnd = new Random();
            int sayi = rnd.Next(10, 20);
            Console.WriteLine(sayi);
            int hak = 3;
            BASADON:
            Console.Write("Sayiyi tahmin ediniz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
           
            if (tahmin==sayi)
            {
                Console.WriteLine("tebrikler.. Puanınız:{0}",hak*10);

            }
            else if (tahmin<sayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("Hakkınız kalmamıştır kaybettiniz...");
                }
                else
                {
                    Console.WriteLine("Daha büyük tahmin ediniz. hakkınız:{0}", hak);
                    goto BASADON;
                }

            }
            else if (tahmin>sayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("Hakkınız kalmamıştır..kaybettiniz..");
                }
                else
                {
                    Console.WriteLine("daha küçük sayi tahmin ediniz.hakkınız:{0}", hak);
                    goto BASADON;
                }

            }


            Console.ReadKey();
        }
    }
}
