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
    public partial class Computadoras : Form
    {
        public Computadoras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas Gracias , se ah enviado con exito");
            Close();
        }

        private void Computadoras_Load(object sender, EventArgs e)
        {

        }
    }
}
