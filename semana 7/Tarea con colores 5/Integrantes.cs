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
    public partial class Integrantes : Form
    {
        public Integrantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS019021", "José Alexander Salinas Lobos",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS000621", "Karla Beatriz Castellanos Serpas",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS002221", "Juan Carlos Mejía Morales",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS001821", "Juan Alfredo Martínez Molina",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS016021", "Katterin Yeferin Campos Rodriguez",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USIS040821", "Emerson Samuel Mejía Cerón",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Integrantes_Load(object sender, EventArgs e)
        {

        }
    }
}
