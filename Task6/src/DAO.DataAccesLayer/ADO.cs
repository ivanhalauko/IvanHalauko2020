using ModelsInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

        /// <summary>
        /// Create element and add to data base.
        /// </summary>
        /// <param name="substance">Object type of T.</param>
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

        public void DeleteElement(int byId)
        {
            ////string tableName = new T().GetType().Name;
            ////string storedProcedure = "Delete" + tableName + "ById";

            ////using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            ////{
            ////    SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("Id", byId) };
            ////    SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection, parameters);

            ////        sqlConnection.Open();
            ////        sqlCommand.ExecuteNonQuery();
            ////}
        }

        public void ReadElementFromDatabase(int byId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDatabase(T substance)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all method's property and add to list as sqlParameters. 
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>Return list of parameters.</returns>
        private List<SqlParameter> GetAddParameter(object obj)
        {
            PropertyInfo[] fields = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var sqlParams = new List<SqlParameter>();
            foreach (var f in fields)
            {
                if (f.GetCustomAttributes(false).Length != 0)
                {
                    if (f.GetCustomAttributesData()[0].AttributeType.Name != "KeyAttribute") //f.GetCustomAttributes(false).Length == 0 && 
                    {
                        sqlParams.Add(new SqlParameter(f.Name, f.GetValue(obj, null)));
                    }
                }
                else
                {
                    sqlParams.Add(new SqlParameter(f.Name, f.GetValue(obj, null)));
                }
            }
            return sqlParams;
        }



    }
}
