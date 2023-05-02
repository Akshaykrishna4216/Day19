using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N = { 1, 2, 3, 4, 5 };

            Console.WriteLine("enter the number");
            int K = int.Parse(Console.ReadLine());
            int i;
            for ( i = 0; i < N.Length; i++)
            {
                if (N[i] == K)
                {
                    Console.WriteLine("index of " + K + " is " + i);
                    
                   
                }
                


            }
            







        }
    }
}
