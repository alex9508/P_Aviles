using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class NaturalJoin
    {
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string nombre_usuario { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string tipo { get; set; }

        public NaturalJoin() { }

        public NaturalJoin(int a, int b, string c, string d, string e, string f, string g, string h)
        {
            this.id_usuario = a;
            this.id_cliente = b;
            this.telefono_cliente = c;
            this.nom_cliente = d;
            this.nombre_usuario = e;
            this.user = f;
            this.password = g;
            this.tipo = h;
        }
    }
}
