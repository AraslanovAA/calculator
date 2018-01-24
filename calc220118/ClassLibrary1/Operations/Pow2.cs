using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1.Operations
{
    class Pow2 : NumberOperation
    {
        public override string name => "pow2";
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            var result = 0d;
            result = args.Count() >= 2
                ? args.ElementAt(0) * args.ElementAt(0)
                : double.NaN;
            return new OperResult(result, null);
        }
    }
}
