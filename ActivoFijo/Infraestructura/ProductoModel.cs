using AppCore.Interface;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
      public  class ProductoModel : IProductoModel
    {
        Producto[] productos;
        ProductoModel pro;
        #region cruds
        public void Create(Producto p)
        {
            pro.Add(p);
        }

        public Producto[] FindAll()
        {
            return productos;
        }
        #endregion

        #region Metodos
        public decimal CalcularDepresionLineaRecta(decimal ValorDelActivo, int TimpoDeVida)
        {
            decimal Valor = ValorDelActivo / TimpoDeVida;
            return Valor;
        }

        public decimal CalcularDepresionSDA(decimal ValorDelActivo, int TimpoDeVida)
        {
            decimal Valor1 = (TimpoDeVida+ 1);
            decimal Valor2 = TimpoDeVida * Valor1;
            decimal Valor3 = Valor2 / 2;
            decimal Valor4 = ValorDelActivo * Valor3;

            return Valor4;
        }


        public decimal PEPS(decimal salida)
        {
            if (productos == null)
            { throw new Exception("No hay producyos para calcular"); }
            if (salida > productos[0].Existencia)
            { throw new Exception("para evitar problemas divida las compras "); }
            decimal valor = productos[0].Precio;
            Vender(salida);
            decimal valordeinventa = valor * salida;
            decimal totaldeventas = valor;
            return valor;
        }
        public Producto PP(Producto p, decimal VTT, int unidades)
        {
            decimal nuevoVAlorporUnidad = p.VAlorTotalDemercancia / p.Existencia;

            decimal nuevovalortotal = (p.VAlorTotalDemercancia + VTT);


            Producto yx = new Producto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia,
                Precio = p.Precio,

                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = nuevovalortotal,
                valoporUnidad = nuevoVAlorporUnidad,



            };

            Create(yx);
            return yx;


        }
        public Producto PPsalida(Producto p, int unidades)
        {
            Producto yx = new Producto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia - unidades,
                Precio = p.Precio,

                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = p.VAlorTotalDemercancia,
                valoporUnidad = p.VAlorTotalDemercancia,



            };

            Create(yx);
            return yx;
        }
        public Producto PS(Producto p, decimal VTT, int unidades)
        {
            decimal nuevoVAlorporUnidad = p.VAlorTotalDemercancia / p.Existencia;

            decimal nuevovalortotal = (p.VAlorTotalDemercancia + VTT);


            Producto yx = new Producto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia,
                Precio = p.Precio,

                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = nuevovalortotal,
                valoporUnidad = nuevoVAlorporUnidad,



            };

            Create(yx);
            return yx;

        }
        public Producto PSsalida(Producto p, int unidades)
        {
            Producto yx = new Producto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia - unidades,
                Precio = p.Precio,

                UnidadMedida = p.UnidadMedida,
                VAlorTotalDemercancia = p.VAlorTotalDemercancia,
                valoporUnidad = p.VAlorTotalDemercancia,



            };

            Create(yx);
            return yx;



        }
        public decimal UEPS(decimal salida)
        {
            if (productos == null)
            { throw new Exception("No hay productos para calcular"); }
            if (salida > productos[0].Existencia)
            { throw new Exception("para evitar problemas divida las compras "); }
            decimal valo = productos[0].Precio;
            Vender(salida);
            decimal valordeinventa = valo * salida;
            decimal totaldeventas = valo;
            return valo;
        }
        #endregion

        #region Privados
        private  void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("Error, el producto no puede ser null.");
            }

            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
                return;
            }

            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = p;
            productos = tmp;
        }
        private decimal Vender(decimal a)
        {

            while (a > productos[0].Existencia)
            {
                a = a - productos[0].Existencia;

                if (productos[0].Existencia - a == 0)
                {
                    a = 0;
                    return a;
                }
            }
            return a;
        }
        #endregion

    }
}
