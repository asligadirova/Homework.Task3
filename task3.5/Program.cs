using System;

namespace task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            int a = 123456; //>234561
            if (a>=100000 && a<1000000)
            {
                int qaliq;
                int d = a / 100000; //1

                qaliq = a % 100000; //23456

                int c;

                c = qaliq * 10 + d; //234561
                Console.WriteLine(c);
            }
           
           
            
        }
    }
}
