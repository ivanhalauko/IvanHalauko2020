using ModelsInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ConnectToDatabase
{
    public class DataAccess
    {
        public List<Students> GetStudents(string name)
        {
           // throw new ArgumentException();
            using  (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Students>("dbo.People_GetByLastName @LasName", new { Name = name }).ToList();
                return output;
            }
        }

        public void InsertStudents(string name, string surname, string patronymic, DateTime birthDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Students newStudent = new Students { Name = name, Surname = surname, Patronymic = patronymic, BirthDate = birthDate };
                List<Students> students = new List<Students>();

                students.Add(new Students { Name = name, Surname = surname, Patronymic = patronymic, BirthDate = birthDate });

                connection.Execute("dbo.Students_Insert @Name,@Surname,@Patronymic,@BirthDate", students);
            }
        }
    }
}
