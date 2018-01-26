using CalcDB.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDB.repositories
{
    interface Irepository
    {
        OperationResult Get(long Id);

        void Save( OperationResult result);
        
        void Delete(long result);
        IList<OperationResult> GetByOperation(long Id);
        IList<OperationResult> GetAll();
    }
}
