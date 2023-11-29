using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpFinal
{
    public partial class FormConcesionaria : Form
    {

        GestorConcesionaria gestorConcesionaria;
        public FormConcesionaria()
        {
            InitializeComponent();
            gestorConcesionaria = new GestorConcesionaria();
            MostrarPedido();
        }


        private void btnAltaPedidos_Click(object sender, EventArgs e)
        {
            int numeroModelo = Convert.ToInt32(cmbModeloPedidos.Text);
            int numeroConcesionaria = Convert.ToInt32(cmbConcesionariaPedidos.Text);
            int cantidadPedido = Convert.ToInt32(nudCantidadPedidos.Value);

            Concesionaria nuevoPedido = new Concesionaria(numeroModelo, numeroConcesionaria, cantidadPedido);
            gestorConcesionaria.GuardarPedido(nuevoPedido);
            MostrarPedido();
        }

        public void MostrarPedido()
        {
            this.dgvConcesionariaPedidos.DataSource = null;
            this.dgvConcesionariaPedidos.DataSource = gestorConcesionaria.leerConcesionarias();
        }
    }
}
