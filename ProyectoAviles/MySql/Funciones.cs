using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoAviles.MySql
{
    class Funciones
    {
        public static int AgregarCliente(Cliente add)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("insert into cliente(id_usuario,telefono_cliente,nom_cliente) values({0}, '{1}', '{2}');", add.id_usuario,add.telefono_cliente,add.nom_cliente), Conexion.obtener());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int AgregarEgreso(EgresosClase add)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("insert into gasto(descripcion,monto,id_usuario) values('{0}', {1}, {2});", add.descripcion, add.monto, add.id_usuario), Conexion.obtener());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int AgregarUsuario(Usuarios add)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario(nombre_usuario,user,password,tipo) values('{0}', '{1}' , '{2}', '{3}' );", add.nombre_usuario, add.user, add.password, add.tipo), Conexion.obtener());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EliminarUsuario(Usuarios add)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("delete from usuario where user = '{0}';", add.user), Conexion.obtener());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EliminarCliente(int add)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("delete from cliente where id_cliente=" + add + ";"), Conexion.obtener());

            int eliminado = comando.ExecuteNonQuery();

            return eliminado;
        }

        public static int EliminarVenta(int add)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("delete from venta where id_cliente=" + add + ";"), Conexion.obtener());

            int eliminado = comando.ExecuteNonQuery();

            return eliminado;
        }

        public static List<Cliente> BuscarCliente(string nombre)
        {
            List<Cliente> ListaBuscar = new List<Cliente>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from cliente where nom_cliente LIKE '{0}%';", nombre), Conexion.obtener());
            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                Cliente a = new Cliente();
                a.id_cliente = reader.GetInt32(0);
                a.id_usuario = reader.GetInt32(1);
                a.telefono_cliente = reader.GetString(2);
                a.nom_cliente = reader.GetString(3);

                ListaBuscar.Add(a);
            }

            return ListaBuscar;
        }

        public static int AgregarVenta(Ventas add)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("insert into venta(cant_piezas, importe_total, destino, id_usuario, id_cliente, id_producto) values({0}, {1}, '{2}', {3}, {4}, {5});", add.cant_piezas, add.importe_total, add.destino, add.id_usuario, add.id_cliente, add.id_producto), Conexion.obtener());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Ventas> mostrar()
        {
            List<Ventas> lista = new List<Ventas>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select id_cliente, folio_venta, importe_total, cant_piezas,id_producto, destino, id_usuario from venta order by id_cliente asc;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas Nventa = new Ventas();
                
                Nventa.id_cliente = leer.GetInt32(0);
                Nventa.folio_venta = leer.GetInt32(1);
                Nventa.importe_total = leer.GetDouble(2);
                Nventa.cant_piezas = leer.GetInt32(3);
                Nventa.id_producto = leer.GetInt32(4);
                Nventa.destino = leer.GetString(5);
                Nventa.id_usuario = leer.GetInt32(6);

                lista.Add(Nventa);
            }

            return lista;
        }

        public static List<Cliente> MostrarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select id_cliente,nom_cliente,telefono_cliente,id_usuario from cliente;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();

                
                nvo.id_cliente = leer.GetInt32(0);
                nvo.nom_cliente = leer.GetString(1);
                nvo.telefono_cliente = leer.GetString(2);
                nvo.id_usuario = leer.GetInt32(3);
                
                lista.Add(nvo);
            }

            return lista;
        }

        public static List<Usuarios> MostrarUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select * from usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Usuarios nvo = new Usuarios();

                nvo.id_usuario = leer.GetInt32(0);
                nvo.nombre_usuario = leer.GetString(1);
                nvo.user = leer.GetString(2);
                nvo.password = leer.GetString(3);
                nvo.tipo = leer.GetString(4);

                lista.Add(nvo);
            }

            return lista;
        }

        public static List<EgresosClase> MostrarEgresos()
        {
            List<EgresosClase> lista = new List<EgresosClase>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select * from gasto;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                EgresosClase Nventa = new EgresosClase();

                Nventa.id_gasto = leer.GetInt32(0);
                Nventa.descripcion = leer.GetString(1);
                Nventa.monto = leer.GetInt32(2);
                Nventa.id_usuario = leer.GetInt32(3);

                lista.Add(Nventa);
            }

            return lista;
        }

        public static List<Cliente> MostrarClientesASC()
        {
            List<Cliente> lista = new List<Cliente>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select nom_cliente, telefono_cliente, id_cliente, id_usuario from cliente order by nom_cliente asc;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();

                nvo.nom_cliente = leer.GetString(0);
                nvo.telefono_cliente = leer.GetString(1);
                nvo.id_cliente = leer.GetInt32(2);
                nvo.id_usuario = leer.GetInt32(3);

                lista.Add(nvo);
            }

            return lista;
        }

        public static List<Cliente> MostrarClientesDESC()
        {
            List<Cliente> lista = new List<Cliente>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select nom_cliente, telefono_cliente, id_cliente, id_usuario from cliente order by nom_cliente desc;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();

                nvo.nom_cliente = leer.GetString(0);
                nvo.telefono_cliente = leer.GetString(1);
                nvo.id_cliente = leer.GetInt32(2);
                nvo.id_usuario = leer.GetInt32(3);

                lista.Add(nvo);
            }

            return lista;
        }

        public static List<Leftmy> MostrarRight()
        {
            List<Leftmy> lista = new List<Leftmy>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select cliente.id_cliente, venta.id_producto from cliente right join venta on cliente.id_cliente = venta.id_cliente order by id_cliente asc;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();
                nvo.id_cliente = leer.GetInt32(0);

                Ventas v = new Ventas();
                v.id_producto = leer.GetInt32(1);

                Leftmy com = new Leftmy();
                com.id_cliente = nvo.id_cliente;
                com.id_producto = v.id_producto;


                lista.Add(com);
            }

            return lista;
        }

        public static List<Leftmy> MostrarLeft()
        {
            List<Leftmy> lista = new List<Leftmy>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select cliente.id_cliente, venta.id_producto from cliente left join venta on cliente.id_cliente = venta.id_cliente where id_producto is not null;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();
                nvo.id_cliente = leer.GetInt32(0);

                Ventas v = new Ventas();
                v.id_producto = leer.GetInt32(1);

                Leftmy com = new Leftmy();
                com.id_cliente = nvo.id_cliente;
                com.id_producto = v.id_producto;
                
                lista.Add(com);
            }

            return lista;
        }

        public static List<Sum> SumaTotalVentas()
        {
            List<Sum> lista = new List<Sum>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("SELECT sum(importe_total) from venta;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas Nventa = new Ventas();

                Nventa.importe_total = leer.GetDouble(0);

                Sum nva = new Sum();
                nva.Total = Nventa.importe_total;

                lista.Add(nva);
            }

            return lista;
        }

        public static List<Max> MaxTotalVentas()
        {
            List<Max> lista = new List<Max>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select id_usuario, max(importe_total) from venta group by id_usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas Nventa = new Ventas();

                Nventa.id_usuario = leer.GetInt32(0);
                Nventa.importe_total = leer.GetDouble(1);
                
                Max nva = new Max();
                nva.Total = Nventa.importe_total;
                nva.id_usuario = Nventa.id_usuario;

                lista.Add(nva);
            }

            return lista;
        }

        public static List<Max> MinTotalVentas()
        {
            List<Max> lista = new List<Max>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select id_usuario, min(importe_total) from venta group by id_usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas Nventa = new Ventas();

                Nventa.id_usuario = leer.GetInt32(0);
                Nventa.importe_total = leer.GetDouble(1);

                Max nva = new Max();
                nva.Total = Nventa.importe_total;
                nva.id_usuario = Nventa.id_usuario;

                lista.Add(nva);
            }

            return lista;
        }

        public static List<Max> SumTotalVentasXUser()
        {
            List<Max> lista = new List<Max>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select id_usuario, sum(importe_total) from venta group by id_usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas Nventa = new Ventas();

                Nventa.id_usuario = leer.GetInt32(0);
                Nventa.importe_total = leer.GetDouble(1);

                Max nva = new Max();
                nva.Total = Nventa.importe_total;
                nva.id_usuario = Nventa.id_usuario;

                lista.Add(nva);
            }

            return lista;
        }

        public static List<CantClientes> CantidadCompras()
        {
            List<CantClientes> lista = new List<CantClientes>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("SELECT count(id_cliente) FROM venta;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            int cant = 0;

            while (leer.Read())
            {
                cant++;

                CantClientes nvo = new CantClientes();
                nvo.Total_Clientes = leer.GetInt32(0);

                lista.Add(nvo);
            }
            
            return lista;
        }

        public static List<VentaXUserIn> VentasUserInd()
        {
            List<VentaXUserIn> lista = new List<VentaXUserIn>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select usuario.id_usuario, venta.folio_venta from usuario join venta on usuario.id_usuario = venta.id_usuario order by id_usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Usuarios nvo = new Usuarios();
                nvo.id_usuario = leer.GetInt32(0);

                Ventas v = new Ventas();
                v.folio_venta = leer.GetInt32(1);

                VentaXUserIn com = new VentaXUserIn();
                com.id_usuario = nvo.id_usuario;
                com.folio_venta = v.folio_venta;
               

                lista.Add(com);
            }

            return lista;
        }

        public static List<TipoUser> TipoDeUsuarios()
        {
            List<TipoUser> lista = new List<TipoUser>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select distinct Tipo from usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Usuarios nvo = new Usuarios();
                nvo.tipo = leer.GetString(0);

                TipoUser com = new TipoUser();
                com.tipo = nvo.tipo;

                lista.Add(com);
            }

            return lista;
        }

        public static List<HavingMax> HavingMax()
        {
            List<HavingMax> lista = new List<HavingMax>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("SELECT id_cliente, max(importe_total) from venta;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas nvo = new Ventas();
                nvo.id_cliente = leer.GetInt32(0);
                nvo.importe_total = leer.GetDouble(1);
                
                HavingMax com = new HavingMax();
                com.id_cliente = nvo.id_cliente;
                com.Maxima_venta = nvo.importe_total;

                lista.Add(com);
            }

            return lista;
        }

        public static List<HavingMax> HavingMin()
        {
            List<HavingMax> lista = new List<HavingMax>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("SELECT id_cliente, min(importe_total) from venta;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas nvo = new Ventas();
                nvo.id_cliente = leer.GetInt32(0);
                nvo.importe_total = leer.GetDouble(1);

                HavingMax com = new HavingMax();
                com.id_cliente = nvo.id_cliente;
                com.Maxima_venta = nvo.importe_total;

                lista.Add(com);
            }

            return lista;
        }

        public static List<Sum> PromedioAVG()
        {
            List<Sum> lista = new List<Sum>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select avg(importe_total) from venta;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Ventas nvo = new Ventas();
                nvo.importe_total = leer.GetDouble(0);

                Sum com = new Sum();
                com.Total = nvo.importe_total;

                lista.Add(com);
            }

            return lista;
        }

        public static List<NaturalJoin> NaturalJoin()
        {
            List<NaturalJoin> lista = new List<NaturalJoin>();

            MySqlCommand comando1 = new MySqlCommand(string.Format("select * from cliente natural join usuario;"), Conexion.obtener());

            MySqlDataReader leer = comando1.ExecuteReader();

            while (leer.Read())
            {
                Cliente nvo = new Cliente();
                nvo.id_usuario = leer.GetInt32(0);
                nvo.id_cliente = leer.GetInt32(1);
                nvo.telefono_cliente = leer.GetString(2);
                nvo.nom_cliente = leer.GetString(3);

                Usuarios nvo1 = new Usuarios();
                nvo1.nombre_usuario = leer.GetString(4);
                nvo1.user = leer.GetString(5);
                nvo1.password = leer.GetString(6);
                nvo1.tipo = leer.GetString(7);

                NaturalJoin com = new NaturalJoin();
                com.id_usuario = nvo.id_usuario;
                com.id_cliente = nvo.id_cliente;
                com.telefono_cliente = nvo.telefono_cliente;
                com.nom_cliente = nvo.nom_cliente;
                com.nombre_usuario = nvo1.nombre_usuario;
                com.user = nvo1.user;
                com.password = nvo1.password;
                com.tipo = nvo1.tipo;

                lista.Add(com);
            }

            return lista;
        }
    }
}
