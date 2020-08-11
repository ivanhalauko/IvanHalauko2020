using System;

namespace AVLTreeLib
{
    /// <summary>
    /// Node's type.
    /// </summary>
    public class AVLTreeNode<TNode> : IComparable<TNode> where TNode : IComparable
    {
        /// <summary>
        /// Field tree.
        /// </summary>
        AVLTree<TNode> _tree;
        /// <summary>
        /// Root's left descendent.
        /// </summary>
        AVLTreeNode<TNode> _left;
        /// <summary>
        /// Root's right descendent.
        /// </summary>
        AVLTreeNode<TNode> _right;
        /// <summary>
        /// Node's constructor.
        /// </summary>
        /// <param name="value">Value of node.</param>
        /// <param name="parent">Parent of node.</param>
        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }
        /// <summary>
        /// Node's parent reference.
        /// </summary>
        public AVLTreeNode<TNode> Parent
        {
            get;
            internal set;
        }

        /// <summary>
        /// Reference on the left descendent.
        /// </summary>
        public AVLTreeNode<TNode> Left
        {
            get
            {
                return _left;
            }
            internal set
            {
                _left = value;
                if (_left != null)
                {
                    _left.Parent = this; //установка указателя на родительский элемент
                }
            }
        }

        /// <summary>
        /// Reference on the right descendent.
        /// </summary>
        public AVLTreeNode<TNode> Right
        {
            get
            {
                return _right;
            }
            internal set
            {
                _right = value;
                if (_right != null)
                {
                    _right.Parent = this; //установка указателя на родительский элемент
                }
            }
        }

        /// <summary>
        /// Node's value.
        /// </summary>
        public TNode Value
        {
            get;
            private set;
        }

        /// <summary>
        /// Method is implementing IComparable interface.
        /// </summary>
        /// <param name="other">Node for comparison.</param>
        /// <returns>Return 1 if other less then current.</returns>
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        /// <summary>
        /// Property height left tree.
        /// </summary>
        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

        /// <summary>
        /// Property of height right tree.
        /// </summary>
        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        /// <summary>
        /// State of tree.
        /// </summary>
        private TreeStateEnum State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeStateEnum.LeftHeavy;
                }
                if (RightHeight - LeftHeight > 1)
                {
                    return TreeStateEnum.RightHeavy;
                }
                return TreeStateEnum.Balanced;
            }
        }

        /// <summary>
        /// Balance factor.
        /// </summary>
        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        /// <summary>
        /// Method finds height.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int MaxChildHeight(AVLTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }

        /// <summary>
        /// Method left rotation tree. 
        /// </summary>
        private void LeftRotation()
        {
            AVLTreeNode<TNode> newRoot = Right;
            ReplaceRoot(newRoot);

            Right = newRoot.Left;
            newRoot.Left = this;

        }
        /// <summary>
        /// Method right rotation tree.
        /// </summary>
        private void RightRotation()
        {
            AVLTreeNode<TNode> newRoot = Left;
            ReplaceRoot(newRoot);

            Left = newRoot.Right;
            newRoot.Right = this;
        }

        /// <summary>
        /// Method root repalace.
        /// </summary>
        /// <param name="newRoot">New root.</param>
        private void ReplaceRoot(AVLTreeNode<TNode> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree.Head = newRoot;
            }
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

        /// <summary>
        /// Balance method.
        /// </summary>
        internal void Balance()
        {
            if (State == TreeStateEnum.RightHeavy)
            {
                LeftRotation();
                
            }
            else if (State == TreeStateEnum.LeftHeavy)
            {
                RightRotation();
            }
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
            AVLTreeNode<TNode> node = (AVLTreeNode<TNode>)obj;
            return Value.Equals(node.Value);
        }

        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        public override int GetHashCode() => Value.GetHashCode();

    }
}
