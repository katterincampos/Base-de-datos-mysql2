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

namespace Tarea_con_colores_5
{
    public partial class fusuario : Form
    {
        public OleDbConnection miconexion;
        public fusuario()
        {
            miconexion = new
               OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source= Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:/Users/Jose Lobos/OneDrive - Universidad Gerardo Barrios/Escritorio/Base de Datos/Database1.mdb");

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveLast();
        }

        private void fusuario_Load(object sender, EventArgs e)
        {
            
            
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox2.Enabled = false;
            this.usuariosTableAdapter.Fill(this.database1DataSet.Usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "seleccione  nivel";
            textBox1.Focus();
            button5.Visible = false;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {

                OleDbCommand guardar = new OleDbCommand(); miconexion.Open();
                guardar.Connection = miconexion; guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel]) Values('" + textBox1.Text.ToString() + "','" +
               textBox2.Text.ToString() + "','" + comboBox2.Text.ToString() + "')";
                guardar.ExecuteNonQuery(); miconexion.Close();

                button5.Visible = true; button9.Visible = false;
                textBox1.Enabled = false; textBox2.Enabled = false; comboBox2.Enabled = false; button5.Focus();
                MessageBox.Show("Usuario agregado con éxito", "Ok",
         MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.usuariosTableAdapter.Fill(this.database1DataSet.Usuarios); this.usuariosBindingSource.MoveLast();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true; textBox2.Enabled = true; comboBox2.Enabled = true; textBox1.Focus(); button7.Visible = false; button10.Visible = true;

           string usuario_modificar = textBox1.Text.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand(); miconexion.Open();
                actualizar.Connection = miconexion; actualizar.CommandType = CommandType.Text;
                string nom = textBox1.Text.ToString(); string cla = textBox2.Text.ToString(); string niv = comboBox2.Text;


                actualizar.ExecuteNonQuery(); miconexion.Close();

                button7.Visible = true; button10.Visible = false;

                textBox1.Enabled = false; textBox2.Enabled = false; comboBox2.Enabled = false;
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
    }
}
