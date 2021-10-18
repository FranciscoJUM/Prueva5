using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeProducto
{
    public partial class Form1 : Form
    {
        private IProductoService service;
        public Form1(IProductoService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
