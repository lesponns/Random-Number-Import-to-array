using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_31_10_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num;

            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++) 
            {
                num = rnd.Next(0, 100);
                numbers[i] = num;
                if (numbers[i] < 50)
                {
                    Console.WriteLine("{0}", numbers[i]);
                }
                
                
            }
            Console.ReadKey();

        }
    }
}
