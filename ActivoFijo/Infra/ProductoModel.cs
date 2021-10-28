using AppCore.Interface;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class ProductoModel<Producto> : IProductoModel
    {

       private  Producto[] producto;
        public decimal CalcularDepresionLineaRecta(decimal ValorDelActivo, int TimpoDeVida)
        {
            decimal v = ValorDelActivo / TimpoDeVida;
            return v;
        }

        public decimal CalcularDepresionSDA(decimal ValorDelActivo, int TimpoDeVida)
        {
            Decimal Valor1 = TimpoDeVida + 1;
            Decimal Valor2 = Valor1 *TimpoDeVida ;
            Decimal Valor3 = Valor2 /2;
            Decimal Valor4 = TimpoDeVida / Valor3;
            decimal valort = ValorDelActivo * Valor4;
            return valort;
        }

        public void Create(Dominio.Producto p)
        {
            throw new NotImplementedException();
        }

        public Dominio.Producto[] FindAll()
        {
            throw new NotImplementedException();
        }

        public decimal PEPS(decimal salida)
        {
            throw new NotImplementedException();
        }

        public Dominio.Producto PP(Dominio.Producto p, decimal VTT, int unidades)
        {
            throw new NotImplementedException();
        }

        public Dominio.Producto PPsalida(Dominio.Producto p, int unidades)
        {
            throw new NotImplementedException();
        }

        public Dominio.Producto PS(Dominio.Producto p, decimal VTT, int unidades)
        {
            throw new NotImplementedException();
        }

        public Dominio.Producto PSsalida(Dominio.Producto p, int unidades)
        {
            throw new NotImplementedException();
        }

        public decimal UEPS(decimal salida)
        {
            throw new NotImplementedException();
        }

        //privados 
        private void Adda(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
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
            if (producto == null)
            {
                return index;
            }

            foreach (Producto p in producto)
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
        private decimal Vender(decimal a)
        {

            while (a > producto[0].Existencia)
            {
                a = a - producto[0].Existencia;

                if (producto[0].Existencia - a == 0)
                {
                    a = 0;
                    return a;
                }
            }
            return a;
        }
    }
}
