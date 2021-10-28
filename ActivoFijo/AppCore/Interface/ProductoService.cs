using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace AppCore.Interface
{
    public class ProductoService : IProductoModel
    {
        ProductoModel pro;
        public decimal CalcularDepresionLineaRecta(decimal ValorDelActivo, int TimpoDeVida)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularDepresionSDA(decimal ValorDelActivo, int TimpoDeVida)
        {
            throw new NotImplementedException();
        }

        public void Create(Producto p)
        {
            throw new NotImplementedException();
        }

        public Producto[] FindAll()
        {
            throw new NotImplementedException();
        }

        public decimal PEPS(decimal salida)
        {
            throw new NotImplementedException();
        }

        public Producto PP(Producto p, decimal VTT, int unidades)
        {
            throw new NotImplementedException();
        }

        public Producto PPsalida(Producto p, int unidades)
        {
            throw new NotImplementedException();
        }

        public Producto PS(Producto p, decimal VTT, int unidades)
        {
            throw new NotImplementedException();
        }

        public Producto PSsalida(Producto p, int unidades)
        {
            throw new NotImplementedException();
        }

        public decimal UEPS(decimal salida)
        {
            throw new NotImplementedException();
        }
    }
}
