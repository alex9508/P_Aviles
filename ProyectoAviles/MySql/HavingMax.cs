using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class HavingMax
    {
        public int id_cliente { get; set; }
        public double Maxima_venta { get; set; }
        
        public HavingMax() { }

        public HavingMax(int y, double z)
        {
            this.id_cliente = y;
            this.Maxima_venta = z;
        }
    }
}
