using AVLTreeLib;
using System;
using System.Collections.Generic;


namespace StudentInformationtRepository
{
    /// <summary>
    /// Clas repository for varios types.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
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
        /// <summary>
        /// Comparing one StudentTestResultRepository with another.
        /// </summary>
        /// <param name="obj">The compared StudentTestResultRepository.</param>
        /// <returns>True if equal. False if not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Repository<T> repository = (Repository<T>)obj;
            return AVLTree.Equals(repository.AVLTree);
        }
        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        public override int GetHashCode() => AVLTree.GetHashCode();

    }
}
