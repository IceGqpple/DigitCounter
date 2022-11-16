using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter();
        }

        public static void Counter()
        {
            int Num = 3256;
            int digits = Num.ToString().Length;
            Console.WriteLine(digits);
            Console.ReadLine();
        }
    }
}
