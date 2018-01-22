using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc220118
{
    class Program
    {
        static void Help()//Вывод списка команд
        {
            Console.WriteLine("Список команд: ");
            Console.WriteLine("Summ - сложение\nSub  - вычитание\nDiv  - деление\nMult - умножение\nPow2 - возведение в квардрат\nPow3 - возведение в куб\n/help - список команд");
        }

        static void ReadNumb(int index)
        {
            double x_ = 0, y_ = 0;
            if ((index == 4) || (index == 5))//если используем функции одной переменной
            {
                Console.Write("Введите число: ");

                while (!double.TryParse(Console.ReadLine(), out x_))
                    Console.Write("Попробуйте снова: ");

            }
            if (index <= 3)//при использовании функции двух переменных
            {

                Console.WriteLine("Через пробел введите 2 числа: ");
                bool key = false;
                int index_space; string s1;
                while (key == false)
                {
                    s1 = Console.ReadLine();
                    index_space = s1.IndexOf(' ');//убеждаемся, что в строке имеется пробел, чтобы избежать rangeexeption при split
                    if (index_space != -1)
                    {
                        string[] split = s1.Split(' ');
                        if ((double.TryParse(split[0], out x_)) & (double.TryParse(split[1], out y_)))//если числа считаны успешно продолжаем работу
                            key = true;
                    }
                }
            }
            var UseCalc = new Calc();
            switch (index)
            {
                case 0: Console.WriteLine(UseCalc.Summ(x_, y_)); break;
                case 1: Console.WriteLine(UseCalc.Sub(x_, y_)); break;
                case 2: if ((UseCalc.Div(x_, y_) == 1) & (x_ != y_)) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Деление на 0"); Console.ResetColor(); } else Console.WriteLine(UseCalc.Div(x_, y_)); break;
                case 3: Console.WriteLine(UseCalc.mult(x_, y_)); break;
                case 4: Console.WriteLine(UseCalc.pow2(x_)); break;
                case 5: Console.WriteLine(UseCalc.pow3(x_)); break;
                case 6: Help(); break;
            }
        }

        static void Main(string[] args)
        {
            uint firstTime = 0;
            string[] operations = { "summ", "sub", "div", "mult", "pow2", "pow3", "/help" };//список функций, реализуемых программой
            do//повторение работы программы
            {
                if ((args.Length != 0) && (firstTime == 0))//если имеются аргументы командной строки
                {//условие в условии, чтобы в будущем была возможность доработать для 1 и 2 аргументов
                    if (args.Length == 3)
                    {
                        double x, y;
                        if ((double.TryParse(args[1], out x)) & (double.TryParse(args[2], out y)))
                        {
                            var UseCalc = new Calc();
                            switch (args[0].ToLower())
                            {
                                case "summ": Console.WriteLine(UseCalc.Summ(x, y)); break;
                                case "sub": Console.WriteLine(UseCalc.Sub(x, y)); break;
                                case "div": if ((UseCalc.Div(x, y) == 1) & (x != y)) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Деление на 0"); Console.ResetColor(); } else Console.WriteLine(UseCalc.Div(x, y)); break;
                                case "mult": Console.WriteLine(UseCalc.mult(x, y)); break;
                                default: break;
                            }
                        }
                    }
                }
                else
                { //если нет аргументов командной строки 
                    int index = -1;
                    if ((firstTime == 0) || ((firstTime ==1) && (args.Length!=0)))
                    {
                        Console.WriteLine("Консольный калькулятор");
                        Help();
                    }
                    while (index == -1)
                    {
                        string operation = Console.ReadLine();
                        index = Array.IndexOf(operations, operation.ToLower());
                    }
                    ReadNumb(index);
                }
                firstTime++;//после первого раза нельзя попасть в ветку аргументов командной строки,
                            //а также при новом круге не будет выводиться список команд
                Console.WriteLine("Для выхода из программы нажмите escape...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//повторение работы программы
        }
    }
}
