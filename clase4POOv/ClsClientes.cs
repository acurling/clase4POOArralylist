using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4POOv
{
    internal class ClsClientes
    {
        private int id;
        private string nombre;

        public ClsClientes(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int getId() { return id; }
        public string getNombre() { return nombre; }

        public void SetID(int id) { this.id = id; }
        public void Setnombre(string nombre) { this.nombre = nombre; }

        public static void Agregar() { Console.WriteLine("Se agrego un cliente"); }
        public static void Borrar() { Console.WriteLine("Se borro un cliente"); }
        public static void Consultar() { Console.WriteLine("Se consulto un cliente"); } 

    }
}
