using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Merry_Christmas
{
    class Program
    {   
        public static void Main(string[] args)
        {
            time();
            Console.ReadKey();
        }
        static void free_sp(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.Write(" ");
        }
        static void f_pyramid(int a, int b, int c)
        {
            Random r = new Random();

            int i, j, k, l = 0;
            for (i = a; i <= b; i++)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
                for (j = c - l; j > a; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                {

                    if (k == 1)
                    {
                        Console.Write(" /");
                    }
                    if (k == i)
                    {
                        Console.Write(" \\");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
                l++;       
            }
        }
        static void func_l(int n)
        {
            Random r = new Random();
            
            for (int i = 0; i <= n; i++)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
                free_sp(34);
                Console.WriteLine("||||");
            }
        }
        static void time()
        {
            DateTime zaman = DateTime.Now;
            int secim = 1;

            if (secim == 1)
            {
                while (true)//sonsuz döngü kurduk.
                {
                    Console.Clear();//konsol ekranını temizledik.
                    free_sp(32);
                    Console.Write(DateTime.Now.ToLongTimeString());//DateTime sınıfından hazır saati çekme fonksiyonunu kullandık.
                    Console.WriteLine("");
                    free_sp(25);
                    Console.Write("* Happy New Year "+ DateTime.Now.Year.ToString()+" *\n");
                    free_sp(35);
                    Console.Write("^");
                    f_pyramid(0, 5, 35);
                    f_pyramid(3, 7, 35);
                    f_pyramid(5, 11, 35);
                    func_l(4);
                    System.Threading.Thread.Sleep(1000);//Thread kütüphanesinden 1000 milisaniye yani 1 saniyeliğine programı uykuya aldık.
                    
                }
            }
        }

    }
}
