using NUnit.Framework;
using DAO.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsInformation.Models;

namespace DAO.DataAccesLayer.Tests
{
    [TestFixture()]
    public class ADOLinqToSQLTests
    {
        /// <summary>
        /// Field with group repository.
        /// </summary>
        private ICRUD<Specialties> specialties;

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database_task7;Integrated Security = True; Connect Timeout=30 ; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True";
        /// <summary>
        /// Test cases for Add.
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
