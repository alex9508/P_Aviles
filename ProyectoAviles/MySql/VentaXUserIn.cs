using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class VentaXUserIn
    {
        public int id_usuario { get; set; }
        public int folio_venta { get; set; }

        public VentaXUserIn() { }

        public VentaXUserIn(int x, int y)
        {
            this.id_usuario = x;
            this.folio_venta = y;
        }
    }
}
