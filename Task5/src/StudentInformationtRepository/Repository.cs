using AVLTreeLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInformationtRepository
{
    /// <summary>
    /// Clas repository for varios types.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T>  where T : IComparable
    {
        /// <summary>
        /// Property AVLTree.
        /// </summary>
        public AVLTree<T> AVLTree { get; set; }

        /// <summary>
        /// Clas's constructor.
        /// </summary>
        public Repository()
        {
            AVLTree = new AVLTree<T>();         
        }

        /// <summary>
        /// Method show node's of tree.
        /// </summary>
        /// <param name="keySelector">Key.</param>
        /// <param name="desinding">Desinding.</param>
        /// <returns>Nodes of tree.</returns>
        public IEnumerable<T> ShowAllTree()
        {
                return AVLTree.InOrderTravesal();
        }

        /// <summary>
        /// Data add.
        /// </summary>
        /// <param name="obj">Oobject.</param>
        public void Add(T obj)
        {
            if (obj != null)
                AVLTree.Add(obj);
        }

    }
}
