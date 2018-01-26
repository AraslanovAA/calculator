using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDB.models
{
    class OperationResult
    {
        public long Id { get; set; }
        public long OperationId { get; set; }
        public string Args { get; set; }
        public double? Result { get; set; }
        /// <summary>
        /// продолжительность выполнения операций в мс
        /// </summary>
        public long ExecutionResult { get; set; }
        public DateTime CreationTime { get; set; }
   
    [creationDate]
        DATETIME NOT NULL, 
    [error] NVARCHAR(MAX) NULL
    }
}
