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
    public partial class NewUsers : Form
    {
        public int bandera1, bandera2;
        public string nom, user, pass, tipo;

        public NewUsers()
        {
            InitializeComponent();

            dtgwUSERS.Hide();
            panel2.Hide();

            bandera1 = 0;
            bandera2 = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(bandera1 == 0)
            {
                dtgwUSERS.Visible = true;
                panel2.Visible = false;
                bandera1 = 1;
                dtgwUSERS.DataSource = Funciones.MostrarUsuarios();
            }

            else
            {
                dtgwUSERS.Visible = false;
                panel2.Visible = false;
                bandera1 = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (bandera2 == 0)
            {
                dtgwUSERS.Visible = false;
                panel2.Visible = true;
                bandera2 = 1;
            }

            else
            {
                dtgwUSERS.Visible = false;
                panel2.Visible = false;
                bandera2 = 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nom = txtbxNombre.Text;
            user = txtbxUsuario.Text;
            pass = txtbxContrasenia.Text;
            tipo = cmbbxTIPO.Text;

            if(string.IsNullOrEmpty(txtbxNombre.Text) || string.IsNullOrEmpty(txtbxUsuario.Text) || string.IsNullOrEmpty(txtbxContrasenia.Text) || string.IsNullOrEmpty(cmbbxTIPO.Text))
            {
                MessageBox.Show("Todos los campos deben estar cubiertos !!! ");
            }

            else
            {
                Usuarios nvo = new Usuarios();

                nvo.nombre_usuario = nom;
                nvo.user = user;
                nvo.password = pass;
                nvo.tipo = tipo;

                int retorno = Funciones.AgregarUsuario(nvo);

                MessageBox.Show("Usuario Agregado Satisfactoriamente");
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
