using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAviles.MySql
{
    class Ventas
    {
        public int id_cliente { get; set; }
        public int folio_venta { get; set; }
        public double importe_total { get; set; }
        public int cant_piezas { get; set; }
        public int id_producto { get; set; }
        public string destino { get; set; }
        public int id_usuario { get; set; }

        /*
         * 
         * Nventa.id_cliente = leer.GetInt32(0);
                Nventa.folio_venta = leer.GetInt32(1);
                Nventa.importe_total = leer.GetDouble(2);
                Nventa.cant_piezas = leer.GetInt32(3);
                Nventa.id_producto = leer.GetInt32(4);
                Nventa.destino = leer.GetString(5);
                Nventa.id_usuario = leer.GetInt32(6);
         * 
         * */

        public Ventas() { }

        public Ventas(int client, int folio, double importe, int cantidad, int produc, string destino, int user)
        {

            this.id_cliente = client;
            this.folio_venta = folio;
            this.importe_total = importe;
            this.cant_piezas = cantidad;
            this.id_producto = produc;
            this.destino = destino;
            this.id_usuario = user;
            
        }

    }
}
