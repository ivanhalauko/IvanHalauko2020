using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer
{
    public interface ICRUD<T>
    {
        void CreateElement(T substance);

        T ReadElementFromDatabase(int byId);

        void UpdateDatabase(T substance);

        void DeleteElement(int byId);
    }
}
