using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAviles
{
    public partial class PanelPrincipal : Form
    {
        public bool ad01, Us01;
        public int AD_USER_ONLINE_PNL_PRIN;
        public string nombre;

        public PanelPrincipal(bool x, bool y, string n, int z)
        {
            InitializeComponent();

            btnClSes.Hide();

            this.ad01 = x;
            this.Us01 = y;
            this.AD_USER_ONLINE_PNL_PRIN = z;

            if(ad01 == true)
            {
                PicUs.Hide();
                lblUsers.Hide();
                this.lblAdmin.Text = n;
            }
            else if(Us01 == true)
            {
                this.lblUsers.Text = n;
                PicAd.Hide();
                lblAdmin.Hide();
                btnEgresos.Hide();
                btnAU.Hide();
                
            }
        }

        public PanelPrincipal()
        {
            InitializeComponent();

            btnClSes.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 58)
            {
                panel2.Width = 158;

                PanelAnimator.ShowSync(panel2);
                LogoAnimator.Show(lblmenu);
                PicLog.Width = 600;
                btnClSes.Hide();
                btnSesion.Show();
            }
            else
            {
                LogoAnimator.Hide(lblmenu);
                panel2.Width = 58;
                PanelAnimator.ShowSync(panel2);
                PicLog.Width = 500;
                btnClSes.Show();
                btnSesion.Hide();
            }
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            VentasyLista nvo = new VentasyLista(AD_USER_ONLINE_PNL_PRIN);
            nvo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes nvo = new Clientes(AD_USER_ONLINE_PNL_PRIN);
            nvo.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas nvo = new Consultas(ad01,Us01);
            nvo.Show();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            Egresos nvo = new Egresos(AD_USER_ONLINE_PNL_PRIN);
            nvo.Show();
        }

        private void btnClSes_Click(object sender, EventArgs e)
        {
            int plat = 1;
            this.Close();
            Login nvo = new Login(plat);
            nvo.Show();
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            NewUsers nvo = new NewUsers();
            nvo.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            int plat = 1;
            this.Close();
            Login nvo = new Login(plat);
            nvo.Show();
        }
    }
}
