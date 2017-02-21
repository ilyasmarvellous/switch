using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 10:
                    Console.WriteLine("Entered number is 10");
                    break;
                case 20:
                    Console.WriteLine("Entered number is 20");
                    break;
                case 30:
                    Console.WriteLine("Entered number is 30");
                    break;
                default:
                    Console.WriteLine("Entered number is out of case");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
