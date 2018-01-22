using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc220118
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = args[0];
            string num1 = args[1];
            string num2 = args[2];
            double num1_d, num2_d;
            double.TryParse(num1, out num1_d);
            double.TryParse(num2, out num2_d);
            if (operation == "summ")
            {
                Console.WriteLine(num2_d + num1_d);
            }
        }
    }
}
