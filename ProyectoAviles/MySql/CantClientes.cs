using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class CantClientes
    {
        public int Total_Clientes { get; set; }

        public CantClientes() { }

        public CantClientes(int x)
        {
            this.Total_Clientes = x;
        }
    }
}
