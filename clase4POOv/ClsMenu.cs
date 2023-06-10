using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace clase4POOv
{
    internal class ClsMenu
    {
        private static int opcion = 0;
        private static ClsProductos articulos = new ClsProductos();
        public ClsMenu() { }

        public static void Principal()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("1-Catalogo de clientes");
                Console.WriteLine("2-Catalogo de Articulo");
                Console.WriteLine("3-Facturacion");
                Console.WriteLine("4-Salir");
                Console.WriteLine("digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Clientes(); break;
                    case 2: Articulos(); break;
                    case 3: break;

                    default:
                        break;
                }
            } while (opcion!=3);
        }


        private static void Clientes()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1-Agregar Clientes");
                Console.WriteLine("2-Consultar Clientes");
                Console.WriteLine("3-Borrar Clientes");
                Console.WriteLine("4- Regresar");
                Console.WriteLine("digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:ClsClientes.Agregar(); break;
                    case 2: ClsClientes.Consultar(); break;
                    case 3: ClsClientes.Borrar(); break;
                    case 4: Principal(); break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }

        private static void Articulos()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1-Agregar Productos");
                Console.WriteLine("2-Consultar Productos");
                Console.WriteLine("3-Borrar Productos");
                Console.WriteLine("4- Regresar");
                Console.WriteLine("digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: articulos.Agregar(); break;
                    case 2: articulos.Imprimir(); break;
                    case 3: articulos.Borrar();  break;
                    case 4: Principal(); break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }
    }
}
