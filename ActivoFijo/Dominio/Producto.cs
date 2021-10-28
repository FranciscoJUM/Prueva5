using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public  class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public MeasureUnit UnidadMedida { get; set; }
        public InventoryMethod InventoryMethod { get; set; }
        public decimal Precio { get; set; }
        public decimal Existencia { get; set; }

       
        public  decimal VAlorTotalDemercancia { get; set; }
        public decimal valoporUnidad { get; set; }
        public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if (x.Precio < y.Precio)
                {
                    return -1;
                }
                else if (x.Precio > y.Precio)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
