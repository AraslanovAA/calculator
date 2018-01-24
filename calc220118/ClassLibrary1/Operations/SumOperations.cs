using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1.Operations
{
 

   public class SumOperations : NumberOperation
    {
        public override string name => "sum";

        public override IOperationResult Exec(IEnumerable<double> args)
        {
            return new OperResult(args.Sum(), null);
        }

    }
}
