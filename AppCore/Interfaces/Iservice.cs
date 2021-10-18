using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
   public interface Iservice <T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        T[] FindAll();
    }
}
