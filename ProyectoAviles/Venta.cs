using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using ProyectoAviles.MySql;

namespace ProyectoAviles
{
    public partial class Venta : Form
    {
        public int tipo,id_clienteNum, cantidad, Id_user_online_ventas;
        public bool EsNum;
        public double precio;
        public string cantitxtbx, tipoGrnd, tipoChco, DireccionEnvio, id_clienteStr;
        public int ididid;
        
        public Venta(int z)
        {
            InitializeComponent();
            this.Id_user_online_ventas = z;
            txtbxID_USER_ONLINE.Text = Id_user_online_ventas.ToString();
        }

        private void txtbxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        public Venta()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnGrande_CheckedChanged(object sender)
        {
            tipo = 1;
            tipoGrnd = "40x20x14";
        }

        private void rdbtnChico_CheckedChanged(object sender)
        {
            tipo = 2;
            tipoChco = "40x20x12";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            cantitxtbx = txtbxCantidad.Text;

            EsNum = int.TryParse(cantitxtbx, out cantidad);

            if(tipo == 1)
            {
                lblELEtipo.Text = tipoGrnd;
                precio = cantidad * 8;

            }
            else
            {
                lblELEtipo.Text = tipoChco;
                precio = cantidad * 7.2;
            }

            lblCantidadF.Text = cantidad.ToString();
            lblTotalVen.Text = precio.ToString();
        }

        private void btnREalVenta_Click(object sender, EventArgs e)
        {
            id_clienteStr = txtbxID_Cliente.Text;
            EsNum = int.TryParse(id_clienteStr, out id_clienteNum);

            DireccionEnvio = txtbxDireccion.Text;

            EsNum = int.TryParse(txtbxID_USER_ONLINE.Text, out ididid);

            if(string.IsNullOrEmpty(txtbxID_Cliente.Text) || string.IsNullOrEmpty(txtbxDireccion.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                Ventas agregar = new Ventas();

                agregar.cant_piezas = cantidad;
                agregar.importe_total = precio;
                agregar.destino = DireccionEnvio;
                agregar.id_usuario = Id_user_online_ventas;
                agregar.id_cliente = id_clienteNum;
                agregar.id_producto = tipo;

                int retorno = Funciones.AgregarVenta(agregar);

                MessageBox.Show("Venta exitosa");

            }
        }
    }
}
