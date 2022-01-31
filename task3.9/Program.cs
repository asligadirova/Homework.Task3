using System;

namespace task3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439

            int a = 123456789;

            bool ugurludur = (a >= 100000000 && a < 1000000000);
            if (!ugurludur)
            {
                Console.WriteLine("9 reqemli deyil");
                return;

            }

            int yeniEded = 0; //123456789;
            int qaliq;
            //while (a > 0)
            //{
            //    qaliq = a % 10;
            //    a = a / 10;
            //    yeniEded = yeniEded * 10 + qaliq;
            //}

            //Console.WriteLine(yeniEded);

            //yeni ededin icinden tek yerde duranlari secirik
            int counter = 1;
            while (a > 0)
            {
                qaliq = a % 10;
                a = a / 10;
                if (counter % 2 != 0)
                {
                    yeniEded = yeniEded * 10 + qaliq;


                }
                counter++;




            }
            Console.WriteLine(yeniEded);

            while (yeniEded > 0) //123456789 =>97531 =>13579
            {
                qaliq = yeniEded % 10;
                yeniEded = yeniEded / 10;
                a = a * 10 + qaliq;


            }
            Console.WriteLine(a);





        }
    }
}
