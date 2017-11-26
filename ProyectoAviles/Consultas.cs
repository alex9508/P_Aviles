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
    public partial class Consultas : Form
    {
        public bool ADDD { get; set; }
        public bool USSSS { get; set; }

        public Consultas()
        {
            InitializeComponent();
        }

        public Consultas(bool x, bool y)
        {
            InitializeComponent();

            this.ADDD = x;
            this.USSSS = y;

            if(USSSS == true)
            {
                btnQUE_USER_VENDIO.Hide();
                btnMINVENTAUSER.Hide();
                btnTIPO_USERS.Hide();
                btnMAX.Hide();
                btnGBYMAXVENTAUSER.Hide();
                btnMIN.Hide();
                btnPROMEDIOVENTAS.Hide();
                btnUSUARIO_REGI_CLIEN.Hide();
                btnSUMVENTAUSER.Hide();
            }
            
        }

        private void btnORDENAR_ASC_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MostrarClientesASC();
        }

        private void btnCLIENTES_DES_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MostrarClientesDESC();
        }

        private void btnVER_QUIEN_COMPRO_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MostrarLeft();
        }

        private void btnCLIENTE_COMPRADO_TIPOCOMPRA_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MostrarRight();
        }

        private void btnSUMA_TOTAL_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.SumaTotalVentas();
        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.HavingMax();
        }

        private void btnGBYMAXVENTAUSER_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MaxTotalVentas();
        }

        private void btnMINVENTAUSER_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.MinTotalVentas();
        }

        private void btnSUMVENTAUSER_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.SumTotalVentasXUser();
        }

        private void btnCOMPRASXCLIENTE_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.CantidadCompras();
        }

        private void btnQUE_USER_VENDIO_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.VentasUserInd();
        }

        private void btnTIPO_USERS_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.TipoDeUsuarios();
        }

        private void btnMIN_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.HavingMin();
        }

        private void btnPROMEDIOVENTAS_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.PromedioAVG();
        }

        private void btnUSUARIO_REGI_CLIEN_Click(object sender, EventArgs e)
        {
            dtgvENLISTARTODO.DataSource = Funciones.NaturalJoin();
        }

        private void btnEXIIIIIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
