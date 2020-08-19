using NUnit.Framework;
using StudentInformationClass;
using StudentInformationtRepository;

namespace StudentInformationtRepositoryTests
{
    /// <summary>
    /// Class for testing repository.
    /// </summary>
    [TestFixture()]
    class RepositoryTests
    {
        /// <summary>
        /// GivenAddWhenTIsStudentInfoThenOutIsStudentInfoNode.
        /// </summary>
        [Test]
        public void GivenAddWhenTIsStudentInfoThenOutIsStudentInfoNode()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            Repository<TestsResult> repTestResult = new Repository<TestsResult>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName = "Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            repTestResult.AVLTree.Add(new TestsResult() { Id = 0 });

            var test = rep.ShowAllTree(x => x.StudentName, false);
            var testTrue = rep.ShowAllTree(x => x.StudentName, true);
        }
    }
}
