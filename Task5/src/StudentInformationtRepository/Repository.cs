using AVLTreeLib;
using StudentInformationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationtRepository
{
    public class Repository
    {
        public AVLTree<StudentInfo> StudentAVLTree { get; set; }
                
        public Repository()
        {
            StudentAVLTree = new AVLTree<StudentInfo>();
        }

    }
}
