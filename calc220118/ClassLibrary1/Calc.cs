using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Operations;
using ClassLibrary;
using System.Reflection;
using System.IO;

namespace calc220118
{
    
   public class Calc
    {
        private void LoadOperations(Assembly cur_Assemly)
        {
            var types = cur_Assemly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsAbstract || type.IsInterface) continue;
                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(Ioperation)))
                {
                    var obj = Activator.CreateInstance(type) as Ioperation;
                    if (obj != null)
                    {
                        Operations.Add(obj);
                    }

                }
            }
        }
        //все switch case меняем на Calc.Exec(oper, new [] {"10","20","10"});
        
        public Calc()
        {
             Operations = new List<Ioperation>();//пофиксить
                                                 // var cur_Assemly = Assembly.GetExecutingAssembly();//список типов которые у нас есть 

            //директория где лежит exe-шник
            var pathExtenions = Path.Combine(Environment.CurrentDirectory,"extensions1");

            //проверяем наличие файла
            if (Directory.Exists(pathExtenions))
            {

                var assemlies = Directory.GetFiles(pathExtenions, "*.dll");
                foreach (var filename in assemlies)
                {
                   // LoadOperations()
                    LoadOperations(Assembly.LoadFile(filename));
                }
            }
/*
            var cur_Assemly = Assembly.LoadFile(
                @"C:\Users\User\Documents\GitHub\calculator\calc220118\calc220118\bin\Debug\extension\Exit.Calculator.Finans.dll"
);//подгрузили библиотечку
    */        
                /*
            var sumType = typeof(SumOperation);
            sumType.GetMethods();
            sumType.GetInterfaces();//находим все классы интерфейсы которые реализуют Ioperation и заталкиваем в список операций
            */
        }
        private IList<Ioperation> Operations;
        public void ShowOperations()
        {
            foreach(var item in Operations)
            {
                Console.WriteLine(item.name);
                //operation.Select(o => o.name).ToArray();
            }
        }

        public  double Exec(string OperationName, string[] args)
        {
            Ioperation oper;



            //найти опреацию в списке операций
           /* foreach(var item in Operations)
            {
                if (item.name == OperationName)
                    {
                    oper = item;
                    break;
                }
            }*/
            oper = Operations.FirstOrDefault(it => it.name == OperationName);
            /*
 it =>it.Name == operationName
bool Func(Ioeration it, string operationName){
return it.Name == operationName;
}
 */
            //если не удалось найти - возвращаем NaN
            if (oper == null)
            {
                return double.NaN;
            }
            //иначе вычисляем результат опреации
            var Result = oper.Exec(args);
            //если в резуьтате ошибка заполнена - вывести её на экран
            if (string.IsNullOrWhiteSpace(Result.Error))
            {
                //выводим на экран
            }
            else
            {
                //иначе выводим результат
                return Result.Result;
            }
            //дефолтное значение
            return double.NaN;
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public int Summ(int x, int y)
        {
            //return 0;
            return (int)Summ((double)x, (double)y);
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double Summ(double x, double y)
        {
            return x + y;
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public int Sub(int x, int y)
        {
            return x - y;
           // return 0;
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double Sub(double x, double y)
        {
            return x - y;
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
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
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double mult(double x, double y)//умножение
        {
            return x * y;
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double pow2(double x)//возведение в квадрат
        {
            return Math.Pow(x, 2);
        }
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double pow3(double x)//возведение в куб
        {
            return Math.Pow(x, 3);
        }
    }
}
