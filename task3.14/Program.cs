using System;

namespace task3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel

            //Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //Neticenin 60 % tap.Cavabin axirina 60 artir.
            // Neticeden 18 % cix.

            int a1 = 123456;
            int a2 = 234567;
            int a3 = 345678;
            int a4 = 1234567;
            if (a1>=100000 & a1<1000000 && a2 >= 100000 & a2 < 1000000 && a3 >= 100000 & a3 < 1000000 && a4 >= 1000000 & a4 < 10000000 )
            {
                a1 = a1 / 1000;                
                a2 = a2 / 1000;
                a3 = a3 / 1000;
                int cem = a1 + a2 + a3;  //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
                int cem2 = a4 % 10000 + cem; //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
                //Console.WriteLine(cem2); //5269
                a4 = a4 / 10000;
                //Console.WriteLine(a4); //123 //7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi
                int hasil = 1;  
                while (a4>0)
                {
                    int qaliq = a4 % 10;
                    a4 = (a4 - qaliq) / 10;
                    hasil = hasil * qaliq;
                }


               // Console.WriteLine(hasil); //6
                int netice1 = cem2 - hasil;  //5263
                netice1 = netice1 * 60 / 100;
                netice1 = netice1 * 100 + 60; ///Neticenin 60 % tap.Cavabin axirina 60 artir.
                netice1 = netice1 - netice1 * 18 / 100;  // Neticeden 18 % cix.

                Console.WriteLine(netice1);

            }
            else
            {
                Console.WriteLine("verilen sert odenilmir");
            }
        }
    }
}
