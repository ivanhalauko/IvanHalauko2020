using AVLTreeLib;
using NUnit.Framework;
using Serializers;
using StudentInformationClass;


namespace SerializersTests
{
    /// <summary>
    /// Class for testing BinarySerializer.
    /// </summary>
    [TestFixture()]
    public class BinarySerializerTests
    {
        [Test()]
        public void GivenXmlSerializeStudentsRepository_ThenOutXmlSerialize()
        {
            //Actual
            BinarySerializer binarySerializer = new BinarySerializer();
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };

            AVLTree<StudentInfo> expectedStudentAVLTree = new AVLTree<StudentInfo>();
            //Act
            expectedStudentAVLTree.Add(firstStudent);
            expectedStudentAVLTree.Add(secondStudent);
            expectedStudentAVLTree.Add(thirdStudent);
            binarySerializer.Serialize(expectedStudentAVLTree, "SerializeData");

            var actualRepository = binarySerializer.Deserialize<AVLTree<StudentInfo>>("SerializeData/AVLTree`1.dat");

            Assert.AreEqual(expectedStudentAVLTree, actualRepository);
        }
    }
}
