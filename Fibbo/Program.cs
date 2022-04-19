using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            int k;
            Console.WriteLine("enter the position");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write(i+","+j+",");
           
            for(int a=2; a<k; a++ )
            {
                Console.Write(",");
                int b = i + j;
                i = j;
                j = b;
                Console.Write(b);
               

            }


            Console.ReadLine();



         }
    } 
}
