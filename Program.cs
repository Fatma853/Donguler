﻿using System;
namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrana girilen sayıya kadar kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz: ");
            /*int sayac = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= sayac; i++)
            {
            
                if(i%2 ==1)
                    Console.WriteLine(i);

            }
            */
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi aralarındaki toplamları ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0; 
            for (int i=1; i < 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;  

                else 
                     ciftToplam += i;

            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            for (int i = 1; i<10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
        } 
    }
}