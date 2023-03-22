using System;
using System.Collections.Immutable;

namespace dotnetuz
{
    public class Program
    {
        public static void Main(string[] args)
        {
          


         Console.WriteLine(" SON kiriting ");
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
                     }


   
          

            
            


        }
    }
}

