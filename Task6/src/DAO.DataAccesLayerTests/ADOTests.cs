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
        public void CreateElementTest()
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DateTime birth = new DateTime(2015, 10, 5, 3, 4, 5);
            Students student = new Students() { Name = "Vasya",Surname="Ivanov",Patronymic="Petrovich", IDGroup=1, BirthDate =birth};

            ADO<Students> instance = new ADO<Students>(connectionString);
            instance.CreateElement(student);

            //Assert.Fail();
        }
    }
}