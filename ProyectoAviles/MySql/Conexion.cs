using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoAviles.MySql
{
    class Conexion
    {
        public static MySqlConnection obtener()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=blockera;Uid=root;pwd=al1999ex;");
            conectar.Open();
            return conectar;
            conectar.Close();
        }
    }
}
