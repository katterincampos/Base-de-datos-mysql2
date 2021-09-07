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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;



        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtldArticulo.Text!=""&& txtNombre.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "" )

                {
                    ListaVenta[Fila, 0] = txtldArticulo.Text;
                    ListaVenta[Fila, 1] = txtNombre.Text;
                    ListaVenta[Fila, 2] = txtPrecio.Text;
                    ListaVenta[Fila, 3] = txtCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txtPrecio.Text)*float.Parse (txtCantidad.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);

                    Fila++;
                    txtldArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";
                    txtldArticulo.Focus();
                }
            }
            catch
            {

            }
            CostoApagar();
        }

        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount;

            for (int i = 0; i < Conteo; i++)
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            lblCostoApagar.Text = CostoTotal.ToString();

        }

        private void txtVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta realizada, ¡¡Gracias por su compra que tenga excelente día!!. ",
               "EMPRESA ELECTRIC ",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch
            {
                lblDevolucion.Text = "0.00";
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}







