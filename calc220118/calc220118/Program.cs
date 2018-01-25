using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calc220118;

namespace calc220118
{
    class Program
    {
        static void Help()//Вывод списка команд
        {
            Console.WriteLine("Список команд: ");
            Console.WriteLine("Summ - сложение\nSub  - вычитание\nDiv  - деление\nMult - умножение\nPow2 - возведение в квардрат\nPow3 - возведение в куб\n/help - список команд");
           
        }

        static double ReadNumb(string operation)
        {

          
            string s1 = Console.ReadLine();//почекать потом эксепшны
            string[] args = s1.Split(' ');
            var UseCalc = new Calc();
            if (operation == "/help")
            { string[] opers = UseCalc.ShowOperations(); foreach (var item in opers) { Console.WriteLine(item); } return 0; }
            else
            { double result = UseCalc.Exec(operation, args); return result; }
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
                      //  Help();
                    }
                    string operation = Console.ReadLine();
                   var res =  ReadNumb(operation);
                    Console.WriteLine(res);
                }
                firstTime++;//после первого раза нельзя попасть в ветку аргументов командной строки,
                            //а также при новом круге не будет выводиться список команд
                Console.WriteLine("Для выхода из программы нажмите escape...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//повторение работы программы
        }
    }
}
