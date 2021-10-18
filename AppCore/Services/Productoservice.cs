using AppCore.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class Productoservice : IProductoService
    {

        private IProductomodel productoModel;

        public Productoservice(IProductomodel productoModel)
        {
            this.productoModel = productoModel;
        }

        public void Create(Productos t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                productoModel.Create(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Productos t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                return productoModel.Delete(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Productos[] FindAll()
        {
            return productoModel.FindAll();
        }

        public Productos ObtenerpotID()
        {
            throw new NotImplementedException();
        }

        public Productos PEPS()
        {
            throw new NotImplementedException();
        }

        public Productos PP(Productos p, decimal VTT, int unidades)
        {
            throw new NotImplementedException();
        }

        public Productos PPsalida(Productos p, int unidades)
        {
            throw new NotImplementedException();
        }

        public Productos PS()
        {
            throw new NotImplementedException();
        }

        public Productos UEPS()
        {
            throw new NotImplementedException();
        }

        public int Update(Productos t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                return productoModel.Update(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
