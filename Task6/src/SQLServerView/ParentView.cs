﻿using DAO.DataAccesLayer.Singleton;

namespace SQLServerView
{
    /// <summary>
    /// Base class for view.
    /// </summary>
    public abstract class ParentView
    {
        /// <summary>
        /// Access to database.
        /// </summary>
        SingletonAccessToDbo SingletonAccessToDbo { get; set; }
        /// <summary>
        /// Tables for view.
        /// </summary>
        protected IView View;
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public ParentView() { }
        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="view">View property.</param>
        public ParentView(IView view) : this() => View = view;
        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="singletonAccessToDbo">SingletonAccessToDbo parameter.</param>
        /// <param name="view">View property.</param>
        public ParentView(SingletonAccessToDbo singletonAccessToDbo, IView view):this(view)
        {
            SingletonAccessToDbo = singletonAccessToDbo;
        }
    }
}
