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
    public partial class Ayuda2 : Form
    {
        public Ayuda2()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si tienes problemas con tu equipo adquirido llama a los números proporcionados al momento de tu compra, para brindarte ayuda más detallada sobre tu problema",
               "AYUDA PROFESIONAL ",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para la compra de tu computadora toma en cuenta las siguientes sugerencias:  " +
               " 1. Para que trabajo necesitaras tu computadora " +
               " 2. Que capacidad necesitas que tengan tu computadora " +
               " 3. Tamaño que deseas tu computadora " +
               " 4.Tipo de portabilidad que necesitas en tu computadora. " +

               " Esperamos tomes en cuenta las recomendaciones proporcionadas anteriormente para tener una compra exitosa, feliz día"

               , "SUGERENCIAS DE COMPRA",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Cliente estas satisfecho con el servicio brindado?", "COMENTARIOS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("¡¡Gracias por tu aportación esperamos vuelvas pronto!!", "COMENTARIOS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
