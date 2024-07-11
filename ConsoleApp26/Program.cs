using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Random bky = new Random();
            double bakiye = bky.Next(2000, 10000);
            while (bakiye>0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bakiye : " + bakiye + "\n");
                Console.Write("Bahis : ");
                double bahis = Convert.ToInt32(Console.ReadLine());
                while (bakiye < bahis)
                {
                    Console.WriteLine("Bakiye yetersiz!");
                    Console.Write("Bahis : ");
                    bahis = Convert.ToInt32(Console.ReadLine());
                }
                Console.ResetColor();
                Console.WriteLine();
                Random orn = new Random();
                int oran = orn.Next(2, 100);
                Random yldz = new Random();
                Console.Write("1. at : Zübeyir ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                double yildiz = 0;
                byte a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 6);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("2. at : Kara Fatma ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 5);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("3. at : Züleyha ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 5);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("4. at : Bold Pilot ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 5);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("5. at : Kopta gel Ayşe ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 5);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("6. at : Ayrıl da gel Sefa ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("enerji : ");
                Console.ResetColor();
                a1 = 0;
                while (a1 < 1)
                {

                    yildiz = yldz.Next(1, 5);
                    for (int i = 0; i < yildiz; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (yildiz == 1)
                {
                    yildiz += 6;
                }
                else if (yildiz == 2)
                {
                    yildiz += 3;
                }
                else if (yildiz == 4)
                {
                    yildiz -= 2;
                }
                else if (yildiz == 5)
                {
                    yildiz -= 3.5;
                }
                Console.WriteLine("\noran : " + yildiz);
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Seçim : ");
                byte secim = Convert.ToByte(Console.ReadLine());
                while (secim < 1 || secim > 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("Geçerli bir seçim yap!");
                    Console.Write("Seçim : ");
                    secim = Convert.ToByte(Console.ReadLine());
                }
                Console.ResetColor();
                Console.WriteLine();
                bakiye = bakiye - bahis;
                //------------------------------------------------------------------------//
                Random ryaris = new Random();
                a1 = 0;
                Console.Write("1. at : | ");
                int yaris1 = 0;
                while (a1 < 1)
                {

                    yaris1 = ryaris.Next(1, 10);
                    for (int i = 0; i < yaris1; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                a1 = 0;
                Console.Write("2. at : | ");
                int yaris2 = 0;
                while (a1 < 1)
                {

                    yaris2 = ryaris.Next(1, 10);
                    if (yaris2 == yaris1)
                    {
                        yaris2++;
                    }
                    for (int i = 0; i < yaris2; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                a1 = 0;
                Console.Write("3. at : | ");
                int yaris3 = 0;
                while (a1 < 1)
                {

                    yaris3 = ryaris.Next(1, 10);
                    if (yaris3 == yaris2)
                    {
                        yaris3++;
                    }
                    if (yaris3==yaris1)
                    {
                        yaris3++;
                    }
                    for (int i = 0; i < yaris3; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                a1 = 0;
                Console.Write("4. at : | ");
                int yaris4 = 0;
                while (a1 < 1)
                {

                    yaris4 = ryaris.Next(1, 10);
                    if (yaris4 == yaris3)
                    {
                        yaris4++;
                    }
                    if (yaris4==yaris2||yaris4==yaris1)
                    {
                        yaris4++;
                    }
                    for (int i = 0; i < yaris4; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                a1 = 0;
                Console.Write("5. at : | ");
                int yaris5 = 0;
                while (a1 < 1)
                {

                    yaris5 = ryaris.Next(1, 10);
                    if (yaris5 == yaris4)
                    {
                        yaris5++;
                    }
                    if (yaris5==yaris3||yaris5==yaris2||yaris5==yaris1)
                    {
                        yaris5++;
                    }
                    for (int i = 0; i < yaris5; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                a1 = 0;
                Console.Write("6. at : | ");
                int yaris6 = 0;
                while (a1 < 1)
                {

                    yaris6 = ryaris.Next(1, 10);
                    if (yaris6 == yaris5)
                    {
                        yaris6++;
                    }
                    if (yaris6==yaris4||yaris6==yaris3||yaris6==yaris2||yaris6==yaris1)
                    {
                        yaris6++;
                    }
                    for (int i = 0; i < yaris6; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    a1++;
                }
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("-");
                Console.ResetColor();
                Console.WriteLine();
                if (secim == 1)
                {
                    if (yaris1 > yaris2 && yaris1 > yaris3 && yaris1 > yaris4 && yaris1 > yaris5 && yaris1 > yaris6)
                    {
                        bakiye = bakiye + (bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                else if (secim == 2)
                {
                    if (yaris2 > yaris1 && yaris2 > yaris3 && yaris2 > yaris4 && yaris2 > yaris5 && yaris2 > yaris6)
                    {
                        bakiye = bakiye+(bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                else if (secim == 3)
                {
                    if (yaris3 > yaris1 && yaris3 > yaris2 && yaris3 > yaris4 && yaris3 > yaris5 && yaris3 > yaris6)
                    {
                        bakiye = bakiye + (bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                else if (secim == 4)
                {
                    if (yaris4 > yaris1 && yaris4 > yaris2 && yaris4 > yaris3 && yaris4 > yaris5 && yaris4 > yaris6)
                    {
                        bakiye = bakiye + (bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                else if (secim == 5)
                {
                    if (yaris5 > yaris1 && yaris5 > yaris2 && yaris5 > yaris3 && yaris5 > yaris4 && yaris5 > yaris6)
                    {
                        bakiye = bakiye + (bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                else if (secim == 6)
                {
                    if (yaris6 > yaris1 && yaris6 > yaris2 && yaris6 > yaris3 && yaris6 > yaris4 && yaris6 > yaris5)
                    {
                        bakiye = bakiye + (bahis * yildiz);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine(bahis*yildiz + " TL kazandın!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKaybettin!");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Bakiye bitti!");
            Console.ResetColor();
        }
    }
}
