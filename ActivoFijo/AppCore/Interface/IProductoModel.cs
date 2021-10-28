using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interface
{
   public interface IProductoModel : IModel<Producto>
    {
        decimal UEPS(decimal salida);
        decimal PEPS(decimal salida);
        Producto PP(Producto p, decimal VTT, int unidades);
        Producto PPsalida(Producto p, int unidades);
        Producto PS(Producto p, decimal VTT, int unidades);
        Producto PSsalida(Producto p, int unidades);

        decimal CalcularDepresionLineaRecta(decimal ValorDelActivo, int TimpoDeVida);
        decimal CalcularDepresionSDA(decimal ValorDelActivo, int TimpoDeVida);

    }
}
