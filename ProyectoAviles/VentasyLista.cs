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
    public partial class VentasyLista : Form
    {
        public int Tipo, id_clienteNum, cantidad, Id_user_online_ventas;
        public bool EsNum,trie;
        public double precio;
        public string cantitxtbx, tipoGrnd, tipoChco, DireccionEnvio, id_clienteStr;
        public int ididid;
        
        public VentasyLista(int z)
        {
            InitializeComponent();
            this.Id_user_online_ventas = z;
            lblID_USER_ONLINE.Text = Id_user_online_ventas.ToString();
            dtgvwVENTAS.DataSource = Funciones.mostrar();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            dtgvwVENTAS.DataSource = Funciones.mostrar();
            //dtgvENLISTARTODO.DataSource = Funciones.MostrarClientesASC();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            dtgvwVENTAS.DataSource = Funciones.MostrarClientes();
        }

        public VentasyLista()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if(!trie)
            {
                MessageBox.Show("Solo se admiten números !!!");
            }
            
            else
            {
                if (Tipo == 1)
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
        }

        private void txtbxCantidad_TextChanged(object sender, EventArgs e)
        {
            cantitxtbx = txtbxCantidad.Text;

            EsNum = int.TryParse(cantitxtbx, out cantidad);

            if (EsNum)
            {
                trie = true;
            }
            else
                trie = false;
        }
        
        private void VentasyLista_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbtnGrande_CheckedChanged(object sender)
        {
            Tipo = 1;
            tipoGrnd = "40x20x14";
        }

        private void rdbtnChico_CheckedChanged(object sender)
        {
            Tipo = 2;
            tipoChco = "40x20x12";
        }

        private void btnREalVenta_Click(object sender, EventArgs e)
        {
            id_clienteStr = txtbxID_Cliente.Text;
            EsNum = int.TryParse(id_clienteStr, out id_clienteNum);

            DireccionEnvio = txtbxDireccion.Text;

            if (string.IsNullOrEmpty(txtbxID_Cliente.Text) || string.IsNullOrEmpty(txtbxDireccion.Text))
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
                agregar.id_producto = Tipo;

                int retorno = Funciones.AgregarVenta(agregar);

                MessageBox.Show("Venta exitosa");

            }
        }
    }
}
