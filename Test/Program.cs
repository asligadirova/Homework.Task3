using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //verilmish 4 reqemli ededin reqemlerinin cemini tap

            int a = 1234;

            if (a >= 1000 && a < 10000)
            {
                int qaliq;
                int cem = 0;

                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;

                }

                Console.WriteLine(cem);


            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}




        
