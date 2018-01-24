using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Exit.Calculator.Finans
{
    public class RubToEuroOperation : NumberOperation
    {
        public override string name
        {
            get
            {
                return "ru2euro";
            }
        }
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            if (args.Count() == 0)
            {
                return new OperResult(double.NaN, "Не указанна сумма в рублях");
            }
            var ruble = args.First();
            return new OperResult(ruble * new Random().Next(59, 63), "");
            
        }
    }
}
