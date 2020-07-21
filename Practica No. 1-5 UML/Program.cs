using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_5_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new Empresa()
            {
                Nombre = "EMPRESA CxA",
                Direccion = "VIRIATO FIALLO #16 EN SANCHE JULIETA",
                RCN = "000111122005",
                Telefono = "809-880-2222"
            };

            var cliente = new Cliente()
            {
                Codigo = "00022",
                Nombre = "MANUEL",
                Apellido = "ROSARIO",
                Direccion = "ANONIMO"
            };

            var empleado = new Empleado()
            {
                Codigo = "00001",
                Nombre = "JOSE",
                Apellido = "TELIS",
                Direccion = "ANONIMO"
            };

            var factura = new Factura(empresa, cliente, empleado);
            factura.Fecha = DateTime.Now;

            Console.WriteLine("++++++++++++++++++++++++ FACTURA ++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++"+empresa.Nombre+"++++++++++++++++++++++++\n");

            while(true)
            {
                var producto = new Producto();
                var detalleFactura = new DetalleFactura();

                Console.Write("INGRECE CODIGO PRODUCTO: ");
                producto.Codigo = Console.ReadLine();
                Console.Write("INGRECE NOMBRE PRODUCTO: ");
                producto.Descripcion = Console.ReadLine();
                Console.Write("INGRECE PRECIO PRODUCTO: ");
                decimal precio, cantidad;
                if (decimal.TryParse(Console.ReadLine(), out precio) == false)
                    break;
                Console.Write("INGRECE CANTIDAD: ");
                if (decimal.TryParse(Console.ReadLine(), out cantidad) == false)
                    break;

                producto.Precio = precio;

                detalleFactura.AddLinea(producto, cantidad);
                factura.AddLineaFactura(detalleFactura);

                Console.WriteLine("\n++++++++++++++++++++++++++++ MENU +++++++++++++++++++++++++");
                Console.WriteLine("[S] CANCELAR");
                Console.WriteLine("[C] CONTINUAR");
                Console.WriteLine("[I] IMPRIMIR");

                string ou = Console.ReadLine().ToUpper();
                if (ou == "I")
                {
                    factura.Imprimir();
                }
                else if (ou == "S")
                    break;
                else
                {
                    Console.Clear();
                    Console.WriteLine("++++++++++++++++++++++++ FACTURA ++++++++++++++++++++++++");
                    Console.WriteLine("++++++++++++++++++++++++" + empresa.Nombre + "++++++++++++++++++++++++\n");
                }
            }

            Console.ReadKey();
        }
    }
}
