using System;

namespace task3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

            int a = 123456789; //456 // 4+5+6

            if (a>=100000000 && a<1000000000)
            {
                int qaliq;
                int cem = 0;
                int b = a / 1000;
                while (b/1000>0)
                {
                    
                    qaliq = b % 10;
                    b = (b - qaliq) / 10;

                    cem = cem + qaliq;
                }


                Console.WriteLine(  cem);

            }
            else
            {
                Console.WriteLine("9 reqemli deyil");
            }
        }
    }
}
