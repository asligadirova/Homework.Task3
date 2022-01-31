using System;

namespace task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3

            int a = 234567;
            if (a>=100000 && a<1000000)
            {
                int qaliq;
                int cem = 0;
                int yeniEded = 0;

                while (a > 0) 
                {
                    qaliq = a %  10;
                    a = a / 10;
                    yeniEded = yeniEded*10 + qaliq; //654321
                    int qaliq2;

                    while (yeniEded/1000 > 0) 
                    {
                        qaliq2 = yeniEded % 10;
                        yeniEded = (yeniEded -qaliq2)/ 10;
                        cem = cem + qaliq2;
                    
                    
                    
                    }

                    
                
                }


                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }
        }
    }
}
