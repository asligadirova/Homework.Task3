using System;

namespace task3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.

            int a = 12345;
            int a1 = 23456;
            int a2 = 34567;
            if (a >= 10000 && a<100000 && a1 >= 10000 && a1 < 100000 && a2 >= 10000 && a2 < 100000)
            {
                
                
                    int son = a % 10;
                    int ilk = a / 10000;
                    int cem = ilk*10+ son;
               
                    int son1 = a1 % 10;
                    int ilk1 = a1/ 10000;
                    int cem1 = ilk1*10 + son1;

                    int son2 = a2 % 10;
                    int ilk2 = a2 / 10000;
                    int cem2 = ilk2*10 + son2;

                    int netice = cem + cem1 + cem2;
                    int neticeson = netice + (netice * 50 / 100);
                     Console.WriteLine(neticeson);
            }

            

            else
            {
                Console.WriteLine("5 reqemli deyil");
            }

        }
    }
}
