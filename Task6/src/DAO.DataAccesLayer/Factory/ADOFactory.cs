using ModelsInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer.Factory
{
    public class ADOFactory : AbstractFactory
    {
        protected internal ADO<Exam> Exam { get; set; }

        protected internal ADO<ExamForGroup> ExamForGroup { get; set; }

        protected internal ADO<ExamStudResults> ExamStudResults { get; set; }

        protected internal ADO<ExamTerms> ExamTerms { get; set; }

        protected internal ADO<Groups> Groups { get; set; }

        protected internal ADO<Students> Students { get; set; }

        public ADOFactory(string dbConnectionString)
        {
            Exam = new ADO<Exam>(dbConnectionString);
            ExamForGroup = new ADO<ExamForGroup>(dbConnectionString);
            ExamStudResults = new ADO<ExamStudResults>(dbConnectionString);
            ExamTerms = new ADO<ExamTerms>(dbConnectionString);
            Groups = new ADO<Groups>(dbConnectionString);
            Students = new ADO<Students>(dbConnectionString);
        }

        public override ICRUD<Exam> CreateExam()
        {
            return Exam;
        }

        public override ICRUD<ExamForGroup> CreateExamForGroup()
        {
            return ExamForGroup;
        }

        public override ICRUD<ExamStudResults> CreateExamStudResults()
        {
            return ExamStudResults;
        }

        public override ICRUD<ExamTerms> CreateExamTerms()
        {
            return ExamTerms;
        }

        public override ICRUD<Groups> CreateGroups()
        {
            return Groups;
        }

        public override ICRUD<Students> CreateStudents()
        {
            return Students;
        }
    }
}
