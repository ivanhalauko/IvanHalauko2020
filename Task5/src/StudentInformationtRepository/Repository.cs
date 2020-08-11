using AVLTreeLib;
using StudentInformationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationtRepository
{
    public class Repository<T>  where T : IComparable
    {
        public AVLTree<T> AVLTree { get; set; }


        public Repository()
        {
            AVLTree = new AVLTree<T>();         

        }

        public IEnumerable<T> ShowAllTree(Func<T, string> keySelector, bool desinding)
        {
            if (desinding)
                return AVLTree.InOrderTravesal().OrderBy(keySelector);
            else
                return AVLTree.InOrderTravesal().OrderByDescending(keySelector);
        }


    }
}
