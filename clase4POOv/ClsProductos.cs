using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4POOv
{
    internal class ClsProductos
    {
      private  ArrayList codigo = new ArrayList();
      private  ArrayList nombre = new ArrayList();
      private ArrayList  precio = new ArrayList();
        public  ClsProductos() { }

        public ClsProductos(int codigo, String nombre, float precio) 
        {
            this.codigo.Add(codigo);
            this.nombre.Add(nombre);
            this.precio.Add(precio);
        }

        public void Agregar()
        {
            Console.WriteLine("Ingrese el codigo:");
            codigo.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el nombre:");
            nombre.Add(Console.ReadLine());
            Console.WriteLine("Ingrese el precio:");
            precio.Add(Console.ReadLine());
            Console.WriteLine("Productos Agregados con Exito");
        }
        public void Borrar() 
        {
            int cod = 0;
            Console.WriteLine("Ingrese el codigo:");
            cod = int.Parse(Console.ReadLine());
            Boolean existe = false;
            for (int i = 0; i < codigo.Count; i++)
            {
                if (codigo[i].Equals(cod) ) // devuelve un true si el codigo existe
                {
                    codigo.RemoveAt(i); 
                    nombre.RemoveAt(i);
                    precio.RemoveAt(i);
                    existe = true;
                    Console.WriteLine("Producto borrado con Exito");
                    
                    continue;
                }
            }

           
            if (!existe)
            {
                Console.WriteLine("Articulo no existe");
            }
            Console.ReadLine();


        }
        public void Imprimir()
        
        {
            Console.Clear();
            for (int i = 0; i < codigo.Count; i++)
            {
                Console.WriteLine($"Codigo: {codigo[i]} nombre:{nombre[i]}   Precio:{precio[i]}");
            }
           Console.ReadLine();
        }  
    }
}
