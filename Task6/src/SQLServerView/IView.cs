using ModelsInformation;
using System;
using System.Collections.Generic;


namespace SQLServerView
{
    public class IView
    {

        IEnumerable<Exam> Exams { get; }
         IEnumerable<ExamForGroup> ExamsForGroups { get; set; }
        IEnumerable<ExamStudResults> ExamStudResults { get; }

        IEnumerable<ExamTerms> ExamTerms { get; }

        IEnumerable<Groups> Groups { get; }
        IEnumerable<Students> Students { get; }
    }
}
