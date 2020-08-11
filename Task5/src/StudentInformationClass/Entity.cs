using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationClass
{
    public abstract class Entity : IComparable
    {
        public int Id { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Entity item)
            {
                return Id.CompareTo(item.Id);
            }
            else
            {
                throw new ArgumentNullException();
            }
            
        }
    }
}
