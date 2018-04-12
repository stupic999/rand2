using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> number = new List<int>();
            for (int i = 0; i < 42; i++)
            {
                number.Add(i);
            }
            for (int i = 0; i <6; i++)
            {
                int j = rand.Next(1,number.Count);
                Console.Write(number[j]+" ");
                number.RemoveAt(j);
            }
            Console.ReadLine();
        }
    }
}
