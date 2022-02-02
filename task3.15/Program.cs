using System;

namespace task3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix.
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.

            // Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //Cavabin axirina 11 artir.
            //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.

            int a1 = 123;
            int a2 = 234;
            int a3 = 123456;
            int a4 = 234567;
            int a5 = 1234567;
            int a6 = a5;
            if (a1 >= 100 && a1<1000 && a2 >= 100 && a2 < 1000 && a3 >= 100000 && a3<1000000 && a4 >= 100000 && a4 < 1000000 && a5 >= 1000000 && a5 < 10000000  )
            {
                int cem1 = a1 + a2 ; //357 //3 reqemli ededlerin cemini tap 
                int b = cem1 % 100;   //57
                b = b * b; //3249   //cavabin axirdan 2 denesini kvadratini tap.
                int c = a1 * 1000 + a2; //123234        // b+  3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
                c = c + b;
                int g = a5 % 100000;      //34567             //  7 reqemli ededin son 5 reqemini cix.
                int d = c - g;            //91916             //c-Cavabdan 7 reqemli ededin son 5 reqemini cix.
                int e = a3 + a4;          //358023            //  6 reqemlilerin cemi
                e = e % 1000;
                int f = d + e;           //91939              //d +Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel
                                         //f + Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel

                int cem2 = 0;
                while (a5>0)   //7 reqemli ededin reqemleri ceminin
                {
                    int qaliq = a5 % 10;
                    a5 = (a5 - qaliq) / 10;
                    cem2 = cem2 + qaliq;   //28
                    
                }

                int yeniEded = 0; // tersine duzulmesinden
                while (cem2>0)
                {
                    int qaliq2 = cem2 % 10;
                    cem2 = cem2 / 10;
                    yeniEded = yeniEded*10 + qaliq2; //82


                }

                int h = f + yeniEded; //92021
                int l = h * 100 + 11; //9202111       // h-in Cavabin axirina 11 artir

                int yeniEded1 = 0;               //a6=1234567 Sonra 7 reqemli ededin tek yerde dayan reqemlerinde( - l)  alinan ededi cix
                int counter = 1;
                while (a6>0)
                {
                    int qaliq3 = a6 % 10;
                    a6 = a6 / 10;
                    if (counter % 2 !=0)
                    {
                        yeniEded1 = yeniEded1 * 10 + qaliq3;
                    }
                    
                    counter++;

                }
                //Console.WriteLine(yeniEded1); //7531 ededin tersi
            
                while (yeniEded1>0)
                {
                    int qaliq4 = yeniEded1 % 10;
                    yeniEded1=yeniEded1 / 10;
                    a6 = a6 * 10 + qaliq4;    //1357

                }
                long x = a6 - l; //-9200754                     //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde  aalinan ededi cix.
                x = x * (-1);
                                                       //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
                long qaliq5 = x % 10;
                x = (x * 100 + 88) * 10 + qaliq5;
                
                Console.WriteLine(x);

            }
            else
            {
                Console.WriteLine( "sert odenilmir");
            }




        }
    }
}
