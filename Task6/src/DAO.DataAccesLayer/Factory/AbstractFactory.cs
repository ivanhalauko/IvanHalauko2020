using ModelsInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer.Factory
{
    public abstract class AbstractFactory
    {
        public abstract ICRUD<Students> CreateStudents();

        public abstract ICRUD<Groups> CreateGroups();

        public abstract ICRUD<ExamTerms> CreateExamTerms();

        public abstract ICRUD<ExamStudResults> CreateExamStudResults();

        public abstract ICRUD<ExamForGroup> CreateExamForGroup();

        public abstract ICRUD<Exam> CreateExam();


    }
}
