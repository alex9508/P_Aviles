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
    public partial class Egresos : Form
    {

        public string descripcion, montoSTR;
        public int monto, id_us_online;
        public bool EsNum;
        public int bandera1, bandera2;
        
        public Egresos()
        {
            InitializeComponent();

            dtgwEgresos.Hide();
            panel3.Hide();

            bandera1 = 0;
            bandera2 = 0;
        }
        
        public Egresos(int z)
        {
            InitializeComponent();

            this.id_us_online = z;

            lblID_USER_ONLINE.Text = id_us_online.ToString();

            dtgwEgresos.Hide();
            panel3.Hide();

            bandera1 = 0;
            bandera2 = 0;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(bandera1 == 0)
            {
                dtgwEgresos.Visible = true;
                panel3.Visible = false;
                bandera1 = 1;
                dtgwEgresos.DataSource = Funciones.MostrarEgresos();
            }

            else
            {
                dtgwEgresos.Visible = false;
                panel3.Visible = false;
                bandera1 = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(bandera2 == 0)
            {
                dtgwEgresos.Visible = false;
                panel3.Visible = true;
                bandera2 = 1;
            }
            
            else
            {
                dtgwEgresos.Visible = false;
                panel3.Visible = false;
                bandera2 = 0;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            descripcion = txtbxDescripcion.Text;
            montoSTR = txtbxMonto.Text;

            EsNum = int.TryParse(montoSTR, out monto);

            if (string.IsNullOrEmpty(txtbxDescripcion.Text) || string.IsNullOrEmpty(txtbxMonto.Text))
            {
                MessageBox.Show("Todos los campos deben estar cubiertos !!! ");
            }

            else if (!EsNum)
            {
                MessageBox.Show("Solo se permite el ingreso de numeros en 'Monto' !!! ");
            }

            else
            {
                EgresosClase nvo = new EgresosClase();

                nvo.descripcion = descripcion;
                nvo.monto = monto;
                nvo.id_usuario = id_us_online;

                int retorno = Funciones.AgregarEgreso(nvo);
                
                MessageBox.Show("Egreso Agregado Satisfactoriamente");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
