using NUnit.Framework;
using DAO.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsInformation;

namespace DAO.DataAccesLayer.Tests
{
    [TestFixture()]
    public class ADOTests
    {
        [Test()]
        public void CreateExamTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Exam exam = new Exam() { ExamName = "Phisics" };
            ADO<Exam> instanceExam = new ADO<Exam>(connectionString);
            instanceExam.CreateElement(exam);

            //Assert.Fail();
        }

        [Test()]
        public void CreateGroupeTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Groups groupe = new Groups() { GroupeName = "ER" };
            ADO<Groups> instanceGroupe = new ADO<Groups>(connectionString);
            instanceGroupe.CreateElement(groupe);

            //Assert.Fail();
        }

        [Test()]
        public void CreateStudentTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          
            DateTime birth = new DateTime(2015, 10, 5, 3, 4, 5);  
            Students student = new Students() { Name = "Vasya",Surname="Ivanov",Patronymic="Petrovich", BirthDate =birth, IDGroupe = 1};
            ADO<Students> instance = new ADO<Students>(connectionString);
            instance.CreateElement(student);

            //Assert.Fail();
        }
    }
}