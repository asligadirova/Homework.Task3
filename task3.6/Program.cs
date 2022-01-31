using System;

namespace task3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et

            int a = 12345678; //> 234567
            if (a>=10000000 && a<100000000)
            {
                a = a % 10000000;
                a = a / 10;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("8 reqemli deyil");     
            }
        }
    }
}
