using System;

namespace HWtask3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            int a = 12345;
            if (a>=10000 && a<100000)
            {
                int ilk;
                int son;
                ilk = a / 10000;
                son = a % 10;
                int c = ilk + son;
                Math.Pow(c, 2);
                Console.WriteLine(Math.Pow(c,2));
            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }
        }
    }
}
