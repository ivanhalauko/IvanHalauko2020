using System;
using System.Collections.Generic;
using System.Linq;

namespace AVLTreeLib
{
    /// <summary>
    /// AVL tree class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AVLTree<T> : IEnumerable<T> where T : IComparable
    {
        /// <summary>
        /// Property of head.
        /// </summary>
        public AVLTreeNode<T> Head
        {
            get;
            set;
        }

        /// <summary>
        /// Quantity nodes of tree.
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Adding method nodes to tree.
        /// </summary>
        /// <param name="value">Node's value.</param>
        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new AVLTreeNode<T>(value, null, this);
            }
            else
            {
                AddTo(Head, value);
            }
            Count++;
        }

        /// <summary>
        /// Adding method nodes to tree.
        /// </summary>
        /// <param name="node">Node.</param>
        /// <param name="value">Node's value.</param>
        public void AddTo(AVLTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                //создание левого узла, если его нет
                if (node.Left == null)
                {
                    node.Left = new AVLTreeNode<T>(value, node, this);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new AVLTreeNode<T>(value, node, this);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
            node.Balance();
        }

        /// <summary>
        /// Method make in order travesal.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> InOrderTravesal()
        {
            if (Head != null)
            {
                Stack<AVLTreeNode<T>> stack = new Stack<AVLTreeNode<T>>();
                AVLTreeNode<T> current = Head;
                bool goLeftNext = true;
                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }
                    yield return current.Value;

                    if (current.Right != null)
                    {
                        current = current.Right;
                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        /// <summary>
        /// Method GetEnumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            List<T> test = InOrderTravesal().ToList();
            return test.GetEnumerator();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Comparing one node with another.
        /// </summary>
        /// <param name="obj">The compared node.</param>
        /// <returns>True if equal. False if not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            AVLTree<T> node = (AVLTree<T>)obj;
            return Head.Equals(node.Head);
        }

        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        public override int GetHashCode() => Head.GetHashCode();
    }
}
