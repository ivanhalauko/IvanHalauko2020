using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer
{
    public interface ICRUD<T>
    {

        void CreateElement();

        void ReadElementFromDatabase();

        void UpdateDatabase();

        void DeleteElement();
    }
}
