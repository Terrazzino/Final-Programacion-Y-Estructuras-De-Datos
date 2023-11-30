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
using tpFinal.Clases.Empresa;

namespace tpFinal
{
    public partial class FormConcecionaria : Form
    {
        GestorEmpresa gestorEmpresa;
        int seleccionadoStockTerminados = 0;
        public FormConcecionaria()
        {
            InitializeComponent();
            gestorEmpresa = new GestorEmpresa();
            MostrarStockTerminado();
        }

        private void btnAltaTerminado_Click(object sender, EventArgs e)
        {
            int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
            string descripcionModelo = txtDescripcionTerminado.Text;
            int stockModelo = Convert.ToInt32(nudStockTerminado.Value);

            EmpresaStockTerminado nuevoStockTerminado = new EmpresaStockTerminado(numeroModelo, descripcionModelo, stockModelo);
            gestorEmpresa.GuardarStockTerminado(nuevoStockTerminado);
            MostrarStockTerminado();
        }
        public void MostrarStockTerminado()
        {
            this.dgvTerminadosEmpresa.DataSource = null;
            this.dgvTerminadosEmpresa.DataSource = gestorEmpresa.leerStockTerminado();
        }

        private void dgvTerminadosEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoStockTerminados = e.RowIndex;

            cmbModeloTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[0].Value.ToString();
            txtDescripcionTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[1].Value.ToString();
            nudStockTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[2].Value.ToString();
        }

        private void btnBajaTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1)
            {
                gestorEmpresa.BajaStockTerminado(seleccionadoStockTerminados);

                MostrarStockTerminado();
            }
        }

        private void btnModificarTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
                string descripcionModelo = txtDescripcionTerminado.Text;
                int stockTerminado = Convert.ToInt32(nudStockTerminado.Value);


                gestorEmpresa.ModificarStockTerminado(numeroModelo, descripcionModelo, stockTerminado, seleccionadoStockTerminados);
                MostrarStockTerminado();
            }
        }
    }
}
