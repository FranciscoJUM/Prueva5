using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Productos
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadDEMedida UnidadMedida { get; set; }

        // atrivutos para El PP 
        public decimal VAlorTotalDemercancia { get; set; }
        public decimal valoporUnidad { get; set; }
        public class ProductoOrderByPrecio : IComparer<Productos>
        {
            public int Compare(Productos x, Productos y)
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
