using System;

namespace task3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir.

            int a = 12345;
            int b = 23456;
            int cem = 0;
            int hasil = 1;
            int qaliq1;
            int qaliq2;
            int netice1;
            int a1 = a;
            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000)
            {
                while (a>0)
                {
                    qaliq1 = a % 10;
                    a = (a - qaliq1) / 10;
                    cem = cem + qaliq1;
                    
                }
                
                while (b>0)
                {
                    qaliq2 = b % 10;
                    b= (b - qaliq2) / 10;
                    hasil = hasil * qaliq2;

                }
                netice1 = cem + hasil;
                netice1 = netice1 * 10 + (a1 % 10);
                Console.WriteLine(netice1);
                
            }
              

            else
            {
                Console.WriteLine("5 reqemli deyil");    
            }

        }
    }
}
