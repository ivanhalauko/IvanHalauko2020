using NUnit.Framework;
using System.Collections;

namespace SQLServerViewTests
{
    /// <summary>
    /// Source for test cases.
    /// </summary>
    public class TestCaseSourcesSessionsResultsViewTests
    {
        /// <summary>
        /// String implementation for session one group RF and no ordered.
        /// </summary>
        public static readonly string SessionOneGroupRF_NoOrdered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Phisic; 4\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Philosophy; 5\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Math; 6\r\n" +
            "First; RF; Name3; Surname3; Patronymic3; Phisic; 4\r\n" +
            "First; RF; Name3; Surname3; Patronymic3; Philosophy; 5";

        /// <summary>
        /// String implementation for session one group TM and no ordered.
        /// </summary>
        public static readonly string SessionOneGroupTM_NoOrdered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "First; TM; Name2; Surname2; Patronymic2; Chemistry; 7\r\n" +
            "First; TM; Name4; Surname4; Patronymic4; Math; 6\r\n" +
            "First; TM; Name4; Surname4; Patronymic4; Chemistry; 7";

        /// <summary>
        /// String implementation for session one group RF and  ordered.
        /// </summary>
        public static readonly string SessionOneGroupRF_Ordered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "First; RF; Name3; Surname3; Patronymic3; Philosophy; 5\r\n" +
            "First; RF; Name3; Surname3; Patronymic3; Math; 4\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Chemistry; 6\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Philosophy; 5\r\n" +
            "First; RF; Name1; Surname1; Patronymic1; Math; 4";

        /// <summary>
        /// String implementation for session one group TM and  ordered.
        /// </summary>
        public static readonly string SessionOneGroupTM_Ordered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "First; TM; Name4; Surname4; Patronymic4; Philosophy; 7\r\n" +
            "First; TM; Name4; Surname4; Patronymic4; Math; 6\r\n" +
            "First; TM; Name2; Surname2; Patronymic2; Chemistry; 7";

        /// <summary>
        /// Parameters for tests TestCaseSourcesSessionsResultsViewTests
        /// </summary>
        public static IEnumerable GiveToString_WhenNoOrdered_ThenOutIsToString
        {
            get
            {
                yield return new TestCaseData("First", "RF").Returns(SessionOneGroupRF_NoOrdered);
                yield return new TestCaseData("First", "TM").Returns(SessionOneGroupTM_NoOrdered);
            }
        }
        /// <summary>
        /// Parameters for tests TestCaseSourcesSessionsResultsViewTests and ordered.
        /// </summary>
        public static IEnumerable GiveToString_WhenOrderByDescendingFirstNameAndValue_ThenOutIsToStringOrderBy
        {
            get
            {
                yield return new TestCaseData("First", "RF").Returns(SessionOneGroupRF_Ordered);
                yield return new TestCaseData("First", "TM").Returns(SessionOneGroupTM_Ordered);
            }
        }
    }
}
