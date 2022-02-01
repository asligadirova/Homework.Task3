using System;

namespace task3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

            int a = 1234;
            if (a >= 1000 && a<10000)
            {
                int qaliq;
                int yeniEded = 0;
                while (a>0)
                {
                    qaliq = a % 10;
                    a = a / 10;
                    yeniEded = yeniEded * 10 + qaliq; //>4321
                    




                }

                yeniEded = yeniEded * 10 + 8;
                yeniEded = yeniEded + 800000;
                Console.WriteLine(yeniEded);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }

        }
    }
}
