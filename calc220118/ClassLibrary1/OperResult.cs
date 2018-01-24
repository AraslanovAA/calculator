using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary1;

namespace ClassLibrary1
{
   public  class OperResult : IOperationResult
    {
        public OperResult(double result, string error)
        {
            Result = result;
            Error = error;
        }
        public string Error
        {
            get;set;
        }
        public double Result
        {
            get;set;
        }
        
    }
}
