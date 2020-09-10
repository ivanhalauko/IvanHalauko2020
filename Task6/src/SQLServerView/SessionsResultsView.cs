using DAO.DataAccesLayer.Singleton;
using System.Collections.Generic;
using System.Linq;


namespace SQLServerView
{
    public class SessionsResultsView : ParentView
    {
        public string NameOfSession { get; set; }
        public string NameOfGroup { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Student's surname property.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Student's patronymic property.
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Student's birth date property.
        /// </summary>

        public string NameOfExam { get; set; }

        public int Value { get; set; }

        public SessionsResultsView()
        {
        }

        public SessionsResultsView(IView view) : base(view)
        {
        }

        public SessionsResultsView(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view)
        {
        }

        public IEnumerable<SessionsResultsView> GetView(string nameOfSession, string nameOfGroup)
        {
            IEnumerable<SessionsResultsView> sessionResultsView =
                from itemSessionResult in View.ExamStudResults
                join itemStudents in View.Students
                    on itemSessionResult.IDStudent equals itemStudents.Id

                join itemExamForGroups in View.ExamsForGroups
                    on itemSessionResult.IDExamForGroupe equals itemExamForGroups.Id

                join itemGroups in View.Groups
                    on itemStudents.IDGroupe equals itemGroups.Id

                join itemSession in View.ExamTerms
                on itemExamForGroups.IDExamTerm equals itemSession.Id

                join itemExam in View.Exams
                    on itemExamForGroups.IDExam equals itemExam.Id

                where itemSession.ExamTermName == nameOfSession & itemGroups.GroupeName==nameOfGroup //& int.I //IsNullOrEmpty(itemSessionResult.Rating)!=true

                select new SessionsResultsView
                {
                    NameOfSession = itemSession.ExamTermName,
                    NameOfGroup = itemGroups.GroupeName,
                    Surname = itemStudents.Surname,
                    Name = itemStudents.Name,
                    Patronymic = itemStudents.Patronymic,
                    NameOfExam = itemExam.ExamName,
                    Value = itemSessionResult.Rating  
                };
            return sessionResultsView;
        }

        public string ToString(IEnumerable<SessionsResultsView> sessionResultView)
        {
            string[] header = { "SessionName; GroupName; FirstName; LastName; MiddleName; SubjectName; Value" };
            string[] data = sessionResultView.Select(p => string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}", p.NameOfSession, p.NameOfGroup, 
                p.Name, p.Surname, p.Patronymic, p.NameOfExam, p.Value)).ToArray();

            return string.Join(System.Environment.NewLine, header.Concat(data));

        }

    }
}
