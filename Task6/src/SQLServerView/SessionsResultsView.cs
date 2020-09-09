using DAO.DataAccesLayer.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Value { get; set; }

        public SessionsResultsView()
        {
        }

        public SessionsResultsView(IView view) : base(view)
        {
        }

        public SessionsResultsView(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view)
        {
        }

        
    }
}
