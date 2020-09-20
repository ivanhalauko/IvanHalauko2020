using MarkerISerialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationClass
{
    [Serializable]
    public class TestsResult : Entity, ISerialize
    {
        public int IdStudent { get; set; }

        public int IdTest { get; set; }
        public int StudentTestRating { get; set; }
        public DateTime DateOfExams { get; set; }



    }
}
