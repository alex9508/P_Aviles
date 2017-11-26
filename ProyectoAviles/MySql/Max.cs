using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class Max
    {
        public int id_usuario { get; set; }
        public double Total { get; set; }
        
        public Max() { }

        public Max(int y, double x)
        {
            this.id_usuario = y;
            this.Total = x;
        }
    }
}
