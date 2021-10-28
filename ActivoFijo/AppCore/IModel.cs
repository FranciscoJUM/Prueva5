using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore
{
   public  interface IModel <T>
    {
        // Cruds
        void Create(Producto p);
        T[] FindAll();

    }
}
