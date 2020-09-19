using AVLTreeLib;
using NUnit.Framework;
using Serializers;
using StudentInformationClass;

namespace SerializersTests
{
    /// <summary>
    /// Class for testing repository.
    /// </summary>
    [TestFixture()]
    public class XMLSerializerTests
    {
        [Test()]
        public void GivenXmlSerializeStudentsRepository_ThenOutXmlSerialize()
        {
            //Actual
            XMLSerializer xMLSerializer = new XMLSerializer();
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };
            
            AVLTree<StudentInfo> expectedStudentAVLTree = new AVLTree<StudentInfo>();
            //Act
            expectedStudentAVLTree.Add(firstStudent);
            expectedStudentAVLTree.Add(secondStudent);
            expectedStudentAVLTree.Add(thirdStudent);
            xMLSerializer.Serialize(expectedStudentAVLTree, "xmlSerializeData");

            var actualRepository = xMLSerializer.Deserialize<AVLTree<StudentInfo>>("xmlSerializeData/AVLTree`1.xml");

            Assert.AreEqual(expectedStudentAVLTree, actualRepository);

        }
    }
}
