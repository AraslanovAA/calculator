using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1
{
    public abstract class NumberOperation : Ioperation
    {
        public virtual string name => "";

        public IOperationResult Exec(string[] args)
        {
            var numbers = args.Select(it => Convert.ToDouble(it));//а не поймаем ли эксепшн?!
            return Exec(numbers);

        }

        public abstract IOperationResult Exec(IEnumerable<double> args);//у каждого наследник должен быть этот метод
    }
}
