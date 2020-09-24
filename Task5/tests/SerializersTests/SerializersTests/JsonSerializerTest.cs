using AVLTreeLib;
using NUnit.Framework;
using Serializers;
using StudentInformationClass;

namespace SerializersTests
{
    /// <summary>
    /// Class for testing JsonSerializer.
    /// </summary>
    [TestFixture()]
    public class JsonSerializerTest
    {
        [Test()]
        public void GivenJsonSerializeStudentsRepository_ThenOutJsonSerialize()
        {
            //Actual
            JsonSerializer jsonSerializer = new JsonSerializer();
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };

            AVLTree<StudentInfo> expectedStudentAVLTree = new AVLTree<StudentInfo>();
            //Act
            expectedStudentAVLTree.Add(firstStudent);
            expectedStudentAVLTree.Add(secondStudent);
            expectedStudentAVLTree.Add(thirdStudent);
            jsonSerializer.Serialize(expectedStudentAVLTree, "SerializeData");

            var actualRepository = jsonSerializer.Deserialize<AVLTree<StudentInfo>>("SerializeData/AVLTree`1.json");

            Assert.AreEqual(expectedStudentAVLTree, actualRepository);
        }

        [Test()]
        public void GivenJsonSerializeStudentInfoRepository_ThenOutJsonSerialize()
        {
            //Actual
            JsonSerializer jsonSerializer = new JsonSerializer();
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
           
            //Act          
            jsonSerializer.Serialize(firstStudent, "SerializeData");
            var actualRepository = jsonSerializer.Deserialize<StudentInfo>("SerializeData/StudentInfo.json");
            Assert.AreEqual(firstStudent, actualRepository);
        }

    }
}
