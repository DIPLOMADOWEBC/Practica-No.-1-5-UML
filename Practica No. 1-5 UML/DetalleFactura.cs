using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_5_UML
{
    public class DetalleFactura
    {
        private Producto producto;
        public Producto Producto { get { return producto; } }

        public decimal Cantidad { get; set; }

        private decimal total;
        public decimal Total { get { return total; } }

        public void AddLinea(Producto producto, decimal cantidad)
        {
            this.producto = producto;

            if (this.Cantidad == 0)
                this.Cantidad = cantidad;

            this.total = this.Cantidad * this.producto.Precio;
        }
    }
}
