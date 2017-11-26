using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string tipo { get; set; }

        public Usuarios() { }

        public Usuarios(int x, string y, string z, string m, string n)
        {
            this.id_usuario = x;
            this.nombre_usuario = y;
            this.user = z;
            this.password = m;
            this.tipo = n;
        }
    }
}
