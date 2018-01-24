using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1
{
   
    /// <summary>
    /// Операция
    /// </summary>
   
    public interface Ioperation
    {
        string name { get; }

        IOperationResult Exec(string[] args);
    }
}
