using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class Leftmy
    {
        public int id_cliente { get; set; }
        public int id_producto { get; set; }

        public Leftmy() { }

        public Leftmy(int x, int y)
        {
            this.id_cliente = x;
            this.id_producto = y;
        }
    }
}
