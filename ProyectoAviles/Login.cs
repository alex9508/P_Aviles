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
using System.Threading;
using ProyectoAviles.MySql;

namespace ProyectoAviles
{
    public partial class Login : Form
    {
        public int falt;
        MySqlCommand cmd = new MySqlCommand();
        public bool Ad, Us,EsNum;
        public int splatch;
        public string nombrelog;
        public string ID_USER_ONLINE_STR;
        public int ID_USER_ONLINE;

        public Login()
        {
            InitializeComponent();

            if (splatch != 1)
            {
                Thread t = new Thread(new ThreadStart(startForm));
                t.Start();
                Thread.Sleep(5000);
                t.Abort();
            }
        }

        public Login(int x)
        {
            InitializeComponent();
            this.falt = x;
        }

        public void startForm()
        {
            Application.Run(new Splash());
        }

        public void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Ad = false;
            Us = false;

            Conexion.obtener();
            cmd.Connection = Conexion.obtener();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from usuario where user = '" + txtbUser.Text + "'and password = '" + txtbPass.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            ada.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                this.Hide();
                
                if (tabla.Rows[0][4].ToString() == "Admin")
                {
                    Ad = true;
                    Us = false;
                    nombrelog = tabla.Rows[0][1].ToString();
                    ID_USER_ONLINE_STR = tabla.Rows[0][0].ToString();
                    EsNum = int.TryParse(ID_USER_ONLINE_STR, out ID_USER_ONLINE);

                }
                else if (tabla.Rows[0][4].ToString() == "Usuario")
                {
                    Us = true;
                    Ad = false;
                    nombrelog = tabla.Rows[0][1].ToString();
                    ID_USER_ONLINE_STR = tabla.Rows[0][0].ToString();
                    EsNum = int.TryParse(ID_USER_ONLINE_STR, out ID_USER_ONLINE);
                }
                
                PanelPrincipal pnl = new PanelPrincipal(Ad, Us, nombrelog, ID_USER_ONLINE);
                pnl.Show();

                Succes nvo = new Succes();
                nvo.Show();
            }
            else
            {
                Fail fallo = new Fail();
                fallo.Show();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
