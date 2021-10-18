using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IProductoService : Iservice<Productos>
    {
        Productos ObtenerpotID();
        Productos UEPS();
        Productos PEPS();
        Productos PP(Productos p, decimal VTT, int unidades);
        Productos PPsalida(Productos p, int unidades);
        Productos PS();
    }
}
