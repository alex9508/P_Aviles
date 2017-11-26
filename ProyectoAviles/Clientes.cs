using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAviles.MySql;

namespace ProyectoAviles
{
    public partial class Clientes : Form
    {
        /// <add>
        public int Id_user_registra;
        public string Telefono_cliente_add;
        public string Nombre_cliente_add;
        public string ID_USER_False;
        public bool EsNum_ADD;
        /// </add>

        /// <buscar>
        public string Nombre_cliente_buscar;
        /// </buscar>
        
        public int bandera,btnb,n,bandera3;
        public int ID_USER_ONLINE_CLIENTE;

        public Clientes(int z)
        {
            InitializeComponent();

            this.ID_USER_ONLINE_CLIENTE = z;
            lblID_US.Text = ID_USER_ONLINE_CLIENTE.ToString();

            pnlAgregar.Hide();
            pnlSeacrh.Hide();
            pnlID_ELI.Hide();

            bandera = 0;
            btnb = 0;
            bandera3 = 0;

            btnVentas.Hide();
            btnCerrar.Hide();
        }

        public Clientes()
        {
            InitializeComponent();

            pnlAgregar.Hide();
            pnlSeacrh.Hide();
            pnlID_ELI.Hide();

            bandera = 0;
            btnb = 0;

            btnVentas.Hide();
            btnCerrar.Hide();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            if (bandera == 0)
            {
                dtgvNOMBRE_CLIENTE_BUSCAR.DataSource = null;
                pnlAgregar.Visible = false;
                pnlSeacrh.Visible = true;
                pnlID_ELI.Visible = false;
                btnVentas.Show();
                btnCerrar.Show();
                btnCerrarAll.Hide();
                bandera = 1;
            }
            else
            {
                dtgvNOMBRE_CLIENTE_BUSCAR.DataSource = null;
                pnlAgregar.Visible = false;
                pnlSeacrh.Visible = false;
                pnlID_ELI.Visible = false;
                btnVentas.Hide();
                btnCerrar.Hide();
                btnCerrarAll.Show();
                bandera = 0;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnb == 0)
            {
                pnlAgregar.Visible = true;
                pnlSeacrh.Visible = false;
                pnlID_ELI.Visible = false;
                btnVentas.Show();
                btnCerrar.Show();
                btnCerrarAll.Hide();
                btnb = 1;
            }
            else
            {
                pnlAgregar.Visible = false;
                pnlSeacrh.Visible = false;
                pnlID_ELI.Visible = false;
                btnVentas.Hide();
                btnCerrar.Hide();
                btnCerrarAll.Show();
                btnb = 0;
            }
        }

        private void gpbxBuscar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            Telefono_cliente_add = txtbxTELEFONO.Text;
            Nombre_cliente_add = txtbxNOMBRE_CLIENTE_ADD.Text;

            if(string.IsNullOrEmpty(txtbxTELEFONO.Text) || string.IsNullOrEmpty(txtbxNOMBRE_CLIENTE_ADD.Text))
            {
                MessageBox.Show("Todos los campos deben estar cubiertos !!! ");
            }

            else
            {
                Cliente nvo = new Cliente();

                nvo.id_usuario = ID_USER_ONLINE_CLIENTE;
                nvo.telefono_cliente = Telefono_cliente_add;
                nvo.nom_cliente = Nombre_cliente_add;

                int retorno = Funciones.AgregarCliente(nvo);

                MessageBox.Show("Cliente Agregado Satisfactoriamente");
            }
            
        }

        private void btnNOMBRE_CLIENTE_BUSCAR_Click(object sender, EventArgs e)
        {
            Nombre_cliente_buscar = txtbxNOMBRE_CLIENTE_BUSCAR.Text;

            dtgvNOMBRE_CLIENTE_BUSCAR.DataSource = Funciones.BuscarCliente(Nombre_cliente_buscar);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();

            VentasyLista nvo = new VentasyLista(ID_USER_ONLINE_CLIENTE);
            nvo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(bandera3 == 0)
            {
                pnlID_ELI.Visible = true;
                pnlAgregar.Visible = false;
                pnlSeacrh.Visible = false;
                btnVentas.Hide();
                btnCerrar.Hide();
                btnCerrarAll.Show();
                bandera3 = 1;

                dtgwEliminar.DataSource = Funciones.MostrarClientes();
                
            }

            else
            {
                pnlAgregar.Visible = false;
                pnlSeacrh.Visible = false;
                pnlID_ELI.Visible = false;
                btnVentas.Hide();
                btnCerrar.Hide();
                btnCerrarAll.Show();
                bandera3 = 0;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

        }

        public void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            string x;
            bool non;
            int uno;

            if (string.IsNullOrEmpty(txtbxID_ELIMINAR.Text))
            {
                MessageBox.Show("Todos los campos deben estar cubiertos !!! ");
            }
            else
            {
                x = txtbxID_ELIMINAR.Text;

                non = int.TryParse(x, out uno);
                int eliminando = Funciones.EliminarVenta(uno);
                int retorno = Funciones.EliminarCliente(uno);

                if (retorno > 0)
                {
                    MessageBox.Show("Cliente eliminado Satisfactoriamente");
                    elim();
                }

                else
                {
                    MessageBox.Show("Cliente no eliminado !!!");
                }
            }
        }

        public void elim()
        {
            txtbxID_ELIMINAR.Clear();
        }

        private void dtgwEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnACTUAL_Click(object sender, EventArgs e)
        {
            dtgwEliminar.DataSource = Funciones.MostrarClientes();
        }

        private void txtbxID_USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
