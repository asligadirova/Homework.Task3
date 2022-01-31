using System;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //123456
            int a = 248889;

            a = a / 1000; //248
            int b = a % 10; //8
            int c =( a - b)%100; //40
            int d = (a - (c+ b))/100; //2 

            int e = d + (c/10 + b);
            Console.WriteLine(e);
        }
    }
}
