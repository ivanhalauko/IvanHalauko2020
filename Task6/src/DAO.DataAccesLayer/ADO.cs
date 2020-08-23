using ModelsInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer
{
    public class ADO<T> : ICRUD<T> where T : ISubstance, new()
    {
        public string ConnectionString { get; set; }
        public ADO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void CreateElement(T substance)
        {

            // название процедуры
            var storedProcedure = "Add" + substance.GetType().Name;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddRange(GetAddParameter(substance).ToArray());
                connection.Open();
                sqlCommand.ExecuteScalar();

            }
        }

        public void DeleteElement()
        {
            throw new NotImplementedException();
        }

        public void ReadElementFromDatabase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
