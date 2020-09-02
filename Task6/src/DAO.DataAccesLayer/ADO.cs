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
            string tableName = new T().GetType().Name;
            string storedProcedure = "Delete" + tableName + "ById";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("Id", byId) };

                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddRange(parameters);


                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public T ReadElementFromDatabase(int byId)
        {
            if (byId == 0)
                throw new NullReferenceException("byId should not be 0");

            string tableName = new T().GetType().Name;
            string storedProcedure = "Show" + tableName + "ById";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("Id", byId) };

                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddRange(parameters);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                try
                {
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    DataTable test = ds.Tables[0];
                    T test3 = ToEnumerable(test).ToList().SingleOrDefault();

                    return test3;
                }
                catch (SqlException sqlEx)
                {
                    throw new ArgumentException("Some Error occured at database, if error in stored procedure: " + storedProcedure, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }


        /// <summary>
        /// Method to convert table to IEnumerable<T>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="table">input table</param>
        /// <returns>Returns IEnumerable<T> of table</returns>
        public IEnumerable<T> ToEnumerable(DataTable table)
        {
            List<T> list = new List<T>();

            foreach (var row in table.AsEnumerable())
            {
                T obj = new T();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        public T UpdateDatabase(T substance)
        {
            if (substance == null)
            {
                throw new ArgumentNullException();
            }

            string tableName = new T().GetType().Name;
            string storedProcedure = "Update" + tableName;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {

                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddRange(GetUpdateParameter(substance).ToArray());

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();

                try
                {
                    sqlDataAdapter.Fill(ds);
                    DataTable test = ds.Tables[0];
                    T test2 = ToEnumerable(test).ToList().SingleOrDefault();
                    return test2;
                }
                catch (SqlException sqlEx)
                {
                    throw new ArgumentException("Class Name and Table name must be same for this method. See inner exception", sqlEx);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Private method for get property from objects and add their to list for sqlParameters
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>returns list of sqlParameters.</returns>
        private List<SqlParameter> GetUpdateParameter(object obj)
        {
            PropertyInfo[] fields = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var sqlParams = new List<SqlParameter>();
            foreach (var f in fields)
            {
                sqlParams.Add(new SqlParameter(f.Name, f.GetValue(obj, null)));
            }
            return sqlParams;
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
