using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpFinal.Clases.Concecionaria;

namespace tpFinal
{
    public partial class FormConcesionaria : Form
    {

        GestorConcesionaria gestorConcesionaria;
        int seleccionado = -1;
        public FormConcesionaria()
        {
            InitializeComponent();
            gestorConcesionaria = new GestorConcesionaria();
            MostrarPedido();
        }


        private void btnAltaPedidos_Click(object sender, EventArgs e)
        {
            if (cmbModeloPedidos.Text!=""&&cmbConcesionariaPedidos.Text!=""&&nudCantidadPedidos.Value>0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloPedidos.Text);
                int numeroConcesionaria = Convert.ToInt32(cmbConcesionariaPedidos.Text);
                int cantidadPedido = Convert.ToInt32(nudCantidadPedidos.Value);

                Concesionaria nuevoPedido = new Concesionaria(numeroModelo, numeroConcesionaria, cantidadPedido);
                gestorConcesionaria.GuardarPedido(nuevoPedido);
                MostrarPedido();
                seleccionado = -1;
            }
            else
            {
                MessageBox.Show("Falta rellenar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        public void MostrarPedido()
        {
            this.dgvConcesionariaPedidos.DataSource = null;
            this.dgvConcesionariaPedidos.DataSource = gestorConcesionaria.leerConcesionarias();
        }

        private void dgvConcesionariaPedidos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;

            cmbModeloPedidos.Text = dgvConcesionariaPedidos.Rows[seleccionado].Cells[0].Value.ToString();
            cmbConcesionariaPedidos.Text = dgvConcesionariaPedidos.Rows[seleccionado].Cells[1].Value.ToString();
            nudCantidadPedidos.Text = dgvConcesionariaPedidos.Rows[seleccionado].Cells[2].Value.ToString();
        }

        private void btnBajaPedidos_Click_1(object sender, EventArgs e)
        {
            if (seleccionado != -1)
            {
                gestorConcesionaria.Baja(seleccionado);

                MostrarPedido();
                seleccionado = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un campo para eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarPeddidos_Click(object sender, EventArgs e)
        {
            if (seleccionado != -1 && cmbModeloPedidos.Text != "" && cmbConcesionariaPedidos.Text != "" && nudCantidadPedidos.Value > 0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloPedidos.Text);
                int numeroConcesionaria = Convert.ToInt32(cmbConcesionariaPedidos.Text);
                int cantidadPedido = Convert.ToInt32(nudCantidadPedidos.Value);


                gestorConcesionaria.Modificar(numeroModelo, numeroConcesionaria, cantidadPedido, seleccionado);
                MostrarPedido();
                seleccionado = -1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo y todos los campos deben estar completos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
