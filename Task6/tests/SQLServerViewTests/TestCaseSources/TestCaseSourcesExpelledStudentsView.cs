using NUnit.Framework;
using System.Collections;

namespace SQLServerViewTests.TestCaseSources
{
    /// <summary>
    /// Test case sources for expelled students view.
    /// </summary>
    public class TestCaseSourcesExpelledStudentsView
    {
        /// <summary>
        /// String implementation for session two group RF, TM and grade 30.
        /// </summary>
        public static readonly string SessionOneGrade30_NoOrdered =
            "IDStudent; NameOfSession; NameOfGroup; Name; Surname; Patronymic\r\n" +
            "1; First; RF; Name1; Surname1; Patronymic1\r\n" +
            "2; First; RF; Name3; Surname3; Patronymic3\r\n" +
            "3; First; TM; Name2; Surname2; Patronymic2\r\n" +
            "4; First; TM; Name4; Surname4; Patronymic4\r\n";

        /// <summary>
        /// String implementation for session two group RF, TM and grade 50.
        /// </summary>
        public static readonly string SessionOneGrade50_NoOrdered =
            "IDStudent; NameOfSession; NameOfGroup; Name; Surname; Patronymic\r\n" +
            "1; First; RF; Name1; Surname1; Patronymic1\r\n" +
            "2; First; RF; Name3; Surname3; Patronymic3\r\n" +
            "3; First; TM; Name2; Surname2; Patronymic2\r\n" +
            "4; First; TM; Name4; Surname4; Patronymic4\r\n";

        /// <summary>
        /// Parameters for tests StudentsToBeExpelledView
        /// </summary>
        public static IEnumerable GiveToString_WhenNoOrdered_ThenOutIsToString
        {
            get
            {
                yield return new TestCaseData("First", 30).Returns(SessionOneGrade30_NoOrdered);
                yield return new TestCaseData("First", 50).Returns(SessionOneGrade50_NoOrdered);
            }
        }
    }
}
