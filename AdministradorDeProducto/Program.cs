using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Dominio.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeProducto
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

           

            builder.RegisterType<Productoservice>().As<IProductoService>();
            builder.RegisterType<ProductoModel>().As<IProductomodel>();
            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IProductoService>()));
        }
    }
}
