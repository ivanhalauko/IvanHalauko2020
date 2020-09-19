using NUnit.Framework;
using StudentInformationClass;
using StudentInformationtRepository;
using System.Collections.Generic;
using System.Linq;

namespace StudentInformationtRepositoryTests
{
    /// <summary>
    /// Class for testing repository.
    /// </summary>
    [TestFixture()]
    class RepositoryTests
    {
        /// <summary>
        /// Given show all tree when order by student name then out is ordered.
        /// </summary>
        [Test]
        public void GivenShowAllTree_WhenOrderByStudentName_ThenOutIsOrdered()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName = "Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            List<StudentInfo> expectedStudents = new List<StudentInfo>()
            {
                new StudentInfo() { Id = 1, StudentName = "Petya" },
                new StudentInfo() { Id = 0, StudentName = "Vasya" },
                new StudentInfo() { Id = 2, StudentName = "YaGor"}
            };
            
            //Act   
            var actualStudents = rep.ShowAllTree().OrderBy(x => x.StudentName);
            //Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }

        /// <summary>
        /// Given show all tree when order descending by student name then out is order descending.
        /// </summary>
        [Test]
        public void GivenShowAllTree_WhenOrderDescendingByStudentName_ThenOutIsOrderDescending()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName = "Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            List<StudentInfo> expectedStudents = new List<StudentInfo>()
            {            
                new StudentInfo() { Id = 2, StudentName = "YaGor" },
                new StudentInfo() { Id = 0, StudentName = "Vasya" },
                new StudentInfo() { Id = 1, StudentName = "Petya" },
            };

            //Act   
            var actualStudents = rep.ShowAllTree().OrderByDescending(x => x.StudentName);
            //Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }
    }
}
