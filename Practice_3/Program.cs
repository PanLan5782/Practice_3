using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = InputData("x=");
            double y = InputData("y=");
            IsBelong(x,y);
            bool GetRes= IsBelong(x, y);

            if (GetRes)
                Console.WriteLine("Точка принадлежит области");
            else
                Console.WriteLine("Точка не принадлежит области");
        }
        public static double InputData(String prompt)
        {
            bool ok = true;
            double v = 0;
            do
            {
                Console.Write(prompt);
                ok = double.TryParse(Console.ReadLine(), out v);
                if (!ok)
                    Console.WriteLine("Введенный символ не является числом. Повторите ввод.");
            }
            while (!ok);
            return v;
        }
        public static bool IsBelong(double x, double y)
        {
            if ((x >= 0 && x * x + y * y <= 1) || (x < 0 && Math.Abs(y) < 0.5 * x + 1))
                return true;
            else
                return false;
        }
    }

}
