using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class ProductoModel : IProductomodel
    {

        #region CRUDS
        private Productos[] productos;
        public void Create(Productos t)
        {
            Add(t, ref productos);
        }
        public bool Delete(Productos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            if (index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }

            Productos[] tmp = new Productos[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }
        public Productos[] FindAll()
        {
            return productos;
        }
        public int Update(Productos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            productos[index] = t;
            return index;
        }
        #endregion
        #region OTROS

        public Productos ObtenerpotID(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }

            int index = GetIndexById(id);

            return index <= 0 ? null : productos[index];
        }

        #endregion
        #region Metodos


        public Productos PEPS()
        {
            throw new NotImplementedException();
        }

        public Productos PP(Productos p, decimal VTT, int unidades)
        {
            decimal nuevoVAlorporUnidad = p.VAlorTotalDemercancia / p.Existencia;
            
            decimal nuevovalortotal = (p.VAlorTotalDemercancia + VTT);

          
                Productos yx = new Productos()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    Existencia = p.Existencia,
                    Precio = p.Precio,
                    FechaVencimiento = p.FechaVencimiento,
                    UnidadMedida = p.UnidadMedida,
                    VAlorTotalDemercancia = nuevovalortotal,
                    valoporUnidad = nuevoVAlorporUnidad,



                };

                Create(yx);
                return yx;
           
            
        }
        public Productos PPsalida(Productos p, int unidades) 
        {
            Productos yx = new Productos()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia- unidades,
                Precio = p.Precio,
                FechaVencimiento = p.FechaVencimiento,
                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia =p.VAlorTotalDemercancia,
                valoporUnidad = p.VAlorTotalDemercancia,



            };

            Create(yx);
            return yx;
        }

        public Productos PS(Productos p, decimal VTT, int unidades)
        {
            decimal nuevoVAlorporUnidad = p.VAlorTotalDemercancia / p.Existencia;

            decimal nuevovalortotal = (p.VAlorTotalDemercancia + VTT);


            Productos yx = new Productos()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia,
                Precio = p.Precio,
                FechaVencimiento = p.FechaVencimiento,
                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = nuevovalortotal,
                valoporUnidad = nuevoVAlorporUnidad,



            };

            Create(yx);
            return yx;

        }
        public Productos PSsalida(Productos p, int unidades)
        {
            Productos yx = new Productos()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia - unidades,
                Precio = p.Precio,
                FechaVencimiento = p.FechaVencimiento,
                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = p.VAlorTotalDemercancia,
                valoporUnidad = p.VAlorTotalDemercancia,



            };

            Create(yx);
            return yx;

            
            
        }
       
        public Productos UEPS()
        {
            throw new NotImplementedException();
        }

        #endregion
        #region privados
        private void Add(Productos p, ref Productos[] pds)
        {
            if (pds == null)
            {
                pds = new Productos[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Productos[] tmp = new Productos[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (productos == null)
            {
                return index;
            }

            foreach (Productos p in productos)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }
        #endregion

    }
}
