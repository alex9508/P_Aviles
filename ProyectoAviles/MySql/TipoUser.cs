using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class TipoUser
    {
        public string tipo { get; set; }

        public TipoUser() { }

        public TipoUser(string x)
        {
            this.tipo = x;
        }
    }
}
