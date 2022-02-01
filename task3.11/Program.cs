using System;

namespace task3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix;

            int a = 12345678;
            if (a>=10000000 && a<100000000)
            {
                int b = a % 100; //78

                int c = a / 100;
                c = c % 100;      //56

                int d = a / 10000;
                d = d % 100;      //34

                int e = a / 1000000; //12
                int cem = b + c + d + e;            

                cem = cem * 100 + 99;
                cem = cem - (cem * 18 / 100);

                Console.WriteLine(cem);

            }
              
            else
            {
                Console.WriteLine("8 reqemli deyil");
            }
        }
    }
}
