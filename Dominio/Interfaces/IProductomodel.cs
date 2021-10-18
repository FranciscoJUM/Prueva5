using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
   public  interface IProductomodel : IModel<Productos>
    {
        Productos ObtenerpotID(int id);
        Productos UEPS();
        Productos PEPS();
        Productos PP(Productos p, decimal VTT, int unidades);
        Productos PPsalida(Productos p, int unidades);
        Productos PS(Productos p, decimal VTT, int unidades);
        Productos PSsalida(Productos p, int unidades);
    }
}
