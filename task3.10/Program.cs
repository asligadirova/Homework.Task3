using System;

namespace task3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //sonra cut yerde dayanlarinda bir eded duzlet,
            //sonra onlari topla

            int a = 123456789;
            int qaliq;
            int cem;
            int yeniEded = 0;
            int yeniEded1 = 0;
            int a1 = a;
            if (a>=100000000 && a<1000000000)
            {
                int counter = 1;
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = a / 10;
                    if (counter %2 !=0)
                    {                       
                        yeniEded = yeniEded * 10 + qaliq; //987654321

                    }
                                        
                    counter++;
                }

                Console.WriteLine(yeniEded); //>97531  
                Console.WriteLine("-------");
                while (yeniEded>0)
                {
                    int qaliq1 = yeniEded % 10;
                    yeniEded = yeniEded / 10;
                     a = a * 10 + qaliq1;
                }
               
                Console.WriteLine( a  );   //13579  =>9 reqemli ededdi tek yerde dayananlardan bir eded duzlet
                Console.WriteLine("------");
                int counter1 = 1;
                int qaliq2;
                
                while (a1>0)
                {
                    qaliq2 = a1 % 10;
                    a1 = a1 / 10;
                    if (counter1 % 2 == 0)
                    {
                        yeniEded1 = yeniEded1 * 10 + qaliq2; //987654321

                    }

                    counter1++;
                }

                Console.WriteLine(yeniEded1); // 8642 
                Console.WriteLine("-------");
                while (yeniEded1>0)
                {
                    int qaliq3 = yeniEded1 % 10;
                    yeniEded1 = yeniEded1 / 10;
                    a1 = a1 * 10 + qaliq3;
                    
                }
                Console.WriteLine(a1);  //2468
                Console.WriteLine("**********");
                int c = a1 + a;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("9 reqemli deyil");
            }
            

        }
    }
}
