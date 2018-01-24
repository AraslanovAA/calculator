using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1.Operations
{
    class SubOperation : NumberOperation
    {
        public override string name => "sub";
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            //return new Operresult(args.Aggregate(a,b) => a -b), null);
            var result = 0d;
            result = args.Count() >= 2
                ? args.ElementAt(0) - args.ElementAt(1)
                : double.NaN;
            return new OperResult(result, null);
           
        }
        
    }
}
