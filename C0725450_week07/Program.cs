using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725450_week07
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new PlayWithRecursion();
            Console.WriteLine(PlayWithRecursion.GetFactorial(4));
        }
    }
    class PlayWithRecursion
    {
        public void Add(int a, int b)
        {
            if (a > 10)
            {
                return;
            }

            Add(++a, --b);
        }

        public static long GetFactorial(int number)
        {
            Console.WriteLine(number);
            if(number == 0) { return 1; }

            return number * GetFactorial(number - 1);
        }
        
    }
    // Recursion is a method calls itself
    //Every time call a method it will create a frame in the stack
}
