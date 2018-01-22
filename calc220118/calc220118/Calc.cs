using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc220118
{
   public class Calc
    {
        
        public int Summ(int x, int y)
        {
            //return 0;
            return x + y;
        }
        public double Summ(double x, double y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
           // return 0;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Div(double x, double y)//деление с проверкой 0
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 1;
            }
        }
        public double mult(double x, double y)//умножение
        {
            return x * y;
        }
        public double pow2(double x)//возведение в квадрат
        {
            return Math.Pow(x, 2);
        }
        public double pow3(double x)//возведение в куб
        {
            return Math.Pow(x, 3);
        }
    }
}
