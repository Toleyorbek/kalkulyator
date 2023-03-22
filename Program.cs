using System;
using System.Collections.Immutable;

namespace dotnetuz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //    //Your code goes here
            //    Console.Write("A= ");
            //   // string s = Console.ReadLine();
            //    double a= double.Parse(Console.ReadLine());
            //    Console.Write("B=");
            //    int b = int.Parse(Console.ReadLine());
            //    //console.writeline($"a + b = {a + b}");
            //    //int c = int.parse(console.readline());
            //    //int d = int.parse(console.readline());
            //    //console.writeline($"c + d = {c + d}");
            //        int s = 1;
            //    for(double i = a; i < b; i++)
            //    {
            //        Console.WriteLine($"SANOQ {s}={i}");
            //        s++;
            //    }




            //  for (int i=0;i<257;i++)
            //  {
            //      char c= (char)i;  
            //      Console.WriteLine ($"{i}   { c} ");
            //  }


            /* Console.WriteLine(" SON kiriting ");
             double son = double.Parse(Console.ReadLine());
             Console.WriteLine("ishora kiriting  +  -  *  /  ");
             char belgi = char.Parse(Console.ReadLine());
                     Console.WriteLine("keyingi  SONNI kiriting");
                     double son2 = double.Parse(Console.ReadLine());
                     Console.Write("NATIJA= ");
                     if (belgi == '+')
                     {
                         Console.WriteLine(son + son2);
                     }
                     if (belgi == '-')
                     {
                         Console.WriteLine(son - son2);
                     }
                     if (belgi == '*')
                     {
                         Console.WriteLine(son * son2);
                     }
                     if (belgi == '/')
                     {
                       Console.WriteLine(son / son2);
                     }*/


            Console.WriteLine("SON KIRITING ");
          int  son =char.Parse(Console.ReadLine());
            if (0 < son && son < 47 && 57 < son && son < 257) ;
            {
                Console.WriteLine(System.Math.isDigit(son));
            }
            
          

            
            


        }
    }
}

