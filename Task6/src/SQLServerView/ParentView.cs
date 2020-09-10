using DAO.DataAccesLayer.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerView
{
    public abstract class ParentView
    {
        SingletonAccessToDbo SingletonAccessToDbo { get; set; }

        protected IView View;
        public ParentView() { }
        public ParentView(IView view) : this() => View = view;
        public ParentView(SingletonAccessToDbo singletonAccessToDbo, IView view):this(view)
        {
            SingletonAccessToDbo = singletonAccessToDbo;
        }
    }
}
