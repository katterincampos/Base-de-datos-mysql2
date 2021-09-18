using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Tarea_con_colores_5
{
   
    public partial class fLogin : Form
    {
        

        public fLogin()
        {
            InitializeComponent();
        }
        //  conexion de la base de datos
        OleDbConnection con = new OleDbConnection (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source= Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:/Users/Jose Lobos/OneDrive - Universidad Gerardo Barrios/Escritorio/Base de Datos/Database1.mdb");

        SqlConnection conexion = new SqlConnection("server= LAPTOP-3RAU1QMD; database=programacion1; INTEGRATED SECURITY = true");

        private void baceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string password = txtcontra.Text;

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM usuarios WHERE usuario= '" + txtusuario.Text + "' and password= '" + txtcontra.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int contador = dt.Rows.Count;
            if (contador > 0)

            {
                string tipo = dt.Rows[0]["tipo usuario"].ToString();
                if (tipo == "1")

                {
                    MessageBox.Show("estandar");
                    this.Hide();
                    frmestandar frm = new frmestandar();
                    frm.Show();
                }
                else if (tipo == "2")
                {
                    MessageBox.Show("Admin");
                    this.Hide();
                    formadmin frm = new formadmin();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("USUARIO NO AUTORIZADO");
                }
            }
            con.Close();
        }



        private void fLogin_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado a la base de datos");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo conectar a la base datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT usuario, contraseña from ingreso where usuario='" + txtusuario.Text + "'and contraseña = '" + txtcontra.Text + "'", conexion);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Menú pantalla = new Menú();
                    pantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña de acceso incorrecto", "Error");

                }



            }
        }
    }
}






