using NUnit.Framework;
using System;
using ModelsInformation;

namespace DAO.DataAccesLayer.Tests
{
    [TestFixture()]
    public class ADOTests
    {

        [Test()]
        public void CreateExamStudResultTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ExamStudResults exam = new ExamStudResults() { IDStudent = 1, IDExamForGroupe = 1, Rating = 8 };
            ADO<ExamStudResults> instanceExamTerms = new ADO<ExamStudResults>(connectionString);
            instanceExamTerms.CreateElement(exam);

            //Assert.Fail();
        }

        [Test()]
        public void CreateExamForGroupTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DateTime dateGroupeExam = new DateTime(2015, 10, 5, 3, 4, 5);
            ExamForGroup exam = new ExamForGroup() { IDExam = 1, IDGroupe=1, IDExamTerm=1, DateGroupeExam=dateGroupeExam};
            ADO<ExamForGroup> instanceExamTerms = new ADO<ExamForGroup>(connectionString);
            instanceExamTerms.CreateElement(exam);

            //Assert.Fail();
        }

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