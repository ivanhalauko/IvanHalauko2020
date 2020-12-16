using NUnit.Framework;
using StudentInformationClass;
using Serializers;
using StudentInformationtRepository;

namespace SerializersTests
{
    /// <summary>
    /// Class for testing SerializerTest
    /// </summary>
    [TestFixture]
    public class SerializerTests
    {
        /// <summary>
        /// GivenSerializerWithJsonSerializerAndStudentInfoRepository_ThenOutJsonSerialize.
        /// </summary>
        [Test()]
        public void GivenSerializerWithJsonSerializerAndStudentInfoRepository_ThenOutJsonSerialize()
        {
            //Actual
            Serializer jsonSerializer = new Serializer(new JsonSerializer());
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };
            Repository<StudentInfo> expectedStudentRepository = new Repository<StudentInfo>();
            //Act
            expectedStudentRepository.Add(firstStudent);
            expectedStudentRepository.Add(secondStudent);
            expectedStudentRepository.Add(thirdStudent);
            jsonSerializer.Serialize(expectedStudentRepository, "SerializeData");
            var actualRepository = jsonSerializer.Deserialize<Repository<StudentInfo>>("SerializeData/Repository`1.json");
            //Assert
            Assert.AreEqual(expectedStudentRepository, actualRepository);
        }
        /// <summary>
        /// GivenSerializerWithXMLSerializerAndStudentInfoRepository_ThenOutXMLSerialize.
        /// </summary>
        [Test()]
        public void GivenSerializerWithXMLSerializerAndStudentInfoRepository_ThenOutXMLSerialize()
        {
            //Actual
            Serializer xMLSerializer = new Serializer(new XMLSerializer());
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };
            Repository<StudentInfo> expectedStudentRepository = new Repository<StudentInfo>();
            //Act
            expectedStudentRepository.Add(firstStudent);
            expectedStudentRepository.Add(secondStudent);
            expectedStudentRepository.Add(thirdStudent);
            xMLSerializer.Serialize(expectedStudentRepository, "SerializeData");
            var actualRepository = xMLSerializer.Deserialize<Repository<StudentInfo>>("SerializeData/Repository`1.xml");
            //Assert
            Assert.AreEqual(expectedStudentRepository, actualRepository);
        }
        /// <summary>
        /// GivenSerializerWithBinarySerializerAndStudentsStudentInfoRepository_ThenOutBinarySerialize.
        /// </summary>
        [Test()]
        public void GivenSerializerWithBinarySerializerAndStudentsStudentInfoRepository_ThenOutBinarySerialize()
        {
            //Actual
            Serializer binarySerializer = new Serializer(new BinarySerializer());
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };

            Repository<StudentInfo> expectedStudentRepository = new Repository<StudentInfo>();
            //Act
            expectedStudentRepository.Add(firstStudent);
            expectedStudentRepository.Add(secondStudent);
            expectedStudentRepository.Add(thirdStudent);
            binarySerializer.Serialize(expectedStudentRepository, "SerializeData");

            var actualRepository = binarySerializer.Deserialize<Repository<StudentInfo>>("SerializeData/Repository`1.dat");
            //Assert
            Assert.AreEqual(expectedStudentRepository, actualRepository);
        }
    }
}
