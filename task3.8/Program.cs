using System;

namespace task3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap


            int a = 12345; //3+5
            int son;
            son = a % 10; //5
            int uc;
            uc = a / 100 % 10; //3
            
            int cem = son + uc;
            Console.WriteLine(cem);

            Console.ReadLine();
        }
    }
}
