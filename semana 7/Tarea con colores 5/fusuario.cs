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
    }
}
