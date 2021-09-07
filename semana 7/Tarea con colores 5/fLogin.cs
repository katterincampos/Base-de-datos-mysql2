using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_con_colores_5
{
   
    public partial class fLogin : Form
    {
        string usuario = "usuario1";
        string contraseña = "usuario1";

        public fLogin()
        {
            InitializeComponent();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text != contraseña  || txtcontra.Text != contraseña  )
            {
                if (txtusuario.Text != usuario )
                {
                    MessageBox.Show("Usuario incorrecto");
                    txtusuario.Clear();
                    txtusuario.Focus();
                    return;
                }
                if (txtcontra.Text!=contraseña )
                {
                    MessageBox.Show("La contrsaseña ingresada es incorrecta");
                    txtcontra.Clear();
                    txtcontra.Focus();
                    return;
                }
            }
            else
            {
                Form menu = new Menú();
                this.Hide();
                menu.ShowDialog();
                

            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
