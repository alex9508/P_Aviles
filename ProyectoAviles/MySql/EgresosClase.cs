using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class EgresosClase
    {
        public int id_gasto { get; set; }
        public string descripcion { get; set; }
        public int monto { get; set; }
        public int id_usuario { get; set; }

        public EgresosClase() { }

        public EgresosClase(int a, string b, int c, int d)
        {
            this.id_gasto = a;
            this.descripcion = b;
            this.monto = c;
            this.id_usuario = d;
        }
    }
}
