using NUnit.Framework;
using System.Linq;
using ModelsInformation.Models;

namespace DAO.DataAccesLayer.Tests
{
    /// <summary>
    /// Test class for testing CRUD methods.
    /// </summary>
    [TestFixture()]
    public class ADOLinqToSQLTests
    {
        /// <summary>
        /// Field with group repository.
        /// </summary>
        private ICRUD<Specialties> specialties;

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database_task7;Integrated Security = True; Connect Timeout=30 ; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True";
        /// <summary>
        /// Test cases for Add, Read and Delete CRUD-methods.
        /// </summary>
        /// <param name="actualName">Name parameter.</param>
        [TestCase("NewModernSpecialties")]
        public void ReadAllAndAddAndDelete_ThenOutIsActualName(string actualName)
        {
            //Arrage
            Specialties actual = new Specialties() { Id = 5, NameOfSpecialty = actualName, InfoOfSpecialty = "asd" };
            //Act
            specialties = new ADOLinqToSQL<Specialties>(connectionString);
            specialties.CreateElement(actual);

            var lastAddedName = specialties.ReadAllElementFromDatabase().ToList().Last().NameOfSpecialty;
            var lastAddedId = specialties.ReadAllElementFromDatabase().ToList().Last().Id;
            specialties.DeleteElement(lastAddedId);
            //Assert
            Assert.AreEqual(lastAddedName, actualName);
        }
        /// <summary>
        /// Test cases for Update CRUD-method.
        /// </summary>
        /// <param name="name">Name of object's field.</param>
        /// <param name="actualUpdateName">Actual update name</param>
        [TestCase("NameSpecialteTest3", "VaseFour")]
        public void GivenUpdate_WhenAdded_ThenOutUpdateThisSpecialties(string name, string actualUpdateName)
        {
            //Arrage
            Specialties actual = new Specialties() { NameOfSpecialty = name };
            //Act
            specialties = new ADOLinqToSQL<Specialties>(connectionString);
            specialties.CreateElement(actual);
            var lastAddedId = specialties.ReadAllElementFromDatabase().ToList().Last().Id;
            specialties.UpdateDatabase(new Specialties() { Id = lastAddedId, NameOfSpecialty = actualUpdateName });
            var expectedUpdetedName = specialties.ReadElementFromDatabase(lastAddedId);
            specialties.DeleteElement(lastAddedId); //clear last addded element
            //Assert
            Assert.AreEqual(expectedUpdetedName.NameOfSpecialty, actualUpdateName);
        }
    }
}
