using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcDB.models;

namespace CalcDB.repositories
{
    //регион в десктоп кальке сохранение  бд
    public class OperResultRepository : Irepository//скопипастить
    {

        //todo - вынести в настройки
        private string connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\calculator\CalcDB\CalcDB\AppData\DB_0.mdf;Integrated Security=True";
        void Irepository.Delete(long result)
        {
            throw new NotImplementedException();
        }

        OperationResult Irepository.Get(long Id)
        {
            throw new NotImplementedException();
        }

        IList<OperationResult> Irepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IList<OperationResult> Irepository.GetByOperation(long Id)
        {
            throw new NotImplementedException();
        }

        void Irepository.Save(OperationResult result)
        {
            string queryString =
            "INSERT INTO [dbo].[OperationResult].(OperationId], [ExecutionTime],[])";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                var command =   new SqlCommand(queryString, connection);
                connection.Open();

                var count = command.ExecuteNonQuery();

                
            }
        }
    }
}
