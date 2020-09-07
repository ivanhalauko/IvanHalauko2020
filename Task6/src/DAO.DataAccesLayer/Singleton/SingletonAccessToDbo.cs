using DAO.DataAccesLayer.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer.Singleton
{
    public class SingletonAccessToDbo
    {
        private static SingletonAccessToDbo _instance = null;

        public AbstractFactory Factory { get; set; } = null;

        private SingletonAccessToDbo(AbstractFactory factory)
        {
            AbstractFactory Factory = factory;
        }

        public static SingletonAccessToDbo GetInstance(AbstractFactory factory)
        {
            if (_instance==null)
            {
                _instance = new SingletonAccessToDbo(factory);  
            }
            return _instance;
        }
    }
}
