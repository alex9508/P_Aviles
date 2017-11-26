using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class Cliente
    {
        public int id_cliente { get; set; }
        public int id_usuario { get; set; }
        public string telefono_cliente { get; set; }
        public string nom_cliente { get; set; }

        public Cliente() { }

        public Cliente(int id_c, int id_u, string tel, string nombre)
        {
            this.id_cliente = id_c;
            this.id_usuario = id_u;
            this.telefono_cliente = tel;
            this.nom_cliente = nombre;
        }
    }
}
